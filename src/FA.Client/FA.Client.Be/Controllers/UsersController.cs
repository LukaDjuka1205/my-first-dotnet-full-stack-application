using FA.Client.Be.Repository;
using FA.Client.Be.Repository.Entity;
using FA.Client.Common.Contracts.Request.Users;
using Microsoft.AspNetCore.Mvc;

namespace FA.Client.Be.Controllers
{
    public class UsersController : ControllerBase
    {
        private readonly FADbContext _dbContext;
        public UsersController(FADbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("/users")]
        public IActionResult UsersGet()
        {
            return Ok(_dbContext.Set<UserEntity>().AsQueryable().ToList());
        }
        
        [HttpPost]
        [Route("/login")]
        public IActionResult UsersLogin([FromBody] UsersLoginRequest request)
        {
            var qUsers = _dbContext.Set<UserEntity>().AsQueryable();

            if (qUsers.Any(x => x.Username == request.Username && x.Password == request.Password))
                return Ok();
            
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

            if (_dbContext.Set<UserEntity>().AsQueryable().Any(x => x.Username == request.Username))
                return BadRequest("Korisnik sa ovim imenom vec postoji!");

            _dbContext.Add(new Repository.Entity.UserEntity()
            {
                Username = request.Username,
                Password = request.Password,
                FirstName = request.FirstName,
                LastName = request.LastName,
                City = "something random"
            });
            _dbContext.SaveChanges();
            
            return Ok();
        }
    }
}
