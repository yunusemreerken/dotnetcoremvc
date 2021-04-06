using Library.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Data.Models;
namespace Library.Controllers
{
    public class MemberController : Controller
    {
        MemberRepository memberRepository = new MemberRepository();
        public IActionResult Index()
        {
            var memberlist = memberRepository.Tlist();
            return View(memberlist);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Member p)
        {
            p.Image = "https://cdn1.iconfinder.com/data/icons/ui-5/502/user-512.png";
            memberRepository.TAdd(p);
            
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var member = memberRepository.TGet(id);
            return View(member);
        }
        [HttpPost]
        public IActionResult Update(Member p)
        {
            var x = memberRepository.TGet(p.Member_Id);
            x.Member_Name = p.Member_Name;
            x.IdentityNumber = p.IdentityNumber;
            x.Email = p.Email;
            x.Image = p.Image;
            x.Telephone = p.Telephone;
            memberRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var x = memberRepository.TGet(id);
            memberRepository.TRemove(x);
            return RedirectToAction("Index");

        }
        public IActionResult Details(int id)
        {
            var member = memberRepository.TGet(id);
            var members = memberRepository.List(x => x.Member_Id == id);
            return View(members);
        }
    }
}
