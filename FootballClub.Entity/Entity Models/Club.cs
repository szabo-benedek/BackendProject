using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using FootballClub.Entity.Helpers;

namespace FootballClub.Entity
{
    public class Club : IIdEntity
    {
        public Club(string clubName, int yearFounded, string stadiumName, int stadiumCapacity, int trophies, string country)
        {
            Id = Guid.NewGuid().ToString();
            ClubName = clubName;
            YearFounded = yearFounded;
            StadiumName = stadiumName;
            StadiumCapacity = stadiumCapacity;
            Trophies = trophies;
            Country = country;
        }

        [StringLength(50)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [StringLength(50)]
        public string ClubName { get; set; }

        public int YearFounded { get; set; }

        [StringLength(50)]
        public string StadiumName { get; set; }

        public int StadiumCapacity { get; set; }

        public int Trophies { get; set; }

        public string Country { get; set; } = "";

        [NotMapped]
        public virtual ICollection<Player>? Players { get; set; }

    }
}
