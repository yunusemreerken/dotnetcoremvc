using Library.Data.Models;
using Library.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Data;
using Library;
using Microsoft.EntityFrameworkCore;

namespace Library.Controllers
{
    public class MemberBookController : Controller
    {
        MemberBookRepository memberBookRepository = new MemberBookRepository();
        Context c = new Context();
        public IActionResult Index(int id)
        {
            var books = memberBookRepository.List(x => x.Member.Member_Id == id);

            return View(books);
        }
        
        [HttpGet]
        public IActionResult Add()
        {
            List<SelectListItem> values = (from x in c.Members.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Member_Name,
                                               Value = x.Member_Id.ToString()
                                           }).ToList();

            ViewBag.v1 = values;
            List<SelectListItem> values2 = (from x in c.Books.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.BookName,
                                               Value = x.BookId.ToString()
                                           }).ToList();
            ViewBag.v2 = values2;
            return View();
        }
        [HttpPost]
        public IActionResult Add(MemberBook p)
        {

            
            memberBookRepository.TAdd(p);
            return RedirectToAction("Index");
        }
    }
}
