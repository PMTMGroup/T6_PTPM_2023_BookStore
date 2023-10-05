@extends('master_layout')
@section('quantity_cart') {{ isset($quantity_cart) ? "($quantity_cart)" : ""}} @endsection
@section('content')
<div class="container container-checkout">
    <div class="box-checkout">
        <div class="box-left">
            <div class="ship">
                <label for="">Hình Thức Giao Hàng <span style="color:red">*</span></label>
                <div class="group-ship">
                    <div class="item-ship" style="opacity: .5;">
                        <input type="radio" name="ship" style="transform: scale(1.5);pointer-events: none;">
                        <img src="{{asset("images/system/fire.png")}}" alt="">
                        <p class="name">Giao hàng hỏa tốc</p>
                        <p class="price">50K</p>
                    </div>
                    <div class="item-ship" style="opacity: .5;">
                        <input type="radio" name="ship" style="transform: scale(1.5);pointer-events: none;">
                        <img src="{{asset("images/system/ghn.jpeg")}}" alt="">
                        <p class="name">Giao hàng nhanh</p>
                        <p class="price">30K</p>
                    </div>
                    <div class="item-ship">
                        <input type="radio" name="ship" checked style="transform: scale(1.5)">
                        <img src="{{asset("images/system/ghtk.png")}}" alt="">
                        <p class="name">Giao hàng tiết kiệm</p>
                        <p class="price">20K</p>
                    </div>
                </div>
            </div>
            <div class="product">
                <label for="">Sản Phẩm Mua</label>
                <table>
                    <th></th>
                    <th></th>
                    <th></th>
                    <th></th>
                    <th></th>
                    <tr>
                        <td style="width: 150px"><img style="width: 120px; height: 100px;" src="{{asset("images/products/dac-nhan-tam.jpg")}}" alt=""></td>
                        <td style="width: 250px"><p class="name">Đây là tên sản lphaamr có thể 2 hàng có thể 2 hàng hàng có thể 2 hàng</p></td>
                        <td style="width: 150px; text-align: center;"><p class="price">200.000 <span style="text-decoration: underline;">đ</span></p></td>
                        <td style="width: 150px; text-align: center;">x2</td>
                        <td style="width: 150px; text-align: center; font-weight: 600;"><p class="price">200.000 <span style="text-decoration: underline;">đ</span></p></td>
                    </tr>
                    <tr>
                        <td style="width: 150px"><img style="width: 120px; height: 100px;" src="{{asset("images/products/dac-nhan-tam.jpg")}}" alt=""></td>
                        <td style="width: 250px"><p class="name">Đây là tên sản lphaamr có thể 2 hàng có thể 2 hàng hàng có thể 2 hàng</p></td>
                        <td style="width: 150px; text-align: center;"><p class="price">200.000 <span style="text-decoration: underline;">đ</span></p></td>
                        <td style="width: 150px; text-align: center;">x2</td>
                        <td style="width: 150px; text-align: center; font-weight: 600;"><p class="price">200.000 <span style="text-decoration: underline;">đ</span></p></td>
                    </tr>
                    <tr>
                        <td style="width: 150px"><img style="width: 120px; height: 100px;" src="{{asset("images/products/dac-nhan-tam.jpg")}}" alt=""></td>
                        <td style="width: 250px"><p class="name">Đây là tên sản lphaamr có thể 2 hàng có thể 2 hàng hàng có thể 2 hàng</p></td>
                        <td style="width: 150px; text-align: center;"><p class="price">200.000 <span style="text-decoration: underline;">đ</span></p></td>
                        <td style="width: 150px; text-align: center;">x2</td>
                        <td style="width: 150px; text-align: center; font-weight: 600;"><p class="price">200.000 <span style="text-decoration: underline;">đ</span></p></td>
                    </tr>
                    <tr>
                        <td style="width: 150px"><img style="width: 120px; height: 100px;" src="{{asset("images/products/dac-nhan-tam.jpg")}}" alt=""></td>
                        <td style="width: 250px"><p class="name">Đây là tên sản lphaamr có thể 2 hàng có thể 2 hàng hàng có thể 2 hàng</p></td>
                        <td style="width: 150px; text-align: center;"><p class="price">200.000 <span style="text-decoration: underline;">đ</span></p></td>
                        <td style="width: 150px; text-align: center;">x2</td>
                        <td style="width: 150px; text-align: center; font-weight: 600;"><p class="price">200.000 <span style="text-decoration: underline;">đ</span></p></td>
                    </tr>
                </table>
            </div>
            <div class="payment">
                <label for="">Hình Thức Thanh Toán <span style="color:red">*</span></label>
                <div class="group-payment">
                    <div class="item-payment">
                        <input type="radio" name="payment" style="transform: scale(1.5)" checked >
                        <img src="{{asset("images/system/tien-mat.png")}}" alt="">
                        <p class="name">Thanh toán tiền mặt</p>
                    </div>
                    <div class="item-payment" style="opacity: .5">
                        <input type="radio" name="payment" style="transform: scale(1.5);pointer-events: none;">
                        <img src="{{asset("images/system/banking.png")}}" alt="">
                        <p class="name">Thanh toán chuyển khoản</p>
                    </div>
                    <div class="item-payment" style="opacity: .5">
                        <input type="radio" name="payment" style="transform: scale(1.5);pointer-events: none;">
                        <img src="{{asset("images/system/momo.png")}}" alt="">
                        <p class="name">Thanh toán ví MoMo</p>
                    </div>
                </div>
            </div>
        </div>
        <div class="box-right">
            <div class="location">
                <label for="">Thông Tin Giao Hàng <span style="color:red">*</span></label>
                <div class="group-info">
                    <input type="text" name="" id="" required placeholder="Họ tên...">
                    <input type="text" name="" id="" required placeholder="Số điện thoại">
                    <input type="text" name="" id="" required placeholder="Địa chỉ nhận hàng">
                    <input type="text" name="" id="" required placeholder="Ghi chú...">
                </div>
            </div>
            <div class="location">
                <label for="">Thành Viên</label>
                <div class="group-info-endow">
                    <input type="text" name="" id="" placeholder="Số điện thoại thành viên (nếu có)...">
                    <button>Kiểm Tra</button>
                </div>
            </div>
            <div class="location">
                <label for="">Voucher</label>
                <div class="group-info-endow">
                    <input type="text" name="" id="" placeholder="Nhập mã voucher (nếu có)...">
                    <button>Áp Dụng</button>
                </div>
            </div>
            <div class="order">
                <label for="">Đơn Hàng</label>
                <div class="group-order">
                    <table>
                        <th></th>
                        <th></th>
                        <tr>
                            <td><p>Tạm tính:</p></td>
                            <td style="text-align: end;"><p>800.000đ</p></td>
                        </tr>
                        <tr>
                            <td><p>Phí vận chuyển:</p></td>
                            <td style="text-align: end;"><p>30.000đ</p></td>
                        </tr>
                        <tr>
                            <td><p>Giảm giá voucher:</p></td>
                            <td style="text-align: end; color: green"><p>-10.000đ</p></td>
                        </tr>
                        <tr>
                            <td><p>Thành viên:</p></td>
                            <td style="text-align: end; color: green"><p>-30.000đ</p></td>
                        </tr>
                    </table>
                </div>
                <div class="total-all">
                    <p style="font-weight: 600">Tổng tiền:</p>
                    <p style="font-weight: 600; color:red; font-size:20px">1.200.000đ</p>
                </div>
            </div> 
            <button class="btn-order">ĐẶT HÀNG</button>           
        </div>
    </div>
</div>
@endsection