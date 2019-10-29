using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserService.Models;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET api/user
        [HttpGet("getUser")]
        public ActionResult<IEnumerable<User>> Get()
        {
            var user = GetDummyData();

            return Ok(user);
        }

        private User GetDummyData()
        {
            User user = new User
            {
                Id = 1,
                Name = "CP Variyani",
                Email = "cpvariyani90@gmail.com"
            };
            return user;
        }


    }
}
