using CoreDepartman.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreDepartman.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        
        [HttpGet]
        public IActionResult Signin()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Signin(Admin p)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.User == p.User && x.Password == p.Password);
            if(bilgiler !=null)
            {
                var claims = new List<Claim> { 
                    new Claim(ClaimTypes.Name,p.User)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","Personel");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Signin","Login");
        }
    }
}
