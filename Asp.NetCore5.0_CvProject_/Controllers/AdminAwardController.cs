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
    public class AdminAwardController : Controller
    {
        AwardManager awardManager = new AwardManager(new EfAwardRepository());
        AdminAwardValidator validationRules = new AdminAwardValidator();
        public IActionResult Index()
        {
            var value = awardManager.GetList();
            return View(value);
        }

        [HttpGet]
        public IActionResult AwardUpdate(int id)
        {
            var value = awardManager.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult AwardUpdate(Award award)
        {
            awardManager.Update(award);
            return RedirectToAction("Index", "Award");
        }

        [HttpGet]
        public IActionResult AddAward()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddAward(Award award)
        {
            ValidationResult result = validationRules.Validate(award);
            if (result.IsValid)
            {
                awardManager.Add(award);
                return RedirectToAction("Index", "Award");
            }
            else
            {
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
            }
            return View();
           
        }
    }
}
