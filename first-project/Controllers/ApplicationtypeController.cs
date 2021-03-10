using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using first_project.Data;
using first_project.Models;

namespace first_project.Controllers
{
    public class ApplicationtypeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ApplicationtypeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Applicationtype> objList = _db.Applicationtype;
            return View(objList);
        }
        //get create
        public IActionResult Create()
        {
            return View();
        }

        //post create
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Applicationtype obj)
        {
            if (ModelState.IsValid)
            {
                _db.Applicationtype.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
