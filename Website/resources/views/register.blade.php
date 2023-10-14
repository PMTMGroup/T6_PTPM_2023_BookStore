<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link href='https://fonts.googleapis.com/css?family=Roboto' rel='stylesheet'>
    <title>ĐĂNG KÍ</title>
    <style>
        body{
            margin: 0;
            background-image: url(https://icma.sunshine.software/images/system/bg_business.png);
            background-repeat: no-repeat;
            background-position: center;
            background-size: cover;
            box-shadow: inset 0 0 0 1000px #14298580;
            width: 100%;
            height: 100vh;
            overflow: hidden;
            font-family: 'Roboto';
        }
        .header{
            width: 100%;
            padding: 20px;
            display: flex;
            justify-content: center;
            align-items: center;
        }
        .header .box{
            width: 1140px;
            display: flex;
            justify-content: flex-start;
            align-items: center;
        }
        .header .main{
            width: 1140px;
            display: flex;
            justify-content: flex-end;
        }

        .header .main .modal-form{
            width: 350px;
            padding: 20px;
            background-color: #ffffff;
            border-radius: 5px;
            display: flex;
            flex-direction: column;
            gap: 10px
        }
        h3{margin: 0}
        .header .main .modal-form h3{
            text-align: center;
            color: #0E1D5E;
            font-weight: 600;
        }
        .header .main .modal-form label{
            color: #0E1D5E;
        }
        .header .main .modal-form input{
            border:2px solid #0E1D5E;
            border-radius: 4px;
            padding: 10px;
            margin-bottom: 5px;
        }

        .header .main .modal-form .btn-order{
            color: #0E1D5E;
            padding: 15px;
            border-radius: 4px;
            background-color: #FFC100;
            font-size: 15px;
            font-weight: 600;
            margin-top: 5px;
            outline: none;
            border: 0px;
            
        }
        .header .main .modal-form .btn-order:hover{
            color: #ffffff;
            cursor: pointer;
        }
    </style>
</head>
<body>
    <div class="header">
        <div class="box">
            <a href="{{route('home.index')}}"><img src="{{asset('images/system/logo.png')}}" style="width:89px; height: 55px;"></a>
        </div>
    </div>
    <div class="header">
        <form action="{{route('register.post.index')}}" method="post">
            @csrf
        <div class="main">
            <div class="modal-form">
                <h3>ĐĂNG KÍ THÀNH VIÊN</h3>
                @if(isset($message))
                    <div style="background-color: rgb(252, 224, 224);padding: 15px 10px; border-radius:5px;">
                        <p style="color:red; font-size:15px; margin:0; text-align: center">{{$message}}</p>
                    </div>
                @endif
                <label for="">Họ tên <span style="color:red">*</span></label>
                <input type="text" name="fullname" id="" required placeholder="Họ và tên thành viên...">
                <label for="">Số điện thoại <span style="color:red">*</span></label>
                <input type="number" name="phone" id="" required placeholder="Số điện thoại..." maxlength="12">
                <label for="">Mật khẩu <span style="color:red">*</span></label>
                <input type="password" name="password" id="" required placeholder="Mật khẩu..." maxlength="50" minlength="6">
                <label for="">Xác nhận mật khẩu <span style="color:red">*</span></label>
                <input type="password" name="password_confirm" id="" required placeholder="Xác nhận mật khẩu..." maxlength="50" minlength="6">
                <button class="btn-order">Tạo Thành Viên</button>                
            </div>
        </div>
    </form>
    </div>
</body>
</html>
