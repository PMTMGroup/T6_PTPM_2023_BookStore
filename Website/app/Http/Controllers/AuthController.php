<?php

namespace App\Http\Controllers;

use Exception;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;

class AuthController extends Controller
{
    public function registerGet()
    {
        return view('register');
    }

    public function registerSubmit(Request $request)
    {
        try{
            $password = $request->password;
            $password_confirm = $request->password_confirm;

            if($password != $password_confirm)
                return view('register')->with('message', 'Xác nhận mật khẩu không trùng khớp!');

            $fullname = $request->fullname;
            $phone = $request->phone;

            $existPhone = DB::table("ThanhVien")->where('SDT', $phone)->get();
            if(count($existPhone)>0)
                return view('register')->with('message', 'Số điện thoại đã được đăng kí!');
            
            DB::insert('insert into ThanhVien (TenThanhVien, SDT, MatKhau, TienDaMua, MaLoaiTV) 
            values (?, ?, ?, ?, ?)',
             [$fullname, $phone, $password, 0, 'Bronze']);
            
            return redirect()->route('home.index');
        }
        catch(Exception $ex)
        {
            return redirect()->route('home.index');
        }
    }
}
