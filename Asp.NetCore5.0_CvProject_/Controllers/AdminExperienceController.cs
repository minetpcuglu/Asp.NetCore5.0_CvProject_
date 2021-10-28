using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Asp.NetCore5._0_CvProject_.Controllers
{
   
    public class AdminExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceRepository());
        public IActionResult Index(int page =1)
        {
            var value = experienceManager.GetList();
            return View(value.ToPagedList(page,5));
        }

        [HttpGet]
        public IActionResult ExperienceUpdate(int id)
        {
            var value = experienceManager.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult ExperienceUpdate(Experience experience)
        {
            experienceManager.Update(experience);
            return RedirectToAction("Index","Experience");
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            experienceManager.Add(experience);
            return RedirectToAction("Index","Experience");
        }
       
    }
}
