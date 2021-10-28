using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
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
        AdminExperienceValidator validationRules = new AdminExperienceValidator();
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
            ValidationResult result = validationRules.Validate(experience);
            if (result.IsValid)
            {
               experienceManager.Add(experience);
                return RedirectToAction("Index", "experience");
            }
            else
            {

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
            }
            return View();


           
           
        }
       
    }
}
