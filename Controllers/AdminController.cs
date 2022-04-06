using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectDriveSafe.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectDriveSafe.Controllers
{
    public class AdminController : Controller
    {
        private ICollisionRepository _repo { get; set; }

        // constructor
        public AdminController(ICollisionRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(string county)
        {
            IQueryable<Crash> blah = _repo.Crashes.Where(x => x.COUNTY_NAME == county || county == null);

            return View(blah);
        }

        [HttpGet]
        public IActionResult CrashForm()
        {
            ViewBag.Crashes = _repo.Crashes.ToList();

            return View(new Crash());
        }

        [HttpPost]
        public IActionResult CrashForm(Crash c)
        {
            if (ModelState.IsValid)
            {
                _repo.CreateCollision(c);

                return RedirectToAction("AdminView");
            }
            else
            {
                ViewBag.Crashes = _repo.Crashes.ToList();
                return View(c);
            }
        }

        // Edit Crash

        [HttpGet]
        public IActionResult EditCrash(int crashid)
        {
            ViewBag.Crashes = _repo.Crashes.ToList();

            Crash c = _repo.GetCrash(crashid);
            return View("CrashForm", c);
        }

        [HttpPost]
        public IActionResult EditCrash(Crash c)
        {
            _repo.EditCollision(c);

            return RedirectToAction("AdminView");
        }


        // Delete Crash
        [HttpGet]
        public IActionResult DeleteCrash(int crashid)
        {
            Crash c = _repo.GetCrash(crashid);
            _repo.DeleteCollision(c);
            return RedirectToAction("AdminView");
        }
    }
}

