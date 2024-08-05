using FA.Client.Be.Request.Users;
using Microsoft.AspNetCore.Mvc;

namespace FA.Client.Be.Controllers
{
    public class UsersController : ControllerBase
    {
        [HttpPost]
        [Route("/login")]
        public IActionResult UsersLogin([FromBody] UsersLoginRequest request)
        {
            if(request.Username != "admin" || request.Password != "admin")
                return BadRequest("Korisnicko ime ili lozinka nisu dobri!");

            return Ok("Pong");
        }
    }
}
