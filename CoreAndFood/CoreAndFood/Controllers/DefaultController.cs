using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAndFood.Data.Models;
using CoreAndFood.Repositories;
using X.PagedList;


namespace CoreAndFood.Controllers
{
    public class DefaultController : Controller
    {
        CategoryRepository categoryRepository = new CategoryRepository();
        FoodRepository foodRepository = new FoodRepository();
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult CategoryDetails(int id)
        {
            var categoryId = categoryRepository.TGet(id).CategoryId;
            var foodlist = foodRepository.TList().Where(x => x.CategoryId == categoryId).ToList();                 
            return View(foodlist);
        }
    }
}
