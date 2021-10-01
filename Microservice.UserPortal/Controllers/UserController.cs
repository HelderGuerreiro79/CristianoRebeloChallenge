using Microservice.UserPortal.DataLayer;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Microservice.UserPortal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly PortalDbContext context;

        public UserController(PortalDbContext context)
        {
            this.context = context;
        }
        public IActionResult GetUsers()
        {
            var users = this.context.Users.ToList();
            return Ok(users);
        }
    }
}
