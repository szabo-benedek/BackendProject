using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClub.Entity.Dtos.Club
{
    public class ClubCreateUpdateDto
    {
        public required string ClubName { get; set; } = "";
        public required int YearFounded { get; set; }
        public required string StadiumName { get; set; } = "";
        public required int StadiumCapacity { get; set; }
        public required int Trophies { get; set; }
        public required string Country { get; set; } = "";
    }
}
