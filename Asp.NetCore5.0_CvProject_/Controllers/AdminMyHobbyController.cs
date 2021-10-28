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
    public class AdminMyHobbyController : Controller
    {
        MyHobbyManager myHobbyManager = new MyHobbyManager(new EfMyHobbyRepository());
        AdminMyHobbyValidator validationRules = new AdminMyHobbyValidator();
        public IActionResult Index(int page =1)
        {
            var value = myHobbyManager.GetList();
            return View(value.ToPagedList(page,5));
        }

        [HttpGet]
        public IActionResult HobbyUpdate(int id)
        {
            var value = myHobbyManager.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult HobbyUpdate(MyHobby myHobby)
        {
            myHobbyManager.Update(myHobby);
            return RedirectToAction("Index", "MyHobby");
        }

        [HttpGet]
        public IActionResult AddHobby()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddHobby(MyHobby myHobby)
        {
            ValidationResult result = validationRules.Validate(myHobby);
            if (result.IsValid)
            {
                myHobbyManager.Add(myHobby);
                return RedirectToAction("Index", "MyHobby");
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
