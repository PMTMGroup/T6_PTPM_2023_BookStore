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
                <option value="">1</option>
                <option value="">1</option>
                <option value="">1</option>
            </select>
        </div>
        <div class="filter-item">
            <p>Thể loại:</p>
            <select name="" id="">
                <option value="" selected>-- Chọn --</option>
                <option value="">1</option>
                <option value="">1</option>
                <option value="">1</option>
            </select>
        </div>
    </div>
    <div class="product-group">
        <div class="item-product">
            <div class="image-product" 
            style="background: url({{asset("images/products/dac-nhan-tam.jpg")}}); background-size:cover;">
                <div class="genuine">CHÍNH HÃNG</div>
            </div>
            <p class="name">Đây là tên sản lphaamr có thể 2 hàng có thể 2 hàng hàng có thể 2 hàng</p>
            <p class="author">Phạm Minh Châu</p>
            <p><i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i></p>
            <div class="group-price">
                <p class="price">200.000 <span style="text-decoration: underline;">đ</span></p>
                <i class="fa fa-cart-plus" aria-hidden="true"></i>
            </div>
            
        </div>
        <div class="item-product">
            <div class="image-product" 
            style="background: url({{asset("images/products/dac-nhan-tam.jpg")}}); background-size:cover;">
                <div class="genuine">CHÍNH HÃNG</div>
            </div>
            <p class="name">Đây là tên sản lphaamr có thể 2 hàng có thể 2 hàng hàng có thể 2 hàng</p>
            <p class="author">Phạm Minh Châu</p>
            <p><i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i></p>
            <div class="group-price">
                <p class="price">200.000 <span style="text-decoration: underline;">đ</span></p>
                <i class="fa fa-cart-plus" aria-hidden="true"></i>
            </div>
            
        </div>
        <div class="item-product">
            <div class="image-product" 
            style="background: url({{asset("images/products/dac-nhan-tam.jpg")}}); background-size:cover;">
                <div class="genuine">CHÍNH HÃNG</div>
            </div>
            <p class="name">Đây là tên sản lphaamr có thể 2 hàng có thể 2 hàng hàng có thể 2 hàng</p>
            <p class="author">Phạm Minh Châu</p>
            <p><i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i></p>
            <div class="group-price">
                <p class="price">200.000 <span style="text-decoration: underline;">đ</span></p>
                <i class="fa fa-cart-plus" aria-hidden="true"></i>
            </div>
            
        </div>
        <div class="item-product">
            <div class="image-product" 
            style="background: url({{asset("images/products/dac-nhan-tam.jpg")}}); background-size:cover;">
                <div class="genuine">CHÍNH HÃNG</div>
            </div>
            <p class="name">Đây là tên sản lphaamr có thể 2 hàng có thể 2 hàng hàng có thể 2 hàng</p>
            <p class="author">Phạm Minh Châu</p>
            <p><i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i></p>
            <div class="group-price">
                <p class="price">200.000 <span style="text-decoration: underline;">đ</span></p>
                <i class="fa fa-cart-plus" aria-hidden="true"></i>
            </div>
            
        </div>
        <div class="item-product">
            <div class="image-product" 
            style="background: url({{asset("images/products/dac-nhan-tam.jpg")}}); background-size:cover;">
                <div class="genuine">CHÍNH HÃNG</div>
            </div>
            <p class="name">Đây là tên sản lphaamr có thể 2 hàng có thể 2 hàng hàng có thể 2 hàng</p>
            <p class="author">Phạm Minh Châu</p>
            <p><i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i></p>
            <div class="group-price">
                <p class="price">200.000 <span style="text-decoration: underline;">đ</span></p>
                <i class="fa fa-cart-plus" aria-hidden="true"></i>
            </div>
            
        </div>
        <div class="item-product">
            <div class="image-product" 
            style="background: url({{asset("images/products/dac-nhan-tam.jpg")}}); background-size:cover;">
                <div class="genuine">CHÍNH HÃNG</div>
            </div>
            <p class="name">Đây là tên sản lphaamr có thể 2 hàng có thể 2 hàng hàng có thể 2 hàng</p>
            <p class="author">Phạm Minh Châu</p>
            <p><i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i></p>
            <div class="group-price">
                <p class="price">200.000 <span style="text-decoration: underline;">đ</span></p>
                <i class="fa fa-cart-plus" aria-hidden="true"></i>
            </div>
            
        </div>
        <div class="item-product">
            <div class="image-product" 
            style="background: url({{asset("images/products/dac-nhan-tam.jpg")}}); background-size:cover;">
                <div class="genuine">CHÍNH HÃNG</div>
            </div>
            <p class="name">Đây là tên sản lphaamr có thể 2 hàng có thể 2 hàng hàng có thể 2 hàng</p>
            <p class="author">Phạm Minh Châu</p>
            <p><i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i></p>
            <div class="group-price">
                <p class="price">200.000 <span style="text-decoration: underline;">đ</span></p>
                <i class="fa fa-cart-plus" aria-hidden="true"></i>
            </div>
            
        </div>
        <div class="item-product">
            <div class="image-product" 
            style="background: url({{asset("images/products/dac-nhan-tam.jpg")}}); background-size:cover;">
                <div class="genuine">CHÍNH HÃNG</div>
            </div>
            <p class="name">Đây là tên sản lphaamr có thể 2 hàng có thể 2 hàng hàng có thể 2 hàng</p>
            <p class="author">Phạm Minh Châu</p>
            <p><i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i></p>
            <div class="group-price">
                <p class="price">200.000 <span style="text-decoration: underline;">đ</span></p>
                <i class="fa fa-cart-plus" aria-hidden="true"></i>
            </div>
            
        </div>
        <div class="item-product">
            <div class="image-product" 
            style="background: url({{asset("images/products/dac-nhan-tam.jpg")}}); background-size:cover;">
                <div class="genuine">CHÍNH HÃNG</div>
            </div>
            <p class="name">Đây là tên sản lphaamr có thể 2 hàng có thể 2 hàng hàng có thể 2 hàng</p>
            <p class="author">Phạm Minh Châu</p>
            <p><i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i></p>
            <div class="group-price">
                <p class="price">200.000 <span style="text-decoration: underline;">đ</span></p>
                <i class="fa fa-cart-plus" aria-hidden="true"></i>
            </div>
            
        </div>
        <div class="item-product">
            <div class="image-product" 
            style="background: url({{asset("images/products/dac-nhan-tam.jpg")}}); background-size:cover;">
                <div class="genuine">CHÍNH HÃNG</div>
            </div>
            <p class="name">Đây là tên sản lphaamr có thể 2 hàng có thể 2 hàng hàng có thể 2 hàng</p>
            <p class="author">Phạm Minh Châu</p>
            <p><i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i></p>
            <div class="group-price">
                <p class="price">200.000 <span style="text-decoration: underline;">đ</span></p>
                <i class="fa fa-cart-plus" aria-hidden="true"></i>
            </div>
            
        </div>
        <div class="item-product">
            <div class="image-product" 
            style="background: url({{asset("images/products/dac-nhan-tam.jpg")}}); background-size:cover;">
                <div class="genuine">CHÍNH HÃNG</div>
            </div>
            <p class="name">Đây là tên sản lphaamr có thể 2 hàng có thể 2 hàng hàng có thể 2 hàng</p>
            <p class="author">Phạm Minh Châu</p>
            <p><i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i>&nbsp;<i class="fa fa-star" aria-hidden="true"></i></p>
            <div class="group-price">
                <p class="price">200.000 <span style="text-decoration: underline;">đ</span></p>
                <i class="fa fa-cart-plus" aria-hidden="true"></i>
            </div>
            
        </div>
    </div>
    <div class="paginate-group">
        <a href=""><p>< Trang Trước</p></a>
        <a href=""><p>Tiếp Theo ></p></a>
    </div>
</div>
</div>
@endsection