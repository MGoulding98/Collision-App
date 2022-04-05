using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDriveSafe.Models
{
    public class AppIdentityRDSContext : IdentityRDSContext<IdentityUser>
    {
        public class AppIdentityRDSContext(RDSContextOptions options) : base(options)
            {}
            
    }
}
