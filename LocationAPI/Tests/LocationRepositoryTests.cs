using Xunit;
using LocationAPI.Repositories;
using System;
using System.Linq;
using LocationAPI.Models;

namespace LocationAPI.Tests
{
    public class LocationRepositoryTests
    {
        
        [Fact]
        public void GetLocationsWithAvailability_ShouldReturnCorrectLocations()
        {
            // Arrange
            var repository = new LocationRepository();
            var expectedLocations = new[]
            {
                new Location { Name = "Pharmacy", Type = "Medical", AvailabilityStart = TimeSpan.FromHours(8), AvailabilityEnd = TimeSpan.FromHours(18) },
                new Location { Name = "Bakery", Type = "Food", AvailabilityStart = TimeSpan.FromHours(7), AvailabilityEnd = TimeSpan.FromHours(15) },
                new Location { Name = "Barber Shop", Type = "Service", AvailabilityStart = TimeSpan.FromHours(10), AvailabilityEnd = TimeSpan.FromHours(20) },
                new Location { Name = "Supermarket", Type = "Retail", AvailabilityStart = TimeSpan.FromHours(9), AvailabilityEnd = TimeSpan.FromHours(22) },
                new Location { Name = "Candy Store", Type = "Food", AvailabilityStart = TimeSpan.FromHours(4), AvailabilityEnd = TimeSpan.FromHours(18) },
                new Location { Name = "Cinema Complex", Type = "Entertainment", AvailabilityStart = TimeSpan.FromHours(5), AvailabilityEnd = TimeSpan.FromHours(24) },
                new Location { Name = "Library", Type = "Education", AvailabilityStart = TimeSpan.FromHours(9), AvailabilityEnd = TimeSpan.FromHours(20) },
                 };

            // Act
            var actualLocations = repository.GetLocationsWithAvailability(TimeSpan.FromHours(10), TimeSpan.FromHours(13)).ToArray();

            // Assert
            Assert.Equal(expectedLocations.Length, actualLocations.Length);

        }
    }
}
