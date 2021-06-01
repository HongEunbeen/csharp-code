using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetNote.DataContext;
using AspNetNote.Models;
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
