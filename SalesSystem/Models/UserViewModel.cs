using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models
{
    public class UserViewModel
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "Enter User Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter User Email")]
        public string Email { get; set; }
    }
}
