using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_CvProject_.Controllers
{
    public class AdminController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutRepository());
        public IActionResult AboutIndex()
        {
            var deger = aboutManager.GetList();
            return View(deger);
        }

        [HttpGet]
        public IActionResult AboutUpdate(int id)
        {
            var value = aboutManager.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult AboutUpdate(About about)
        {
            aboutManager.Update(about);
            return RedirectToAction("Index", "About");
        }

    }
}
