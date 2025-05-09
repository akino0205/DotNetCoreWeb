using DotNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DotNetCoreMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        // 사용자 등록 페이지 반환
        public IActionResult Register()
        {
            return View();
        }

        // 사용자 등록 처리
        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                // 사용자 등록 로직은 여기에 구현
                // 데이터베이스 저장 등의 작업

                return RedirectToAction("Login");
            }
            return View(user);
        }

        // 로그인 페이지 반환
        public IActionResult Login()
        {
            return View();
        }

        // 로그인 처리
        [HttpPost]
        public IActionResult Login(User user)
        {
            // 로그인 로직은 여기에 구현
            // 인증 처리 등의 작업

            return RedirectToAction("Dashboard");
        }

        // 사용자 대시보드
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}