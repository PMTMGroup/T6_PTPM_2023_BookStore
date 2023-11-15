<?php

namespace App\Http\Controllers;

use App\Mail\Mailer;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Mail;

class MailController extends Controller
{
    public function sendNotification(Request $request)
    {
        $email_ip = isset($request->email) ? $request->email : 'phamchau7410@gmail.com'; 
        $hoten_ip = isset($request->hoten) ? $request->hoten : 'chaudz';
        $sohd_ip = isset($request->sohoadon) ? $request->sohoadon : '2';
        $ngaydh_ip = isset($request->ngaydathang) ? $request->ngaydathang : '12/11/2002';
        $trangthai = isset($request->trangthai) ? $request->trangthai : 'Đang giao hàng';

        $status = Mail::to($email_ip)->send(new Mailer([
            'email' => $email_ip,
            'hoTen' => $hoten_ip,
            'soHD'  => $sohd_ip,
            'ngayDatHang' => $ngaydh_ip,
            'trangThai'  => $trangthai
        ]));
            
        if (!$status) 
            return response()->json([
                'status'    => 500,
                'message'   => "Lỗi server"
            ]);
        
        return response()->json([
            'status'    => 200,
            'message'   => "Gửi thành công"
        ]);
    }

    public function index(Request $request)
    {
        return view('layout_mail');
    }
}
