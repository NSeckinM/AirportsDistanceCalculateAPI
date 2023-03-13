using AirportsDistanceCalculateAPI.Interfaces;
using AirportsDistanceCalculateAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AirportsDistanceCalculateAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportsController : ControllerBase
    {
        private readonly IAirportService _airportService;

        public AirportsController(IAirportService airportService )
        {
            _airportService = airportService;
        }

        [HttpGet("CalculateMiles")]
        public async Task<IActionResult> CalculateMiles(string iata1, string iata2)
        {
            var result = await _airportService.CalculateDistance(iata1, iata2);

            return Ok(result);

        }


    }
}
