using FootballClub.Data;
using FootballClub.Entity;
using FootballClub.Entity.Dtos.Club;
using FootballClub.Logic.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClub.Logic.Logic
{
    public class FootballClubLogic
    {

        Repository<Club> repo;
        DtoProvider dtoProvider;

        public FootballClubLogic(Repository<Club> repo, DtoProvider dtoProvider)
        {
            this.repo = repo;
            this.dtoProvider = dtoProvider;
        }

        public void AddClub(ClubCreateUpdateDto dto)
        {

            Club c = dtoProvider.Mapper.Map<Club>(dto);



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
            return repo.GetAll().Select(x =>
            dtoProvider.Mapper.Map<ClubShortViewDto>(x));
        }


        public void DeleteClub(string id)
        {
            repo.DeleteById(id);
        }

        public void UpdateClub(string id, ClubCreateUpdateDto dto)
        {
            var old = repo.FindById(id);
            dtoProvider.Mapper.Map(dto, old);
            repo.Update(old);
        }


        public ClubViewDto GetClub(string id)
        {
            var club = repo.FindById(id);

            return dtoProvider.Mapper.Map<ClubViewDto>(club);
        }
    }
}
