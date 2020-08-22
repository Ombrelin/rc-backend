using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModernPlayerManagementAPI.Models.DTOs;
using RencontreContemporainesAPI.Services.Interfaces;

namespace RencontreContemporainesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService userService;

        public AuthController(IUserService userService)
        {
            this.userService = userService;
        }

        /// <summary>
        /// Authenticate an user with his username and password
        /// </summary>
        /// <param name="dto">The user's login infos</param>
        /// <returns>Infos about the user and his JWT Token</returns>
        [HttpPost("authenticate")]
        [ProducesResponseType(typeof(LoggedUserDTO), StatusCodes.Status200OK)]
        public IActionResult Authenticate([FromBody] LoginDTO dto)
        {
            var user = this.userService.Authenticate(dto.Username, dto.Password);
            if (user == null)
            {
                return Unauthorized();
            }

            var responseDTO = new LoggedUserDTO()
            {
                Username = user.Username,
                Token = user.Token,
                Id = user.Id
            };

            return Ok(responseDTO);
        }
    }
}