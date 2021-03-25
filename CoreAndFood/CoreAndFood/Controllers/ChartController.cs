using CoreAndFood.Data;
using CoreAndFood.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult VisualizeProductResult()
        {
            return Json(Prolist());
        }
        public List<Class1> Prolist()
        {
            List<Class1> cs = new List<Class1>();
            cs.Add(new Class1()
            {
                ProName = "Computer",
                Stock = 150
            });
            cs.Add(new Class1()
            {
                ProName = "Lcd",
                Stock = 75
            });
            cs.Add(new Class1()
            {
                ProName = "usb-disk",
                Stock = 220
            });
            return cs;
        }
        public IActionResult Index3()
        {
            return View();
        }
        public IActionResult VisualizeProductResult2()
        {
            return Json(FoodList());
        }
        public List<Class2> FoodList()
        {
            List<Class2> cs2 = new List<Class2>();
            using (var c = new Context())
            {
                cs2 = c.Foods.Select(x => new Class2
                {
                    foodname = x.FoodName,
                    stock = x.Stock
                }).ToList();
            }
            return cs2;
        }
        public IActionResult Statistics()
        {
            Context c = new Context();

            //sub query örnekleri
            //return id with subQuery categoryname = fruit
            var foid = c.Categories.Where(x => x.CategoryName == "Fruit").Select(y=>y.CategoryId).FirstOrDefault();

            var deger1 = c.Foods.Count();
            ViewBag.d1 = deger1;

            var deger2 = c.Categories.Count();
            ViewBag.d2 = deger2;

            var deger3 = c.Foods.Where(x => x.Category.CategoryName == "Fruit").Count();
            ViewBag.d3 = deger3;

            var deger4 = c.Foods.Where(x => x.Category.CategoryName == "Vegetables").Count();
            ViewBag.d4 = deger4;

            var deger5 = c.Foods.Sum(x=>x.Stock);
            ViewBag.d5 = deger5;

            var deger6 = c.Foods.Where(x => x.Category.CategoryName == "Legumes").Count();
            ViewBag.d6 = deger6;

            var deger7 = c.Foods.OrderByDescending(x=>x.Stock).Select(y=>y.FoodName).FirstOrDefault();
            ViewBag.d7 = deger7;

            var deger8 = c.Foods.OrderBy(x => x.Stock).Select(y => y.FoodName).FirstOrDefault();
            ViewBag.d8 = deger8;

            var deger9 = c.Foods.Average(x => x.Price).ToString("0.00");
            ViewBag.d9 = deger9;

            var deger10 = c.Categories.Where(x => x.CategoryName == "fruit").Select(y => y.CategoryId).FirstOrDefault();
            deger10 = c.Foods.Where(x => x.CategoryId == deger10).Sum(y => y.Stock);
            ViewBag.d10 = deger10;

            var deger11 = c.Categories.Where(x => x.CategoryName == "Vegetables").Select(y => y.CategoryId).FirstOrDefault();
            deger11 = c.Foods.Where(x => x.CategoryId == deger11).Sum(y => y.Stock);
            ViewBag.d11 = deger11;

            var deger12 = c.Foods.OrderByDescending(x => x.Price).Select(y => y.FoodName).FirstOrDefault();
            ViewBag.d12 = deger12;
            return View();
        }

    } 
}
