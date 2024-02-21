using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using LocationAPI.Models;
using LocationAPI.Repositories;
namespace LocationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationRepository locationRepository;

        public LocationsController(ILocationRepository repository)
        {
            this.locationRepository = repository;
        }

        [HttpGet]
        public IActionResult GetLocations()
        {
            var availableLocations = locationRepository.GetLocationsWithAvailability(TimeSpan.FromHours(10), TimeSpan.FromHours(13));
            return Ok(availableLocations);
        }
    }
}
