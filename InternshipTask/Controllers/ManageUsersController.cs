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
        [HttpPost]
        [Route("CreateUser")]
        public async Task<IActionResult> CreateUser([FromBody]Users model)
        {
            if (ModelState.IsValid)
            {
                _db.users.Add(model);
                await _db.SaveChangesAsync();
            }
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateUser(Users model)
        {
            if (ModelState.IsValid)
            {
                var user = await _db.users.FindAsync(model.Id);
                if(user == null)
                {
                    return NotFound();
                }
                user.FullName = model.FullName;
                user.Email = model.Email;
                user.Gender = model.Gender;
                user.Password = model.Password;
                user.Status = model.Status;
                user.ManageRoleId = model.ManageRoleId;
                _db.users.Update(user);
                await _db.SaveChangesAsync();
            }

            return Ok();
        }
    }
}
