using FootballClub.Entity.Dtos.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FootballClub.Entity.Dtos.Club
{
    public class ClubViewDto
    {
        public string Id { get; set; } = "";
        public string ClubName { get; set; } = "";
        public int YearFounded { get; set; }
        public string StadiumName { get; set; } = "";
        public int StadiumCapacity { get; set; }
        public int Trophies { get; set; }
        public string Country { get; set; } = "";

        public IEnumerable<PlayerViewDto>? Players { get; set; }


        public int PlayerCount => Players?.Count() ?? 0;

        public double AveragePlayerAge => Players?.Average(p => p.Age) ?? 0;
    }
}
