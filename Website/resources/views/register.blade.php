@extends('master_layout')
@section('quantity_cart') {{ isset($quantity_cart) ? "($quantity_cart)" : ""}} @endsection
@section('content')
<div class="container container-register">
    <div class="register">
        <label for="">Tạo Thành Viên Mới <span style="color:red">*</span></label>
        <input type="text" name="" id="" required placeholder="Họ và tên thành viên...">
        <input type="number" name="" id="" required placeholder="Số điện thoại...">
        <button class="btn-order">Tạo Thành Viên</button>
    </div>
</div>
@endsection