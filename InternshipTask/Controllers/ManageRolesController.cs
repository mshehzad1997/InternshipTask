using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternshipTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManageRolesController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public ManageRolesController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult GetRoles()
        {
            return Ok();
        }

    }
}
