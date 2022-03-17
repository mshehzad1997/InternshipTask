using InternshipTask.Models;
using InternshipTask.Models.Data;
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
    public class ManageUsersController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public ManageUsersController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult GetUsers()
        {
            return Ok();
        }
        public async Task<IActionResult> CreateUser([FromBody]Users model)
        {
            if (ModelState.IsValid)
            {
                _db.users.Add(model);
                await _db.SaveChangesAsync();
            }
            return Ok();
        }
    }
}
