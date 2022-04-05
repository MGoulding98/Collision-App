using System;
using System.Linq;
using ProjectDriveSafe.Models;

namespace ProjectDriveSafe.Models
{
    public class EFCollisionRepository : ICollisionRepository
    {
        private RDSContext context { get; set; }

        public EFCollisionRepository (RDSContext temp)
        {
            context = temp;
        }

        public IQueryable<Crash> Crashes => context.Crashes;
        public IQueryable<Severity> Severities => context.Severities;

        public Crash GetCrash(int crashid)
        {
            var crash = context.Crashes.Single(x => x.CRASH_ID == crashid);
            return crash;
        }

        public void SaveCollision(Crash c)
        {
            context.SaveChanges();
        }

        public void CreateCollision(Crash c)
        {
            context.Add(c);
            context.SaveChanges();
        }

        public void DeleteCollision(Crash c)
        {
            context.Remove(c);
            context.SaveChanges();
        }
    }
}
