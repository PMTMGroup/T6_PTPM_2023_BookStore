<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Nhà Sách 711</title>
    <link rel="stylesheet" href="{{ asset('assets/css/landing-page.css') }}">
    <link href='https://fonts.googleapis.com/css?family=Roboto' rel='stylesheet'>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link rel="icon" type="image/png" href="{{ asset('images/system/logo.png') }}">
</head>
<body>
    @include('header')
    @yield('content')
    @include('footer')
    <img class="box-chat-icon" id="box-chat-icon" src="{{asset("images/system/box-chat.png")}}" alt="">
    <div class="container-chat" id="container-chat">
        <div class="header-chat">
            <p id="icon-close-chat">X</p>            
        </div>
        <label for="">Trợ lý AI</label>
        <div class="box-chat">
            <div class="couple-chat">
                <div class="item-ai">
                    <p>Chào! Tôi có thể giúp gì?</p>
                </div>
                <div class="item-owner">
                    <p>Sản phẩm nào màu xah và đỏ</p>
                </div>
                <div class="item-ai">
                    <p>Chào! Tôi có thể giúp gì?</p>
                </div>
                <div class="item-owner">
                    <p>Sản phẩm nào màu xah và đỏ</p>
                </div>
                <div class="item-ai">
                    <p>Chào! Tôi có thể giúp gì?</p>
                </div>
                <div class="item-owner">
                    <p>Sản phẩm nào màu xah và đỏ</p>
                </div>
                <div class="item-ai">
                    <p>Chào! Tôi có thể giúp gì?</p>
                </div>
                <div class="item-owner">
                    <p>Sản phẩm nào màu xah và đỏ</p>
                </div>
            </div>
        </div>
        <div class="question">
            <input type="text" name="" id="" required placeholder="Gửi câu hỏi về sản phẩm...">
            <button><i class="fa fa-paper-plane" aria-hidden="true" style="color:#ffffff"></i></button>
        </div>
    </div>
    <script>
        const iconChat = document.getElementById("box-chat-icon");
        const iconClose = document.getElementById("icon-close-chat");
        const boxChat = document.getElementById("container-chat");

        iconChat.addEventListener("click", function(){
            boxChat.style.right = "30px";
            boxChat.style.transition = "ease .3s";
        });

        iconClose.addEventListener("click", function(){
            boxChat.style.right = "-350px";
            boxChat.style.transition = "ease .3s";
        });
    </script>
</body>
</html>