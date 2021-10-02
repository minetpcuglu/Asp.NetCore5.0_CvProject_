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
    public class AdminMyHobbyController : Controller
    {
        MyHobbyManager myHobbyManager = new MyHobbyManager(new EfMyHobbyRepository());
        public IActionResult Index()
        {
            var value = myHobbyManager.GetList();
            return View(value);
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
            myHobbyManager.Add(myHobby);
            return RedirectToAction("Index", "MyHobby");
        }
    }
}
