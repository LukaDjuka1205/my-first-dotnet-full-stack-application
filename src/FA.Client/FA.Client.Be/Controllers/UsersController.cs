using FA.Client.Be.Request.Users;
using Microsoft.AspNetCore.Mvc;

namespace FA.Client.Be.Controllers
{
    public class UsersController : ControllerBase
    {
        [HttpGet]
        [Route("/users")]
        public IActionResult UsersGet()
        {
            throw new NotImplementedException();
        }
        
        [HttpPost]
        [Route("/login")]
        public IActionResult UsersLogin([FromBody] UsersLoginRequest request)
        {
            throw new NotImplementedException();
            
            return BadRequest("Pogresno korisnicko ime ili lozinka!");
        }
        
        [HttpPost]
        [Route("/register")]
        public IActionResult UsersRegister([FromBody] UsersRegisterRequest request)
        {
            if(string.IsNullOrWhiteSpace(request.Username))
                return BadRequest("Korisnicko ime je obavezno!");
            if(string.IsNullOrWhiteSpace(request.Password))
                return BadRequest("Lozinka je obavezna!");
            if(string.IsNullOrWhiteSpace(request.FirstName))
                return BadRequest("Ime je obavezno!");
            if(string.IsNullOrWhiteSpace(request.LastName))
                return BadRequest("Prezime je obavezno!");
            if(request.Username.Length < 3)
                return BadRequest("Korisnicko ime mora imati najmanje 3 karaktera!");
            if(request.Password.Length < 3)
                return BadRequest("Lozinka mora imati najmanje 3 karaktera!");
            if(request.FirstName.Length < 3)
                return BadRequest("Ime mora imati najmanje 3 karaktera!");
            if(request.LastName.Length < 3)
                return BadRequest("Prezime mora imati najmanje 3 karaktera!");

            throw new NotImplementedException();
            
            return Ok();
        }
    }
}
