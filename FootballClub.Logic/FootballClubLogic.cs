using FootballClub.Data;
using FootballClub.Entity;
using FootballClub.Entity.Dtos.Club;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClub.Logic
{
    public class FootballClubLogic
    {

        Repository<Club> repo;

        public FootballClubLogic(Repository<Club> repo)
        {
            this.repo = repo;
        }

        public void AddClub(ClubCreateUpdateDto dto)
        {
            Club c = new Club(dto.ClubName, dto.YearFounded, dto.StadiumName, dto.StadiumCapacity, dto.Trophies, dto.Country);
            //ha nincs ilyen nevű csapat, akkor elmentjük
            if (repo.GetAll().FirstOrDefault(x => x.ClubName == c.ClubName) == null)
            {
                repo.Create(c);
            }
            else
            {
                throw new ArgumentException("Club already exists");
            }
        }

        public IEnumerable<ClubShortViewDto> GetAllClubs()
        {
            return repo.GetAll().Select(x => new ClubShortViewDto
            {
                Id = x.Id,
                ClubName = x.ClubName,
                YearFounded = x.YearFounded,
                Country = x.Country
            });
        }


        public void DeleteClub(string id)
        {
            repo.DeleteById(id);
        }

        public void UpdateClub(string id, ClubCreateUpdateDto dto)
        {
            var old = repo.FindById(id);
            old.ClubName = dto.ClubName;
            old.YearFounded = dto.YearFounded;
            old.StadiumName = dto.StadiumName;
            old.StadiumCapacity = dto.StadiumCapacity;
            old.Trophies = dto.Trophies;
            old.Country = dto.Country;
            repo.Update(old);
        }
    }
}
