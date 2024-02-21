using System;
using System.Collections.Generic;
using LocationAPI.Models;

namespace LocationAPI.Repositories
{
    public interface ILocationRepository
    {
        IEnumerable<Location> GetLocationsWithAvailability(TimeSpan start, TimeSpan end);
    }
}
