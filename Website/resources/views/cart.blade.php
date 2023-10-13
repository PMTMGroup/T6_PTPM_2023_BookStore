@extends('master_layout')
@section('content')
<div class="container container-cart">
    <div class="box-cart">
        @if(COUNT($cart)>0)
        <table>
            <th></th>
            <th>Tên Sách</th>
            <th>Giá Bán</th>
            <th>Số Lượng</th>
            <th>Tổng Tiền</th>
            <th>Thao Tác</th>
            @foreach($cart as $value)
            <tr>
                <td style="width: 200px"><img src="{{asset("images/products/".$value->HinhAnh)}}" alt=""></td>
                <td style="width: 200px"><p class="name">{{$value->TenSach}}</p></td>
                <td><p class="price">{{number_format($value->GiaBan)}} <span style="text-decoration: underline;">đ</span></p></td>
                <form id="formData" action="{{route('cart.update')}}" method="post">
                    @csrf
                <td><input type="number" name="quantity" min="1" style="width: 40px; padding: 5px; border-radius:3px;" value="{{$value->SoLuong}}"></td>
                <td><p class="price">{{number_format($value->GiaBan * $value->SoLuong)}} <span style="text-decoration: underline;">đ</span></p></td>
                <td>
                    <input type="hidden" name="maSach" value="{{$value->MaSach}}">
                    <button style="background-color: #ffffff"><i class="fa fa-floppy-o" aria-hidden="true" style="color:blue;font-size:24px"></i></button>&ensp;
                    <a href="{{URL::to('/cart/delete/'.$value->MaSach)}}"><i class="fa fa-trash" aria-hidden="true" style="color:red;font-size:24px"></i></a>
                </td>
                </form>
            </tr>
            @endforeach
        </table>
        <div>
            <a href="{{route('checkout.index')}}"><button>ĐẶT HÀNG</button></a>
        </div>
        @else
            <h3 style="text-align: center">GIỎ HÀNG RỖNG!</h3>
        @endif
    </div>
</div>
@endsection