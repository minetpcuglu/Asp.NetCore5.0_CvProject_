using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_CvProject_.ViewComponents.About
{
    public class AboutImage:ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new EfAboutRepository());

        public IViewComponentResult Invoke()
        {
            var Value = aboutManager.GetList();
            return View(Value);
        }
    }
}
