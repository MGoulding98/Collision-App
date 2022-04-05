using System;
using System.Linq;
using ProjectDriveSafe.Models;

namespace Collision_App.Models
{
    public class ICollisionRepository
    {
        IQueryable<Crash> Crashes { get; }
    }
}
