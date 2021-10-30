using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Entities
{
    public class Client
    {
        [Key]
        public int? Id { get; set; }
        public string Name { get; set; }
        public string CNPJ_CPF { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
