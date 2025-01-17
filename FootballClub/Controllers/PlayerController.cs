using FootballClub.Data;
using FootballClub.Entity.Dtos.Player;
using FootballClub.Logic.Logic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FootballClub.Endpoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PlayerController : ControllerBase
    {
        PlayerLogic logic;
        UserManager<AppUser> userManager;

        public PlayerController(PlayerLogic logic, UserManager<AppUser> userManager)
        {
            this.logic = logic;
            this.userManager = userManager;
        }

        [HttpPost]
        public async Task AddPlayer(PlayerCreateDto dto)
        {
            var user = await userManager.GetUserAsync(User);


            logic.AddPlayer(dto, user.Id);

        }



    }
}
