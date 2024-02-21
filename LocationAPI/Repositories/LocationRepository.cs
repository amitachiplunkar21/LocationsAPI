using System;
using System.Collections.Generic;
using System.Linq;
using LocationAPI.Models;

namespace LocationAPI.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private List<Location> locations = new List<Location>
        {
            new Location { Name = "Pharmacy", Type = "Medical", AvailabilityStart = TimeSpan.FromHours(8), AvailabilityEnd = TimeSpan.FromHours(18) },
            new Location { Name = "Bakery", Type = "Food", AvailabilityStart = TimeSpan.FromHours(7), AvailabilityEnd = TimeSpan.FromHours(15) },
            new Location { Name = "Barber Shop", Type = "Service", AvailabilityStart = TimeSpan.FromHours(10), AvailabilityEnd = TimeSpan.FromHours(20) },
            new Location { Name = "Supermarket", Type = "Retail", AvailabilityStart = TimeSpan.FromHours(9), AvailabilityEnd = TimeSpan.FromHours(22) },
            new Location { Name = "Candy Store", Type = "Food", AvailabilityStart = TimeSpan.FromHours(11), AvailabilityEnd = TimeSpan.FromHours(18) },
            new Location { Name = "Cinema Complex", Type = "Entertainment", AvailabilityStart = TimeSpan.FromHours(12), AvailabilityEnd = TimeSpan.FromHours(24) },
            new Location { Name = "Gym", Type = "Fitness", AvailabilityStart = TimeSpan.FromHours(6), AvailabilityEnd = TimeSpan.FromHours(22) },
            new Location { Name = "Library", Type = "Education", AvailabilityStart = TimeSpan.FromHours(9), AvailabilityEnd = TimeSpan.FromHours(20) },
            new Location { Name = "Park", Type = "Outdoor", AvailabilityStart = TimeSpan.FromHours(6), AvailabilityEnd = TimeSpan.FromHours(21) },
            new Location { Name = "Restaurant", Type = "Food", AvailabilityStart = TimeSpan.FromHours(11), AvailabilityEnd = TimeSpan.FromHours(23) }
        };

        public IEnumerable<Location> GetLocationsWithAvailability(TimeSpan start, TimeSpan end)
        {
            TimeSpan startTime = TimeSpan.FromHours(10);
            TimeSpan endTime = TimeSpan.FromHours(13); // 1 PM


            return locations
        .Where(l => l.AvailabilityStart <= start && l.AvailabilityEnd >= end)
        .ToList();
        }
    }
}
