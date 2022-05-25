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
    public class EnterpriseController : ControllerBase
    {
        [HttpPost]
        [Route("search")]
        public ActionResult<bool> search([FromBody] Enterprise enterpise)
        {
            return StatusCode(StatusCodes.Status200OK, true);
        }

        [HttpGet]
        [Route("all")]
        public ActionResult<List<Enterprise>> getEnterprise([FromBody] Enterprise enterpise)
        {
            List<Enterprise> Enterprise = new List<Enterprise>();
            for (int i = 0; i <= 5; i++)
            {
                Enterprise.Add(new Enterprise
                {
                    Id = i + 1,
                    Name = "prueba",
                    TotalVacants = i + 5,
                    CeateDate = DateTime.Now
                });
            }
            return StatusCode(StatusCodes.Status200OK, Enterprise);
        }

    }
}
