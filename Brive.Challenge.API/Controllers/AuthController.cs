using Brive.Challenge.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.Challenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        public ActionResult<bool> loginUser([FromBody]LoginModel loginModel)
        {
            return StatusCode(StatusCodes.Status200OK, true);
        }
    }
}
