using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetCity(int id)
        {
            var cityToReturn = CitiesDataStore
                .Current
                .Cities
                .FirstOrDefault(c => c.Id == id);

            if (cityToReturn == null)
            {
                return NotFound();
            }

            return Ok(cityToReturn);
        }

        [HttpGet]
        [Route("{id}/name")]
        public IActionResult GetCityName(int id)
        {
            return new JsonResult(CitiesDataStore
                .Current
                .Cities
                .FirstOrDefault(c => c.Id == id)?.Name);
        }
    }
}
