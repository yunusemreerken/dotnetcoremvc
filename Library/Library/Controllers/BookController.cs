using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Repositories;
using Library.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Library.Controllers
{
    public class BookController : Controller
    {
        Context c = new Context();
        BookRepository bookRepository = new BookRepository();
        public IActionResult Index()
        {
            var booklist = bookRepository.Tlist("Category");
            return View(booklist);
        }
        [HttpGet]
        public IActionResult Add()
        {
            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            return View();
        }
        [HttpPost]
        public IActionResult Add(Book p)
        {
            if (!ModelState.IsValid)
            {
                return View("Add");
            }
            bookRepository.TAdd(p);
            return RedirectToAction("Index","Book");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var y = bookRepository.TGet(id);
            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            Book b = new Book()
            {
                BookId = y.BookId,
                BookName = y.BookName,
                Author = y.Author,
                Cilt = y.Cilt,
                CoverImage = y.CoverImage,
                CoverType = y.CoverType,
                Price = y.Price,
                PublisherName = y.PublisherName,
                CategoryId = y.CategoryId


            };
            return View(b);
        }
        [HttpPost]
        public IActionResult Update(Book p)
        {
            var x = bookRepository.TGet(p.BookId);
            x.BookId = p.BookId;
            x.BookName = p.BookName;
            x.Author = p.Author;
            x.Cilt = p.Cilt;
            x.CoverImage = p.CoverImage;
            x.CoverType = p.CoverType;
            x.Price = p.Price;
            x.PublisherName = p.PublisherName;
            x.CategoryId = p.CategoryId;



            bookRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id )
        {
            var x = bookRepository.TGet(id);
            bookRepository.TRemove(x);
            return RedirectToAction("Index");
            
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var y = bookRepository.TGet(id);
            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            Book b = new Book()
            {
                BookId = y.BookId,
                BookName = y.BookName,
                Author = y.Author,
                Cilt = y.Cilt,
                CoverImage = y.CoverImage,
                CoverType = y.CoverType,
                Price = y.Price,
                PublisherName = y.PublisherName,
                CategoryId = y.CategoryId,
                
                


            };
            return View(b);
        }
    }
}
