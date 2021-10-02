using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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
    }
}
