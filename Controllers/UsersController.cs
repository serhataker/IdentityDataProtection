using Azure.Identity;
using IdentityDataProtection.Dto;
using IdentityDataProtection.Request;
using IdentityDataProtection.Services;
using Microsoft.AspNetCore.Mvc;

namespace IdentityDataProtection.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;


        public UserController(IUserService userService)
        {
            _userService = userService;
            
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RequestView request)// we send to the Request View data
        {
            var adduserdto = new UserRequest// crate the user dto
            {
                Email = request.Email,
                Password = request.Password,

            };

               var Result= await _userService.AddUser(adduserdto);// send to the adduser service


            if (Result.IsSucceed)// if it is sucesess
            {

                return Ok(Result.Message);
            }

            else { 
            return BadRequest(Result.Message.ToString());
            }
        }


    }
}
