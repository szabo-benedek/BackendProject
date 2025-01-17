using FootballClub.Data;
using FootballClub.Entity;
using FootballClub.Entity.Dtos.Player;
using FootballClub.Logic.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClub.Logic.Logic
{
    public class PlayerLogic
    {

        Repository<Player> repo;
        DtoProvider dtoProvider;

        public PlayerLogic(Repository<Player> repo, DtoProvider dtoProvider)
        {
            this.repo = repo;
            this.dtoProvider = dtoProvider;
        }

        public void AddPlayer(PlayerCreateDto dto, string userId)
        {
            var player = dtoProvider.Mapper.Map<Player>(dto);
            player.UserId = userId;
            repo.Create(player);
        }

    }
}
