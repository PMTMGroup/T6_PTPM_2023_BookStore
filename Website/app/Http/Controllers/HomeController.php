<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;

class HomeController extends Controller
{
    public function index()
    {
        $tacgia = DB::table("Sach")->select("TacGia")->groupBy("TacGia")->get();

        $theloai = DB::table("Sach")
        ->join("TheLoaiSach", "TheLoaiSach.MaTheLoai", "=", "Sach.MaTheLoai")
        ->select("TheLoaiSach.TenTheLoai", "TheLoaiSach.MaTheLoai")
        ->groupBy("TheLoaiSach.TenTheLoai", "TheLoaiSach.MaTheLoai")->get();

        $data = DB::table("Sach")->get();

        if(session()->has('hasLogin'))
        {
            $thanhVien = DB::table('ThanhVien')->where('MaTV', session()->get('hasLogin'))->first();
            if($thanhVien)
            {
            $tenThanhVien = $thanhVien->TenThanhVien;

            $quantity_cart = DB::select("select count(*) as SoLuong from GioHang where MaND = ".session()->get('hasLogin'));
            return view('home')->with('data', $data)->with('theloai', $theloai)
            ->with('tacgia', $tacgia)->with('tenThanhVien', $tenThanhVien)->with('quantity_cart', $quantity_cart[0]->SoLuong);
            }
        }
        return view('home')->with('data', $data)->with('theloai', $theloai)->with('tacgia', $tacgia);
    }
}
