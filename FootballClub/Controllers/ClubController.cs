using FootballClub.Data;
using FootballClub.Entity;
using FootballClub.Entity.Dtos.Club;
using FootballClub.Entity.Helpers;
using FootballClub.Logic.Logic;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize]
        public void AddClub(ClubCreateUpdateDto dto)
        {

            logic.AddClub(dto);
            
        }


        [HttpGet]
        public IEnumerable<ClubShortViewDto> GetAllClubs()
        {
            return logic.GetAllClubs();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public void DeleteClub(string id)
        {
            logic.DeleteClub(id);
        }

        [HttpPut("{id}")]
        [Authorize]
        public void UpdateClub(string id,[FromBody] ClubCreateUpdateDto dto)
        {
            logic.UpdateClub(id, dto);
        }

        [HttpGet("{id}")]
        public ClubViewDto GetClub(string id)
        {
            return logic.GetClub(id);
        }



    }
}
