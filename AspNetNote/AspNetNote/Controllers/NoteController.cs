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
    public class NoteController : Controller
    {
        /// <summary>
        /// 게시판 리스트
        /// </summary>
        /// <returns></returns>
        // GET: /<controller>/
        public IActionResult Index()
        {
            using(var db = new AspNetNoteDbContext())
            {
                var list = db.Notes.ToList();
                return View(list);
            }
        }

        /// <summary>
        /// 게시물 추가
        /// </summary>
        /// <returns></returns>
        public IActionResult Add()
        {
            return View();
        }

        /// <summary>
        /// 게시물 수정
        /// </summary>
        /// <returns></returns>
        public IActionResult Edit()
        {
            return View();
        }

        /// <summary>
        /// 게시물 삭제
        /// </summary>
        /// <returns></returns>
        public IActionResult Delet()
        {
            return View();
        }
    }
}
