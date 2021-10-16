using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_CvProject_.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutRepository());
        Context c = new Context();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(About about)
        {
            var value = c.Abouts.FirstOrDefault(x => x.Password == about.Password && x.Mail == about.Mail);
            if (value!=null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,about.Mail)
                };
                var userIdentity = new ClaimsIdentity(claims, "a"); //a herhangi bir değer why?
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);
                return RedirectToAction("AboutIndex", "Admin");

            }
            else
            {
                ModelState.AddModelError("", "Hatalı Kullanıcı Adı/Şifre");
                return View();
            }

        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }


    }
}
