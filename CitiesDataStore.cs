using System.Collections.Generic;
using CityInfo.Models;

namespace CityInfo
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>
            {
                new CityDto
                {
                    Id = 1,
                    Name = "Toronto",
                    Description = "Bit pointy tower, a bit cold"
                },
                new CityDto
                {
                    Id = 2,
                    Name = "London",
                    Description = "A conservative majority 😫"
                },
                new CityDto
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "How about that wine"
                }
            };
        }
    }
}
