using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Entities
{
    public class Product
    {   [Key]
        public int? Id { get; set; }
        public string Description { get; set; }
        public double quantity { get; set; }

        public decimal Value { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
    }
}
