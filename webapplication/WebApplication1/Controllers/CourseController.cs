using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{

    //course
    public class CourseController : Controller
    {
        //course/index
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour > 12 ? "Good Afternoon " : "Good morning";
            return View("Myview");
        }
        //course/list
        public ViewResult List()
        {
            var liste = Repository.Students.Where(i => i.WillAttend == true);
            return View(liste);
        }
        [HttpGet]
        public ViewResult Apply()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Apply(Student student)
        {
            if(ModelState.IsValid)
            {
                Repository.AddStudent(student);
                return View("Thanks", student);

            }
            //model binding
            //student bilgisini veritabınna kayıt et.
            //sanal veritabanı oluştur ve kayıt et.
            return View();
        }
        
    }
}
