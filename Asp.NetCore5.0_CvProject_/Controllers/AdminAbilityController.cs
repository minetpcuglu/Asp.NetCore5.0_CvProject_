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
    public class AdminAbilityController : Controller
    {
        AbilityManager abilityManager = new AbilityManager(new EfAbilityRepository());
        AdminAbilityValidator validationRules = new AdminAbilityValidator();
        public IActionResult Index()
        {
            var value = abilityManager.GetList();
            return View(value);
        }
        [HttpGet]
        public IActionResult AbilityUpdate(int id)
        {
            var value = abilityManager.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult AbilityUpdate(Ability ability)
        {
            abilityManager.Update(ability);
            return RedirectToAction("Index", "Ability");
        }

        [HttpGet]
        public IActionResult AddAbility()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddAbility(Ability ability)
        {
            ValidationResult result = validationRules.Validate(ability);
            if (result.IsValid)
            {
                abilityManager.Add(ability);
                return RedirectToAction("Index", "Ability");
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
