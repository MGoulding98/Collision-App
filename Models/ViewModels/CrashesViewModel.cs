using ProjectDriveSafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDriveSafe.Models.ViewModels
{
    public class CrashesViewModel
    {
        public IQueryable<Crash> Crashes { get; set; }
        //public IQueryable<Severity> Severities { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
