using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_CvProject_.Controllers
{
    public class LoginController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutRepository());
        Context c = new Context();
        public IActionResult Index(About about)
        {
            var value = c.Abouts.FirstOrDefault(x => x.Mail == about.Mail && x.Password == about.Password);
            return View();
        }

      
    }
}
