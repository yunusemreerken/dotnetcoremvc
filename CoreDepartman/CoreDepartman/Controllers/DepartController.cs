using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDepartman.Models;
using Microsoft.AspNetCore.Authorization;

namespace CoreDepartman.Controllers
{
    public class DepartController : Controller
    {
        Context c = new Context();
        [Authorize]

        public IActionResult Index()
        {
            var degerler = c.Departmans.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult NewDepartman()
        {
            return View();
        }
        [HttpPost]
        public  IActionResult NewDepartman(Departman d)
        {
            c.Departmans.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {
            var dep = c.Departmans.Find(id);
            c.Departmans.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateDepartman(int id)
        {
            var dep = c.Departmans.Find(id);
            return View(dep);
        }
        [HttpPost]
        public IActionResult UpdateDepartman(Departman d)
        {
            var dep = c.Departmans.Find(d.Id);
            dep.DepartmanName = d.DepartmanName;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult DepartmanDetay(int id)
        {
            var degerler = c.Personels.Where(x => x.Departman.Id == id).ToList();
            var departName = c.Departmans.Where(x => x.Id == id).Select(y => y.DepartmanName).FirstOrDefault();
            ViewBag.name = departName;
            return View(degerler);
        }
    }
}
