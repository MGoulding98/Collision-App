using Collision_App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Collision_App.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewCrashes(int pageNum = 1)
        {
            int pageSize = 5;

            var blah = 
            
            return View();
        }

    }
}
