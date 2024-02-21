using System;
namespace LocationAPI.Models
{
    public class Location
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public TimeSpan AvailabilityStart { get; set; }
        public TimeSpan AvailabilityEnd { get; set; }
    }
}
