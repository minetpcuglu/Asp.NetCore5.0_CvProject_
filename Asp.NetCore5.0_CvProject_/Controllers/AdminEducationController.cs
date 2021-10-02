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
    public class AdminEducationController : Controller
    {
        EducationLifeManager educationManager = new EducationLifeManager(new EfEducationLifeRepository());
        public IActionResult Index()
        {
            var value = educationManager.GetList();
            return View(value);
        }

        [HttpGet]
        public IActionResult EducationUpdate(int id)
        {
            var value = educationManager.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EducationUpdate(EducationLife educationLife)
        {
            educationManager.Update(educationLife);
            return RedirectToAction("Index", "Education");
        }

        [HttpGet]
        public IActionResult AddEducation()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddEducation(EducationLife educationLife)
        {
            educationManager.Add(educationLife);
            return RedirectToAction("Index", "Education");
        }
    }
}
