using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_CvProject_.Controllers
{
    [AllowAnonymous]
    public class MyHobbyController : Controller
    {
        MyHobbyManager myHobbyManager = new MyHobbyManager(new EfMyHobbyRepository());
        public IActionResult Index()
        {
            var value = myHobbyManager.GetList();
            return View(value);
        }
    }
}
