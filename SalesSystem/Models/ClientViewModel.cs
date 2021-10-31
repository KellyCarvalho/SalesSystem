using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models
{
    public class ClientViewModel
    {
        public int? Id { get; set; }
        [Required(ErrorMessage= "Enter Name ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter CPF/CNPJ ")]
        public string CNPJ_CPF { get; set; }
        [Required(ErrorMessage = "Enter Email ")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter Phone ")]
        public string Phone { get; set; }

    }
}
