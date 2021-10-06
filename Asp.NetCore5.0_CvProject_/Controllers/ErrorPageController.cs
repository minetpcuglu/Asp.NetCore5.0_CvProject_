using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_CvProject_.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404(int Code)
        {
            return View();
        }
    }
}
