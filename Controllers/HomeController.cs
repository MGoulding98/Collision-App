using ProjectDriveSafe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ProjectDriveSafe.Models.ViewModels;

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

            var x = new CrashesViewModel
            {
                Crashes =
                cContext.Crashes
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumCrashes = cContext.Crashes.Count(),
                    CrashesPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };

            return View(x);
        }

    }
}
