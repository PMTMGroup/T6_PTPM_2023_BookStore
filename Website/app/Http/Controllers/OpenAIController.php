<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use OpenAI\Laravel\Facades\OpenAI;

class OpenAIController extends Controller
{
    public function OpenAIChatBot(Request $request)
    {
        $max_lenght = 300;
        $require = ", trả lời ngắn gọn trong độ dài tối đa ".$max_lenght." kí tự thôi";
        $result = OpenAI::completions()->create([
            'max_tokens' => $max_lenght,
            'model'     => 'text-davinci-003',
            'prompt'    => $request->input.$require
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
