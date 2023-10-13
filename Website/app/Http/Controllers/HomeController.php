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

        return view('home')->with('data', $data)->with('theloai', $theloai)->with('tacgia', $tacgia);
    }
}
