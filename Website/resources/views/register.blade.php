@extends('master_layout')
@section('quantity_cart') {{ isset($quantity_cart) ? "($quantity_cart)" : ""}} @endsection
@section('content')

<form action="{{route('register.post.index')}}" method="post">
    @csrf
<div class="container container-register">
    <div class="register">
            <label for="">Tạo Thành Viên Mới <span style="color:red">*</span></label>
            @if(isset($message))
                <div style="background-color: rgb(252, 224, 224); width: 260px; padding: 8px 10px; border-radius:5px">
                    <p style="color:red; font-size:12px">{{$message}}</p>
                </div>
            @endif
            <input type="text" name="fullname" id="" required placeholder="Họ và tên thành viên...">
            <input type="number" name="phone" id="" required placeholder="Số điện thoại..." maxlength="12">
            <input type="password" name="password" id="" required placeholder="Mật khẩu..." maxlength="50" minlength="6">
            <input type="password" name="password_confirm" id="" required placeholder="Xác nhận mật khẩu..." maxlength="50" minlength="6">
            <button class="btn-order">Tạo Thành Viên</button>        
    </div>
</div>
</form>
@endsection