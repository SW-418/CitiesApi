using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Controllers
{
    [ApiController]
    [Route("api/cities/{cityId}/pointsofinterest")]
    public class PointsOfInterestController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPointsOfInterest(int cityId)
        {
            var city = CitiesDataStore
                .Current
                .Cities
                .FirstOrDefault(c => c.Id == cityId);

            if(city == null)
            {
                return NotFound();
            }
            return Ok(city.PointsOfInterest);
        }

        [HttpGet]
        [Route("{pointofinterestid}")]
        public IActionResult GetPointsOfInterest(int cityId, int pointofinterestid)
        {
            var city = CitiesDataStore
                .Current
                .Cities
                .FirstOrDefault(c => c.Id == cityId);

            if (city == null)
            {
                return NotFound();
            }

            var pointOfInterest = city
                .PointsOfInterest
                .FirstOrDefault(p => p.Id == pointofinterestid);

            if(pointOfInterest == null)
            {
                return NotFound();
            }

            return Ok(pointOfInterest);
        }
    }
}
