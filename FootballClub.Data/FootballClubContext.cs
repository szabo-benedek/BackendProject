using FootballClub.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClub.Data
{
    public class FootballClubContext : DbContext
    {

        public DbSet<Club> Clubs { get; set; }

        public DbSet<Player> Players { get; set; }


       
        public FootballClubContext(DbContextOptions<FootballClubContext> ctx)
            : base(ctx)
        {
            Database.EnsureCreated();

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Club>()
                .HasMany(c => c.Players)
                .WithOne(p => p.Club)
                .HasForeignKey(p => p.ClubId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
            
        }

    }
}
