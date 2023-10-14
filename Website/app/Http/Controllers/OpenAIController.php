<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use OpenAI\Laravel\Facades\OpenAI;

class OpenAIController extends Controller
{
    public function OpenAIChatBot(Request $request)
    {
        $dataSach = DB::table('Sach')->select("TenSach", "MaSach", "TacGia", "GiaBan", "MaTheLoai", "MaNXB")->get();
        $max_lenght = 300;
        $starting = "Tôi có dữ liệu của các Quyển Sách như sau ".$dataSach.", ";
        $require = ", trả lời ngắn gọn trong độ dài tối đa ".$max_lenght." kí tự thôi";
        $result = OpenAI::completions()->create([
            'max_tokens' => $max_lenght,
            'model'     => 'text-davinci-003',
            'prompt'    => $starting.$request->input.$require
        ]);

        $response = array_reduce(
            $result->toArray()['choices'],
            fn(string $result, array $choice)   
            => $result.$choice['text'],
            ""
        );

        return $response;
    }
}
