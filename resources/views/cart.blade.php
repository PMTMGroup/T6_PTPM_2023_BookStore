@extends('master_layout')
@section('quantity_cart') {{ isset($quantity_cart) ? "($quantity_cart)" : ""}} @endsection
@section('content')
<div class="container container-cart">
    <div class="box-cart">
        <table>
            <th></th>
            <th>Tên Sách</th>
            <th>Giá Bán</th>
            <th>Số Lượng</th>
            <th>Tổng Tiền</th>
            <th>Thao Tác</th>
            <tr>
                <td style="width: 200px"><img src="{{asset("images/products/dac-nhan-tam.jpg")}}" alt=""></td>
                <td style="width: 200px"><p class="name">Đây là tên sản lphaamr có thể 2 hàng có thể 2 hàng hàng có thể 2 hàng</p></td>
                <td><p class="price">200.000 <span style="text-decoration: underline;">đ</span></p></td>
                <td><input type="number" min="1" style="width: 40px; padding: 5px; border-radius:3px" value="1"></td>
                <td><p class="price">200.000 <span style="text-decoration: underline;">đ</span></p></td>
                <td>
                    <i class="fa fa-floppy-o" aria-hidden="true" style="color:blue;font-size:24px"></i>&ensp;
                    <i class="fa fa-trash" aria-hidden="true" style="color:red;font-size:24px"></i>
                </td>
            </tr>
            <tr>
                <td style="width: 200px"><img src="{{asset("images/products/dac-nhan-tam.jpg")}}" alt=""></td>
                <td style="width: 200px"><p class="name">Đây là tên sản lphaamr có thể 2 hàng có thể 2 hàng hàng có thể 2 hàng</p></td>
                <td><p class="price">200.000 <span style="text-decoration: underline;">đ</span></p></td>
                <td><input type="number" min="1" style="width: 40px; padding: 5px; border-radius:3px" value="1"></td>
                <td><p class="price">200.000 <span style="text-decoration: underline;">đ</span></p></td>
                <td>
                    <i class="fa fa-floppy-o" aria-hidden="true" style="color:blue;font-size:24px"></i>&ensp;
                    <i class="fa fa-trash" aria-hidden="true" style="color:red;font-size:24px"></i>
                </td>
            </tr>
            <tr>
                <td style="width: 200px"><img src="{{asset("images/products/dac-nhan-tam.jpg")}}" alt=""></td>
                <td style="width: 200px"><p class="name">Đây là tên sản lphaamr có thể 2 hàng có thể 2 hàng hàng có thể 2 hàng</p></td>
                <td><p class="price">200.000 <span style="text-decoration: underline;">đ</span></p></td>
                <td><input type="number" min="1" style="width: 40px; padding: 5px; border-radius:3px" value="1"></td>
                <td><p class="price">200.000 <span style="text-decoration: underline;">đ</span></p></td>
                <td>
                    <i class="fa fa-floppy-o" aria-hidden="true" style="color:blue;font-size:24px"></i>&ensp;
                    <i class="fa fa-trash" aria-hidden="true" style="color:red;font-size:24px"></i>
                </td>
            </tr>
            <tr>
                <td style="width: 200px"><img src="{{asset("images/products/dac-nhan-tam.jpg")}}" alt=""></td>
                <td style="width: 200px"><p class="name">Đây là tên sản lphaamr có thể 2 hàng có thể 2 hàng hàng có thể 2 hàng</p></td>
                <td><p class="price">200.000 <span style="text-decoration: underline;">đ</span></p></td>
                <td><input type="number" min="1" style="width: 40px; padding: 5px; border-radius:3px" value="1"></td>
                <td><p class="price">200.000 <span style="text-decoration: underline;">đ</span></p></td>
                <td>
                    <i class="fa fa-floppy-o" aria-hidden="true" style="color:blue;font-size:24px"></i>&ensp;
                    <i class="fa fa-trash" aria-hidden="true" style="color:red;font-size:24px"></i>
                </td>
            </tr>
        </table>
        <div>
            <a href="{{route('checkout.index')}}"><button>ĐẶT HÀNG</button></a>
        </div>
    </div>
</div>
@endsection