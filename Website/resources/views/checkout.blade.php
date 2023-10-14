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
                    @foreach($cart as $value)
                    <tr>
                        <td style="width: 150px"><img style="width: 120px; height: 100px;" src="{{asset("images/products/".$value->HinhAnh)}}" alt=""></td>
                        <td style="width: 250px"><p class="name">{{$value->TenSach}}</p></td>
                        <td style="width: 150px; text-align: center;"><p class="price">{{number_format($value->GiaBan)}} <span style="text-decoration: underline;">đ</span></p></td>
                        <td style="width: 150px; text-align: center;">{{$value->SoLuong}}</td>
                        <td style="width: 150px; text-align: center; font-weight: 600;"><p class="price">{{number_format($value->GiaBan * $value->SoLuong)}} <span style="text-decoration: underline;">đ</span></p></td>
                    </tr>
                    @endforeach
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
            <form action="{{route('checkout.voucher')}}" method="post">
                @csrf
                <div class="location">
                    <label for="">Voucher</label>
                    <div class="group-info-endow">
                        <input type="text" name="maVoucher" id="" placeholder="Nhập mã voucher (nếu có)...">
                        <button>Áp Dụng</button>
                    </div>
                    @if(isset($flagPGG))
                        @if(!$flagPGG)
                            <p style="color:red;">Voucher không hợp lệ!</p>
                        @else
                            <p style="color:green;">Voucher "{{$phieuGiamGia->TenGiamGia}}" áp dụng thành công!</p>
                        @endif
                    @endif
                </div>
            </form>
            
            <div class="location">
                
                <label for="">Thông Tin Giao Hàng <span style="color:red">*</span></label>
                <form action="{{route('checkout.order')}}" method="post">
                    @csrf
                <div class="group-info">
                    <input type="text" name="hoTenNN" id="" required placeholder="Họ tên...">
                    <input type="number" name="sdtNN" id="" required placeholder="Số điện thoại..." maxlength="12">
                    <input type="email" name="emailNN" id="" required maxlength="50" placeholder="Email nhận thông báo...">
                    <input type="text" name="diaChiNN" id="" required placeholder="Địa chỉ nhận hàng...">
                    <input type="text" name="ghiChuNN" id="" required placeholder="Ghi chú...">
                    @if(isset($flagPGG))
                        @if(!$flagPGG)
                            <input type="hidden" name="maGG" value="None">
                        @else
                            <input type="hidden" name="maGG" value="{{$phieuGiamGia->MaGiamGia}}">
                        @endif
                    @else
                        <input type="hidden" name="maGG" value="None">
                    @endif                    
                    <input type="hidden" name="tongTien" value="{{$totalOrder}}">
                    
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
                            <td style="text-align: end;"><p>{{number_format( $totalOrder)}} đ</p></td>
                        </tr>
                        <tr>
                            <td><p>Phí vận chuyển:</p></td>
                            <td style="text-align: end;"><p>20.000 đ</p></td>
                        </tr>
                        <tr>
                            <td><p>Giảm giá voucher:</p></td>
                            @if(isset($flagPGG))
                                @if(!$flagPGG)
                                    <td style="text-align: end; color: green"><p>-0 đ</p></td>
                                @else
                                    <td style="text-align: end; color: green"><p>-{{number_format($totalOrder*$phieuGiamGia->PhanTramGiamGia/100)}} đ</p></td>
                                @endif
                            @else
                                <td style="text-align: end; color: green"><p>-0 đ</p></td>
                            @endif
                            
                        </tr>
                        <tr>
                            <td><p>Thành viên:</p></td>
                            <td style="text-align: end; color: green"><p>-{{number_format($totalOrder*$uuDaiThanhVien/100)}} đ</p></td>
                        </tr>
                    </table>
                </div>
                <div class="total-all">
                    <p style="font-weight: 600">Tổng tiền:</p>
                    @if(isset($flagPGG))
                        @if(!$flagPGG)
                            <p style="font-weight: 600; color:red; font-size:20px">{{number_format($totalOrder+20000-($totalOrder*$uuDaiThanhVien/100))}} đ</p>
                        @else
                            <p style="font-weight: 600; color:red; font-size:20px">{{
                            number_format($totalOrder+20000-($totalOrder*$uuDaiThanhVien/100)-($totalOrder*$phieuGiamGia->PhanTramGiamGia/100))
                            }} đ</p>
                        @endif
                    @else                        
                        <p style="font-weight: 600; color:red; font-size:20px">{{number_format($totalOrder+20000-($totalOrder*$uuDaiThanhVien/100))}} đ</p>
                    @endif    
                </div>
            </div> 
            <button class="btn-order">ĐẶT HÀNG</button>   
        </form>        
        </div>
    </div>
</div>
@endsection