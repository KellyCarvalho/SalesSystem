using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models
{
    public class ClientViewModel
    {
        public int? Id { get; set; }
        [Requered(ErrorMessage= "Enter Name ")]
        public string Name { get; set; }
        [Requered(ErrorMessage = "Enter CPF/CNPJ ")]
        public string CNPJ_CPF { get; set; }
        [Requered(ErrorMessage = "Enter Email ")]
        public string Email { get; set; }
        [Requered(ErrorMessage = "Enter Phone ")]
        public string Phone { get; set; }

    }
}
