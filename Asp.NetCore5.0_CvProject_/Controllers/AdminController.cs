using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
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
        public async Task<IActionResult> AboutUpdate(About about , IFormFile file)
        {
            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName); //uzantiya ulasmak //.jpg .png
                var randomFileName = string.Format($"{Guid.NewGuid()}{extension}");  //random bir sayı ile resim dosyaları birbirine çakışmaması
                var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot\\img",randomFileName);
                about.ImagePath = randomFileName;

                using (var stream = new FileStream(path,FileMode.Create) )  //using içinde olması isimiz bittiginde otamatşk silinecek olması.
                {
                  await file.CopyToAsync(stream);
                }
            }
          
                aboutManager.Update(about);
                return RedirectToAction("Index", "About");
           
        }

    }
}
