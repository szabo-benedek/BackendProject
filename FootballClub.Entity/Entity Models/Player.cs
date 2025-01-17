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
    public class Player : IIdEntity
    {
        public Player(string clubId, string name, int age, string nationality, string position, int appearances, int goals, int assists, int yellowCards, int redCards)
        {
            Id = Guid.NewGuid().ToString();
            ClubId = clubId;
            Name = name;
            Age = age;
            Nationality = nationality;
            Position = position;
            Appearances = appearances;
            Goals = goals;
            Assists = assists;
            YellowCards = yellowCards;
            RedCards = redCards;

        }

        [StringLength(50)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [StringLength(50)]
        public string ClubId { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Nationality { get; set; }

        public string Position { get; set; }

        public int Appearances { get; set; }

        public int Goals { get; set; }

        public int Assists { get; set; }

        public int YellowCards { get; set; }

        public int RedCards { get; set; }

        [NotMapped]
        public virtual Club? Club { get; set; }

        [StringLength(50)]
        public string UserId { get; set; }
    }

}
