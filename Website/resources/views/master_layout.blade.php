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
    <meta name="csrf-token" content="{{ csrf_token() }}">
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
        <label for="" style="font-weight: 600; color: #FFC100;">Trợ Lý Ây Ai</label>
        <div class="box-chat">
            <div class="couple-chat" id="content-box">
                <div class="item-ai">
                    <p>Xin chào! Châu đẹp trai nhất thế giới có thể giúp gì cho bạn?</p>
                </div>
            </div>
        </div>
        <div class="question">
            <input type="text" name="" id="content-input" required placeholder="Gửi câu hỏi về sản phẩm...">
            <button id="button-submit"><i class="fa fa-paper-plane" aria-hidden="true" style="color:#ffffff"></i></button>
        </div>
    </div>
    <script src="https://code.jquery.com/jquery-3.7.1.js" integrity="sha256-eKhayi8LEQwp4NKxN+CfCh+3qOVUtJn3QNZ0TciWLP4=" crossorigin="anonymous"></script>
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
    <script>
        const input_submit = document.getElementById('content-input');
        $.ajaxSetup({
            headers: {
                'X-CSRF-TOKEN': $('meta[name="csrf-token"]').attr('content')
            }
        })
        $('#button-submit').on('click', function(){
            $value = $('#content-input').val();
            $('#content-box').append(`<div class="item-owner">
                    <p>`+$value+`</p>
                </div>`);

            input_submit.value = "";
            
            $.ajax({
                type: 'post',
                url: '{{route('sender')}}',
                data: {
                    'input': $value
                },
                success: function(data){
                    $('#content-box').append(`<div class="item-ai">
                        <p>`+data+`</p>
                    </div>`);

                    $value = $('#content-input').val('');
                }
            })
            //alert($value);
        })
    </script>
</body>
</html>