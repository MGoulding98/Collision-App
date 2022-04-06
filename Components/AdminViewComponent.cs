using ProjectDriveSafe.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectDriveSafe.Components
{
    public class AdminViewComponent : ViewComponent
    {
        private ICollisionRepository repo { get; set; }

        public AdminViewComponent(ICollisionRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedTeam = RouteData?.Values["county"];

            var Counties = repo.Crashes
                .Select(x => x.COUNTY_NAME)
                .Distinct()
                .OrderBy(x => x);

            return View(Counties);
        }
    }
}

