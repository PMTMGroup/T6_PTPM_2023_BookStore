<?php

namespace App\Http\Controllers;

use App\Mail\Mailer;
use Exception;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Facades\Mail;

class CheckoutController extends Controller
{
    public function index(Request $request)
    {
        if(session()->has('hasLogin'))
        {
            $maND = session()->get('hasLogin');

            $thanhVien = DB::table('ThanhVien')->join('LoaiThanhVien', 'LoaiThanhVien.MaLoaiTV', '=', 'ThanhVien.MaLoaiTV')->where('MaTV', $maND)->first();
            $tenThanhVien = $thanhVien->TenThanhVien;
            $uuDaiThanhVien= $thanhVien->PhanTramGiamGia;
            
            $quantity_cart = DB::select("select count(*) as SoLuong from GioHang where MaND = ".$maND);

            $cart = DB::table('GioHang')->join('Sach', 'Sach.MaSach', '=', 'GioHang.MaSach')->where('MaND', $maND)->get();

            $total = DB::select("select sum(GioHang.SoLuong * Sach.GiaBan) as total from GioHang, Sach where GioHang.MaSach = Sach.MaSach and MaND=".$maND);
            $total = $total[0]->total;

            return view('checkout')->with('cart', $cart)->with('totalOrder', $total)
            ->with('tenThanhVien', $tenThanhVien)->with('uuDaiThanhVien', $uuDaiThanhVien)->with('quantity_cart', $quantity_cart[0]->SoLuong);
        }
        return redirect()->route('home.index');
    }

    public function useVoucher(Request $request)
    {
        if(session()->has('hasLogin'))
        {
            $maND = session()->get('hasLogin');

            $thanhVien = DB::table('ThanhVien')->join('LoaiThanhVien', 'LoaiThanhVien.MaLoaiTV', '=', 'ThanhVien.MaLoaiTV')->where('MaTV', $maND)->first();
            $tenThanhVien = $thanhVien->TenThanhVien;
            $uuDaiThanhVien= $thanhVien->PhanTramGiamGia;

            $quantity_cart = DB::select("select count(*) as SoLuong from GioHang where MaND = ".$maND);

            $cart = DB::table('GioHang')->join('Sach', 'Sach.MaSach', '=', 'GioHang.MaSach')->where('MaND', $maND)->get();

            $total = DB::select("select sum(GioHang.SoLuong * Sach.GiaBan) as total from GioHang, Sach where GioHang.MaSach = Sach.MaSach and MaND=".$maND);
            $total = $total[0]->total;

            $voucherInput = $request->maVoucher;
            $checkExistVoucher = DB::table('PhieuGiamGia')->where('MaGiamGia', $voucherInput)->first();
            if($checkExistVoucher)
            {
                return view('checkout')->with('cart', $cart)->with('totalOrder', $total)
                ->with('tenThanhVien', $tenThanhVien)->with('uuDaiThanhVien', $uuDaiThanhVien)->with('quantity_cart', $quantity_cart[0]->SoLuong)
                ->with('flagPGG', true)->with('phieuGiamGia', $checkExistVoucher);
            }
            return view('checkout')->with('cart', $cart)->with('totalOrder', $total)
                ->with('tenThanhVien', $tenThanhVien)->with('uuDaiThanhVien', $uuDaiThanhVien)->with('quantity_cart', $quantity_cart[0]->SoLuong)->with('flagPGG', false);
        }
        return redirect()->route('home.index');
    }

    public function order(Request $request)
    {
        try
        {
            if(session()->has('hasLogin'))
            {
                $maND = session()->get('hasLogin');
                $ngayDatHang = date('Y-m-d H:i:s');
                $hinhThucTT = "Tiền mặt";
                $maGG = $request->maGG;
                $phiShip = 20000;
                $tongTien  = $request->tongTien;

                $checkVoucher = DB::table('PhieuGiamGia')->where('MaGiamGia', $maGG)->first();
                $tongGiamVoucher = $tongTien*$checkVoucher->PhanTramGiamGia/100;

                $thanhVien = DB::table('ThanhVien')->join('LoaiThanhVien', 'LoaiThanhVien.MaLoaiTV', '=', 'ThanhVien.MaLoaiTV')
                ->where('MaTV', $maND)->first();
                $tongGiamThanhVien = $tongTien*$thanhVien->PhanTramGiamGia/100;
                
                $tongGiam = $tongGiamVoucher + $tongGiamThanhVien;
                $tongThanhTien = $tongTien - $tongGiam + $phiShip;
                $hotenNN = $request->hoTenNN;
                $sdtNN = $request->sdtNN;
                $emailNN = $request->emailNN;
                $diaChiNN = $request->diaChiNN;
                $ghiChuNN = $request->ghiChuNN;
                $trangThai = "Đang xử lý";

                DB::insert("insert into DonDatHang 
                (NgayLap, HinhThucThanhToan, MaTV, MaGiamGia, PhiShip, TongTien, TongGiam, ThanhTien, HoTenNguoiNhan, SDTNguoiNhan, Email, DiaChiNhanHang, GhiChu, TrangThaiDonHang)
                values (?,?,?,?,?,?,?,?,?,?,?,?,?,?)
                ", [
                    $ngayDatHang, $hinhThucTT, $maND, $maGG, $phiShip, $tongTien, $tongGiam, $tongThanhTien, $hotenNN, $sdtNN,$emailNN, $diaChiNN, $ghiChuNN, $trangThai
                ]);

                $donDatHang = DB::table('DonDatHang')
                ->where('NgayLap', $ngayDatHang)->where('MaTV', $maND)
                ->where('MaGiamGia', $maGG)->where('TongTien', $tongTien)
                ->where('TongGiam', $tongGiam)->where('SDTNguoiNhan', $sdtNN)->first();

                if($donDatHang)
                {
                    $soHD = $donDatHang->SoHD;
                    $dsSanPhamMua = DB::table('GioHang')->join('Sach', 'Sach.MaSach', '=', 'GioHang.MaSach')
                    ->where('MaND', $maND)->get();

                    foreach($dsSanPhamMua as $spm)
                    {
                        DB::insert("insert into ChiTietDonDatHang 
                        (SoHD, MaSach, SoLuong, TongTien)
                        values (?,?,?,?)
                        ", [
                            $soHD, $spm->MaSach, $spm->SoLuong, $spm->SoLuong*$spm->GiaBan
                        ]);
                    }

                    DB::delete('delete GioHang where MaND = ?', [$maND]);

                    Mail::to($emailNN)->send(new Mailer([
                        'email'     => $emailNN,
                        'hoTen'     => $hotenNN,
                        'soHD'      => $soHD,
                        'trangThai' => $donDatHang->TrangThaiDonHang
                    ]));
                }


                return redirect()->route('home.index');
            }
            return redirect()->route('home.index');
        }
        catch(Exception $ex)
        {
            return redirect()->route('home.index');
        }
    }
}
