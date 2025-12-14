using Microsoft.AspNetCore.Mvc;
using Thushar.Example.Project.Application.Contract.Interfaces;

namespace Thushar.Example.Project.HttpApi.Controllers
{
    [ApiController]
    [Route("v1/user")]
    public class UserController(IUserAppService userAppService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetUserName([FromQuery] Guid userId)
        {
            var name = await userAppService.GetUserName(userId);
            return Ok(name);
        }
    }
}
