using CoreDepartman.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDepartman.Controllers
{
    public class PersonelController : Controller
    {
        Context c = new Context();
        [Authorize]

        public IActionResult Index()
        {
            var deger = c.Personels.Include(x=>x.Departman).ToList();

            return View(deger);
        }
        [HttpGet]
        public IActionResult NewPersonel()
        {
            //veri tabanından departmanları id ve isimlerini alıp listeye alma ve viewbag ile veiw a almak.
            List<SelectListItem> degerler = (from x in c.Departmans.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.DepartmanName,
                                                 Value = x.Id.ToString()
                                             }).ToList();
            
            ViewBag.dgr = degerler;
            return View();
        }
        [HttpPost]
        public IActionResult NewPersonel(Personel p)
        {
            var per = c.Departmans.Where(x => x.Id == p.Departman.Id).FirstOrDefault();
            p.Departman = per;

            c.Personels.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var per = c.Personels.Find(id);
            c.Personels.Remove(per);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var per = c.Personels.Find(id);
            
            return View(per);
        }
        [HttpPost]
        public IActionResult Update(Personel p)
        {
            c.Personels.Update(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
       
    }
}
