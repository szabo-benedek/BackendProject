using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClub.Entity.Dtos.Player
{
    public class PlayerViewDto
    {
        public string Name { get; set; } = "";

        public int Age { get; set; }

        public string Nationality { get; set; } = "";

        public string Position { get; set; } = "";

        public int Appearances { get; set; }

        public int Goals { get; set; }

        public string UserFullName { get; set; } = "";

    }
}
