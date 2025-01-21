using AutoMapper;
using FootballClub.Data;
using FootballClub.Entity;
using FootballClub.Entity.Dtos.Club;
using FootballClub.Entity.Dtos.Player;
using FootballClub.Entity.Dtos.User;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClub.Logic.Helpers
{
    public class DtoProvider
    {

        UserManager<AppUser> userManager;


        public Mapper Mapper { get;}

        public DtoProvider(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Club, ClubShortViewDto>()
                    .AfterMap((src, dest) =>
                    {
                        dest.AveragePlayerAge = src.Players?.DefaultIfEmpty().Average(p => p?.Age ?? 0) ?? 0;
                    });

                cfg.CreateMap<AppUser, UserViewDto>()
                .AfterMap((src, dest) =>
                {
                    dest.IsAdmin = userManager.IsInRoleAsync(src, "Admin").Result;
                });


                cfg.CreateMap<Club, ClubViewDto>();
                cfg.CreateMap<ClubCreateUpdateDto, Club>();
                cfg.CreateMap<PlayerCreateDto, Player>();
                cfg.CreateMap<Player, PlayerViewDto>()
                .AfterMap((src, dest) =>
                {
                    var user = userManager.Users.First(u => u.Id == src.UserId);
                    dest.UserFullName = user.LastName! + " " + user.FirstName;
                });

            });

            Mapper = new Mapper(config);
        }
    }
}
