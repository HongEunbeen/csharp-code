using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetNote.DataContext;
using AspNetNote.Models;
using AspNetNote.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetNote.Controllers
{
    public class AccountController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 회원 가입
        /// </summary>
        /// <returns></returns>
        public IActionResult Register()
        {
            return View();
        }

        /// <summary>
        /// 로그인
        /// </summary>
        /// <returns></returns>
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            //ID, 비밀번호 - 필수
            if (ModelState.IsValid)
            {
                using (var db = new AspNetNoteDbContext())
                {
                    //Linq query - 메서드 체이닝
                    var user = db.Users.FirstOrDefault
                        (u => u.UserId.Equals(model.UserId) && u.UserPassword.Equals(model.UserPassword));

                    if(user != null)
                    {
                        //로그인에 성공했을 때
                        //HttpContext.Session.SetInt32(key, value);
                        HttpContext.Session.SetInt32("USER_LOGIN_KEY", user.UserNo);
                        return RedirectToAction("LoginSuccess", "Home");
                     }
                    //로그인에 실패했을 떄
                    //사용자 ID 자체가 회원가입 X 경/
                    ModelState.AddModelError(string.Empty, "사용자 ID 혹은 비밀번호가올바르지 않습니다.");

                }
            }
            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("USER_LOGIN_KEY");
            //HttpContext.Session.Clear();
            return RedirectToAction("index", "Home");
        }

        [HttpPost]
        public IActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {
                //java try{SqlSession){}catch(){}

                //c#
                using(var db = new AspNetNoteDbContext())
                {
                    db.Users.Add(model);//메모리에 올림
                    db.SaveChanges();//DB에 저장
                }
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
