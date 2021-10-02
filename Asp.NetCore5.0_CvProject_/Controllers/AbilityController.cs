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
    public class AbilityController : Controller
    {

        AbilityManager abilityManager = new AbilityManager(new EfAbilityRepository());
        public IActionResult Index()
        {
            var value = abilityManager.GetList();
            return View(value);
        }

       

    }
}
