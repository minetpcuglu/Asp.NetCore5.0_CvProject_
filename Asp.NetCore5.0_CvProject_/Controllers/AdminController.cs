using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Asp.NetCore5._0_CvProject_.Controllers
{
    
    public class AdminController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutRepository());
        AdminAboutValidator validationRules = new AdminAboutValidator();

        
        public IActionResult AboutIndex(int page =1)
        {
            var deger = aboutManager.GetList();
            return View(deger.ToPagedList(page,5));
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
