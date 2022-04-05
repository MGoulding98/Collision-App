using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collision_App.Models
{
    public class RDSContext : DbContext
    {
        public RDSContext(DbContextOptions<RDSContext> options) : base(options)
        {
        }

        public DbSet<Crash> Crashes { get; set; }
        public DbSet<Severity> Severities { get; set; }
    }
}
