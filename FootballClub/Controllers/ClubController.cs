using FootballClub.Data;
using FootballClub.Entity;
using FootballClub.Entity.Dtos.Club;
using FootballClub.Logic;
using Microsoft.AspNetCore.Mvc;

namespace FootballClub.Endpoint.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ClubController : ControllerBase
    {
        FootballClubLogic logic;

        public ClubController(FootballClubLogic logic)
        {
            this.logic = logic;
        }

        [HttpPost]
        public void AddClub(ClubCreateUpdateDto dto)
        {
            logic.AddClub(dto);

        }


        [HttpGet]
        public IEnumerable<ClubShortViewDto> GetAllClubs()
        {
            return logic.GetAllClubs();
        }

        [HttpDelete]
        public void DeleteClub(string id)
        {
            logic.DeleteClub(id);
        }

        [HttpPut("{id}")]
        public void UpdateClub(string id,[FromBody] ClubCreateUpdateDto dto)
        {
            logic.UpdateClub(id, dto);
        }



    }
}
