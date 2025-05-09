// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// 사이트 기본 JavaScript 파일
$(document).ready(function () {
    // 네비게이션 활성화
    const currentUrl = window.location.pathname;

    $('.navbar-nav .nav-link').each(function () {
        const href = $(this).attr('href');
        if (currentUrl.indexOf(href) !== -1) {
            $(this).addClass('active');
        }
    });

    // 폼 유효성 검사
    $('form').on('submit', function () {
        // 필요한 유효성 검사 로직 추가
        console.log('폼 제출됨');
    });
});