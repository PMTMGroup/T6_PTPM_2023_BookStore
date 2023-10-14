<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Nhà Sách 711</title>
    <link href='https://fonts.googleapis.com/css?family=Roboto' rel='stylesheet'>
    <style>
        body{
            font-family: "Roboto";
            display: flex;
            justify-content: center;
            align-items: center;
            background-color: rgb(237, 237, 237);
            color: #212f3f;
        }
        .body-layout{
            margin-top: 50px;
            width: 700px;
            height: 500px;
            border-radius: 15px;
            background-color: #fff;
            box-shadow: 0 0 10px 1px rgb(216, 216, 216);
            overflow: hidden;
            display: flex;
            flex-direction: column;
            justify-content: space-between;
        }
        .body-layout .header{
            width: 100%; 
            height: 20%;
            display: flex; justify-content: center; align-items: center;
            background-color: #000;
        }
        .body-layout .footer{
            width: 100%; 
            height: 15%;
            display: flex; justify-content: center; align-items: center;
            background-color: #000; gap: 50px; color: #FFC100;
        }
        span{ font-weight: 600}
    </style>
</head>
<body>
    <div class="body-layout">
        <div class="header">
            <img src="{{asset('images/system/logo.png')}}" style="width:189px; height: 55px;">
        </div>
        <div class="main" style="padding:20px;">
            <center style="font-weight:800; font-size:22px;margin-bottom:15px; color: #212f3f;">THÔNG BÁO TRẠNG THÁI ĐƠN HÀNG</center>
            <p style="color: #212f3f">Xin chào! <span style="color: black;">{{$data['hoTen']}}</span></p>
            <P style="color: #212f3f">Đơn hàng <span style="color: black;">#{{$data['soHD']}}</span> của quý khách đã ở trạng thái <span style="color: black;">{{$data['trangThai']}}</span>
                 
                 . Để tìm hiểu thêm thông tin chi tiết về đơn hàng hoặc cần giải đáp thắc mắc liên hệ ngay hotline <span style="color: black;">19006035</span>.</P>
            <p  style="color: #212f3f">Phục vụ cho quý khách là niềm vinh hạnh của chúng tôi.</p>
            <p  style="color: #212f3f" style="font-weight:600">Trân Trọng</p>
            <p  style="color: #212f3f">Nhà Sách 711</p>
        </div>
        <div class="footer" >
            <p style="color: #FFC100">Trang Chủ</p>
            <p style="color: #FFC100">Tin Tức</p>
            <p style="color: #FFC100">Về Chúng Tôi</p>
            <p style="color: #FFC100">Liên Hệ</p>
        </div>
    </div>
</body>
</html>