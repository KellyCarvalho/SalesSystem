using SalesSystem.Domain.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Domain.Repository
{
    public class Category
    {
        [Key]
        public int? Id { get; set; }
        public string Description { get; set; }

        public ICollection<Product> products { get; set; }
        
    }
}
