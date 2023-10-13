@extends('master_layout')
@section('quantity_cart') {{ isset($quantity_cart) ? "($quantity_cart)" : ""}} @endsection
@section('content')
<div class="container container-product">
<div class="product-box">
    <div class="filter-group">
        <div class="filter-item">
            <p>Tác giả:</p>
            <select name="" id="">
                <option value="" selected>-- Chọn --</option>
                @foreach($tacgia as $tg)
                    <option value="{{$tg->TacGia}}">{{$tg->TacGia}}</option>
                @endforeach
            </select>
        </div>
        <div class="filter-item">
            <p>Thể loại:</p>
            <select name="" id="">
                <option value="" selected>-- Chọn --</option>
                @foreach($theloai as $tl)
                    <option value="{{$tl->MaTheLoai}}">{{$tl->TenTheLoai}}</option>
                @endforeach
            </select>
        </div>
    </div>
    <div class="product-group">
        @foreach($data as $value)
        <div class="item-product">
            <div class="image-product" 
            style="background: url({{asset("images/products/".$value->HinhAnh)}}); background-size:cover;">
                <div class="genuine">CHÍNH HÃNG</div>
            </div>
            <p class="name">{{$value->TenSach}}</p>
            <p class="author">{{$value->TacGia}}</p>
            <p><i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i></p>
            <div class="group-price">
                <p class="price">{{number_format($value->GiaBan)}} <span style="text-decoration: underline;">đ</span></p>
                <i class="fa fa-cart-plus" aria-hidden="true"></i>
            </div>
            
        </div>
        @endforeach
    </div>
    <div class="paginate-group">
        <a href=""><p>< Trang Trước</p></a>
        <a href=""><p>Tiếp Theo ></p></a>
    </div>
</div>
</div>
@endsection