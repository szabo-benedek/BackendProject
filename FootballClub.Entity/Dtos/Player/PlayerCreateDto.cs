using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClub.Entity.Dtos.Player
{
    public class PlayerCreateDto
    {
        public required string ClubId { get; set; }

        public required string Name { get; set; }
        [Range(10,50)]
        public required int Age { get; set; }
        [MaxLength(50)]
        public required string Nationality { get; set; }

        public required string Position { get; set; }
        [Range(0, 1500)]
        public required int Appearances { get; set; }
        [Range(0, 5000)]
        public required int Goals { get; set; }
        [Range(0, 5000)]
        public required int Assists { get; set; }
        [Range(0, 500)]
        public required int YellowCards { get; set; }
        [Range(0, 500)]
        public required int RedCards { get; set; }


    }
}
