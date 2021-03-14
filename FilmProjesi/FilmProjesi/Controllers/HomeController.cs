using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmProjesi.Models;

namespace FilmProjesi.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int count = Repository.Counter();
            if(count>0)
            {
                var liste = Repository.Films.Where(i => i.Imdb >= 5);
                return View(liste);
            }
            return View();
            
        }
        public ViewResult List()
        {
            var liste = Repository.Films.Where(i => i.Id >=0);
            return View(liste);
        }

        [HttpGet]
        public ViewResult Add()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Add(Film film)
        {
            if(ModelState.IsValid)
            {
                Repository.AddFilm(film);
                var liste = Repository.Films.Where(i => i.Imdb >= 5);
                return View("Index",liste);
            }
            //ekleme işlemini yapıyoruz
            return View();
        }
    }
}
