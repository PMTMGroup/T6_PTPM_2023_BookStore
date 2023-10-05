<div class="container-default" style="background: linear-gradient(270deg, #000 0%, rgba(0, 0, 0, 0.00) 100%, #000 100%),url({{asset('images/system/background-index.svg')}}); background-size: cover;">
    <div class="header">
        <a href="{{route('home.index')}}"><img src="{{asset('images/system/logo.png')}}" style="width:89px; height: 55px;"></a>
        <div class="menu-bar">
            <a href="{{route('home.index')}}"><p class="title-home">TRANG CHỦ</p></a>
            <a href="#"><p>TÍNH NĂNG</p></a>
            <a href="#"><p>VỀ CHÚNG TÔI</p></a>            
            <a href="{{route('cart.index')}}"><p>GIỎ HÀNG @yield('quantity_cart')</p></a>
            <a href="{{route('register.index')}}"><button>ĐĂNG NHẬP</button></a>
        </div>
        <svg class="icon-nav-none" id="icon-nav-none" xmlns="http://www.w3.org/2000/svg" width="18" height="14" viewBox="0 0 18 14" fill="none">
            <path fill-rule="evenodd" clip-rule="evenodd" d="M0.75 13C0.75 12.8011 0.829018 12.6103 0.96967 12.4697C1.11032 12.329 1.30109 12.25 1.5 12.25H16.5C16.6989 12.25 16.8897 12.329 17.0303 12.4697C17.171 12.6103 17.25 12.8011 17.25 13C17.25 13.1989 17.171 13.3897 17.0303 13.5303C16.8897 13.671 16.6989 13.75 16.5 13.75H1.5C1.30109 13.75 1.11032 13.671 0.96967 13.5303C0.829018 13.3897 0.75 13.1989 0.75 13ZM0.75 7C0.75 6.80109 0.829018 6.61032 0.96967 6.46967C1.11032 6.32902 1.30109 6.25 1.5 6.25H16.5C16.6989 6.25 16.8897 6.32902 17.0303 6.46967C17.171 6.61032 17.25 6.80109 17.25 7C17.25 7.19891 17.171 7.38968 17.0303 7.53033C16.8897 7.67098 16.6989 7.75 16.5 7.75H1.5C1.30109 7.75 1.11032 7.67098 0.96967 7.53033C0.829018 7.38968 0.75 7.19891 0.75 7ZM0.75 1C0.75 0.801088 0.829018 0.610322 0.96967 0.46967C1.11032 0.329018 1.30109 0.25 1.5 0.25H16.5C16.6989 0.25 16.8897 0.329018 17.0303 0.46967C17.171 0.610322 17.25 0.801088 17.25 1C17.25 1.19891 17.171 1.38968 17.0303 1.53033C16.8897 1.67098 16.6989 1.75 16.5 1.75H1.5C1.30109 1.75 1.11032 1.67098 0.96967 1.53033C0.829018 1.38968 0.75 1.19891 0.75 1Z" fill="#ffffff"/>
        </svg>
        <div class="nav-none" id="nav-none">
            <a href="{{route('home.index')}}"><p class="title-home">TRANG CHỦ</p></a>
            <a href="#"><p>TÍNH NĂNG</p></a>
            <a href="#"><p>VỀ CHÚNG TÔI</p></a>            
            <a href="#"><p>GIỎ HÀNG @yield('quantity_cart')</p></a>
            <a href="{{route('register.index')}}"><button>ĐĂNG NHẬP</button></a>
        </div>
    </div>
    <div class="container-information">
        <div class="content-box">
            <p class="title">HỆ THỐNG NHÀ SÁCH LỚN NHẤT TP.HỒ CHÍ MINH</p>
            <div>
                <p class="content">711 TÂN PHÚ</p>
            </div>
            <p class="description">Với kinh nghiệm và kiến thức sâu rộng chúng tôi tự tin đưa ra bạn mở ra thế giới quan.</p>
            <button>BẮT ĐẦU NGAY</button>
        </div>
    </div>
    <div class="group-item">
        <div class="item item-float">
            <div class="icon">
                <img src="{{asset('images/system/Layer_1.svg')}}" alt="">
            </div>
            <p class="title">Kiến thức chuyên sâu</p>
            <p class="content">Công ty có đội ngũ chuyên gia tài chính giàu kinh nghiệm, có kiến thức sâu về lĩnh vực tài chính doanh nghiệp và các ngành công nghiệp khác nhau.</p>
        </div>
        <div class="item">
            <div class="icon">
                <img src="{{asset('images/system/increase.svg')}}" alt="">
            </div>
            <p class="title">Giải pháp tùy chỉnh</p>
            <p class="content">Cung cấp các giải pháp<br>tùy chỉnh và chiến lược<br>cá nhân hóa dựa trên<br>nhu cầu và mục tiêu cụ thể<br>của từng khách hàng.</p>
        </div>
        <div class="item">
            <div class="icon">
                <img src="{{asset('images/system/hand.svg')}}" alt="">
            </div>
            <p class="title">Trung thực và minh bạch</p>
            <p class="content">Trình bày các thông tin một cách rõ ràng và trung thực, không che giấu rủi ro hay tổn thất tiềm ẩn.</p>
        </div>
        <div class="item item-float">
            <div class="icon">
                <img src="{{asset('images/system/global.svg')}}" alt="">
            </div>
            <p class="title">Cập nhật xu hướng mới</p>
            <p class="content">ICMA luôn cập nhật kiến thức và những xu hướng mới nhất để áp dụng những phương pháp tối ưu nhất và hiệu quả nhất cho khách hàng.</p>
        </div>
    </div>
</div>

