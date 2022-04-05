using System;
using System.Linq;
using ProjectDriveSafe.Models;

namespace ProjectDriveSafe.Models
{
    public class ICollisionRepository
    {
        IQueryable<Crash> Crashes { get; }

        public void SaveCollision(Crash c);
        public void CreateCollision(Crash c);
        public void DeleteCollision(Crash c);
    }
}
