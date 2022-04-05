using ProjectDriveSafe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDriveSafe.Controllers
{
    public class HomeController : Controller
    {
        private RDSContext cContext { get; set; }
        public HomeController(RDSContext x)
        {
            cContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewCrashes(int pageNum = 1)
        {
            int pageSize = 5;

            var blah = cContext.Crashes
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize);
            
            return View(blah);
        }

    }
}
