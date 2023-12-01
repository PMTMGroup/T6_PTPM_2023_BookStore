<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;

class CartController extends Controller
{
    public function index(){
        if(session()->has('hasLogin'))
        {
            $thanhVien = DB::table('ThanhVien')->where('MaTV', session()->get('hasLogin'))->first();
            $tenThanhVien = $thanhVien->TenThanhVien;

            $quantity_cart = DB::select("select count(*) as SoLuong from GioHang where MaND = ".session()->get('hasLogin'));

            $maTV = session()->get('hasLogin');
            $cart = DB::table('GioHang')->join('Sach', 'Sach.MaSach', '=', 'GioHang.MaSach')->where('MaND', $maTV)->get();

            return view('cart')->with('cart', $cart)
            ->with('tenThanhVien', $tenThanhVien)->with('quantity_cart', $quantity_cart[0]->SoLuong);
        }
        return redirect()->route('home.index');
    }

    public function addToCart(Request $request){
        if(session()->has('hasLogin'))
        {
            $idSach = $request->id;
            $maTV = session()->get('hasLogin');
            
            $checkExist = DB::table('GioHang')->where('MaND', $maTV)->where('MaSach', $idSach)->first();
            if($checkExist)
            {
                $quantityInCart = $checkExist->SoLuong +1;
                DB::update("update GioHang set SoLuong = ".$quantityInCart." where MaSach='".$idSach."' and MaND =".$maTV);
            }
            else{
                DB::insert('insert into GioHang values (?, ?, ?)',
                [$maTV, $idSach, 1]);
            }
        }
        else
        {
            $ipaddress = '';
            if (isset($_SERVER['HTTP_CLIENT_IP']))
                $ipaddress = $_SERVER['HTTP_CLIENT_IP'];
            else if(isset($_SERVER['HTTP_X_FORWARDED_FOR']))
                $ipaddress = $_SERVER['HTTP_X_FORWARDED_FOR'];
            else if(isset($_SERVER['HTTP_X_FORWARDED']))
                $ipaddress = $_SERVER['HTTP_X_FORWARDED'];
            else if(isset($_SERVER['HTTP_FORWARDED_FOR']))
                $ipaddress = $_SERVER['HTTP_FORWARDED_FOR'];
            else if(isset($_SERVER['HTTP_FORWARDED']))
                $ipaddress = $_SERVER['HTTP_FORWARDED'];
            else if(isset($_SERVER['REMOTE_ADDR']))
                $ipaddress = $_SERVER['REMOTE_ADDR'];
            else
                $ipaddress = 'UNKNOWN';

            $arrayIP = explode('.', $ipaddress);
            $ipaddress = "";
            foreach($arrayIP as $value)
            {
                $ipaddress .= $value;
            }

            $idSach = $request->id;

            DB::insert('insert into ThanhVien (TenThanhVien, SDT, MatKhau, TienDaMua, MaLoaiTV) 
            values (?, ?, ?, ?, ?)',
             [$ipaddress, $ipaddress,$ipaddress, 0, 'Bronze']);
             
             $account = DB::table('ThanhVien')->where('SDT', $ipaddress)->where('MatKhau', $ipaddress)->first();
            
             \Session::put('hasLogin', $account->MaTV);

            $maTV = session()->get('hasLogin');

            $checkExist = DB::table('GioHang')->where('MaND', $maTV)->where('MaSach', $idSach)->first();
            if($checkExist)
            {
                $quantityInCart = $checkExist->SoLuong +1;
                DB::update("update GioHang set SoLuong = ".$quantityInCart." where MaSach='".$idSach."' and MaND =".$maTV);
            }
            else{
                DB::insert('insert into GioHang values (?, ?, ?)',
                [$maTV, $idSach, 1]);
            }
        }
                
        return redirect()->route('home.index');
    }

    public function deleteCart(Request $request)
    {
        if(session()->has('hasLogin'))
        {
            $maTV = session()->get('hasLogin');
            $idSach = $request->id;
            DB::delete("delete from GioHang where MaND=".$maTV." and MaSach='".$idSach."'");
            return redirect()->route('cart.index');
        }
        return redirect()->route('home.index');
    }

    public function updateCart(Request $request)
    {
        if(session()->has('hasLogin'))
        {
            $maTV = session()->get('hasLogin');
            $idSach = $request->maSach;
            $soLuong = $request->quantity;
            DB::update("update GioHang set SoLuong = ".$soLuong." where MaSach='".$idSach."' and MaND =".$maTV);
            return redirect()->route('cart.index');
        }
        return redirect()->route('home.index');
    }
}
