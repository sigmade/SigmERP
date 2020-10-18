using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SigmERP.Models
{
    public class User
    {
        public int Id { get; set; }

        
        public string Email { get; set; }
        public string Password { get; set; }

        public int? RoleId { get; set; }

        [Display(Name = "Роль")]
        public Role Role { get; set; }
    }
}
