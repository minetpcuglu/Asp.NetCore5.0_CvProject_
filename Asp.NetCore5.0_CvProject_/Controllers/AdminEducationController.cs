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

namespace Asp.NetCore5._0_CvProject_.Controllers
{
    public class AdminEducationController : Controller
    {
        EducationLifeManager educationManager = new EducationLifeManager(new EfEducationLifeRepository());
        AdminEducationLifeValidator validationRules = new AdminEducationLifeValidator();
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
            ValidationResult result = validationRules.Validate(educationLife);
            if (result.IsValid)
            {
                educationManager.Add(educationLife);
                return RedirectToAction("Index", "Education");
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
