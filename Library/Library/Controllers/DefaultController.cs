using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Repositories;
using Library.Data.Models;
namespace Library.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            BookRepository bookRepository = new BookRepository();
            var list = bookRepository.Tlist();
            return View(list);
        }
        public IActionResult Detail(int id)//kitap detay
        {
            BookRepository bookRepository = new BookRepository();
            var list = bookRepository.TGet(id);
            return View(list);
        }
        [HttpGet]
        public IActionResult Book(int id)//categorinin kitaplarını getiriyor
        {
            BookRepository bookRepository = new BookRepository();
            var booklist = bookRepository.List(x=>x.CategoryId == id);
            
            return View(booklist);
        }
        public IActionResult ContactMe()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MessageSubmit(Message p)
        {
            MessageRepository messageRepository = new MessageRepository();
            p.Status = false;//message ın default değeri false
            messageRepository.TAdd(p);
            return RedirectToAction("Index");

        }
        public IActionResult Search(string p)
        {
            BookRepository bookRepository = new BookRepository();
            if (!string.IsNullOrEmpty(p))
            {
                return View(bookRepository.List(x => x.BookName.Contains(p)));
            }
            return View(bookRepository.Tlist());
        }
       
    }
}
