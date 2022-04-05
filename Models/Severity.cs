using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDriveSafe.Models
{
    public class Severity
    {
        [Key]
        [Required]
        public int CRASH_SEVERITY_ID { get; set; }
        public string CRASH_SEVERITY_DESCRIPTION { get; set; }
    }
}
