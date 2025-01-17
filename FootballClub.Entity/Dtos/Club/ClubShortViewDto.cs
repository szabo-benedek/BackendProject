using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClub.Entity.Dtos.Club
{
    public class ClubShortViewDto
    {
        public string Id { get; set; } = "";

        public string ClubName { get; set; } = "";

        public int YearFounded { get; set; }

        public string Country { get; set; } = "";


        public double AveragePlayerAge { get; set; } = 0;

    }
}
