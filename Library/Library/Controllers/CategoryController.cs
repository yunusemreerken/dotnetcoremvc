using Library.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Data.Models;
using Library.Data;

namespace Library.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository categoryRepository = new CategoryRepository();


        public IActionResult Index(/*string p*/)
        {
            //if (!string.IsNullOrEmpty(p))
            //{
            //    return View(categoryRepository.List(x => x.CategoryName == p));
            //}
            return View(categoryRepository.Tlist());
        }
        [HttpPost]
        public IActionResult Index2(CategorySearch categorySearch)
        {
            var business = new ProductBusinessLogic();
            var model = business.GetProducts(categorySearch);
            return View("Index",model);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Category p)
        {
            categoryRepository.TAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var x = categoryRepository.TGet(id);
            categoryRepository.TRemove(x);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var x = categoryRepository.TGet(id);
            return View(x);
        }
        [HttpPost]
        public IActionResult Update(Category p)
        {
            var x = categoryRepository.TGet(p.CategoryId);
            x.CategoryName = p.CategoryName;
            x.CategoryDescription = p.CategoryDescription;
            x.Status = p.Status;
            categoryRepository.TUpdate(x);
            return RedirectToAction("Index");
        }

    }
}
