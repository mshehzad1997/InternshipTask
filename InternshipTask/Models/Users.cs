using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InternshipTask.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        [UniqueUserEmail]
        public string Email { get; set; }
        [Display(Name = "ManageRoleId")]
        public int ManageRoleId{ get; set; }
        
        [ForeignKey("ManageRoleId")]
      
        public virtual ManageRoles ManageRoles { get; set; }
        public gender Gender { get; set; }
        public bool Status { get; set; }
        public string Password { get; set; }
        public enum gender
        {
            Male,
            Female
        }
    }
}
