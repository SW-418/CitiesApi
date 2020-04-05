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
                    Description = "Bit pointy tower, a bit cold",
                    PointsOfInterest = new List<PointOfInterestDto>
                    {
                        new PointOfInterestDto
                        {
                            Id = 12,
                            Name = "CN Tower",
                            Description = "Viewing tower"
                        },
                        new PointOfInterestDto
                        {
                            Id = 13,
                            Name = "Rogers Stadium",
                            Description = "Baseball"
                        }
                    }
                },
                new CityDto
                {
                    Id = 2,
                    Name = "London",
                    Description = "A conservative majority 😫",
                    PointsOfInterest = new List<PointOfInterestDto>
                    {
                        new PointOfInterestDto
                        {
                            Id = 14,
                            Name = "🅱️ig 🅱️en",
                            Description = "Just a clock"
                        },
                        new PointOfInterestDto
                        {
                            Id = 15,
                            Name = "Ronnie Scotts",
                            Description = "Jazzy"
                        }
                    }
                },
                new CityDto
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "How about that wine",
                          PointsOfInterest = new List<PointOfInterestDto>
                    {
                        new PointOfInterestDto
                        {
                            Id = 16,
                            Name = "Eifel Tower",
                            Description = "Viewing tower"
                        }
                    }
                }
            };
        }
    }
}
