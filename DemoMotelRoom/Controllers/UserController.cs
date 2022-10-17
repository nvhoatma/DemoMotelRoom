using DemoMotelRoom.Models;
using DemoMotelRoom.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoMotelRoom.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUsersRepository usersRepository;

        public UserController(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetAllUser()
        {
            return await usersRepository.Get();
        }
        [HttpPost]
        public async Task<ActionResult> PostUser([FromBody] User user)
        {
            var newUser = await usersRepository.Create(user);
            return Ok(newUser);
        }
    }
}
