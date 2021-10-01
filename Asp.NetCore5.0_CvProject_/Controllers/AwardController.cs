using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_CvProject_.Controllers
{
    public class AwardController : Controller
    {
        AwardManager awardManager = new AwardManager(new EfAwardRepository());
        public IActionResult Index()
        {
            var value = awardManager.GetList();
            return View(value);
        }
    }
}
