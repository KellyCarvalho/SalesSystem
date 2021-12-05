using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Domain.Repository
{
    public class Product
    {   [Key]
        public int? Id { get; set; }
      
        public string Description { get; set; }
     
        public double Quantity { get; set; }
     

        public decimal Value { get; set; }
      


        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
       
        public ICollection<ProductsSales> Sales { get; set; }
    }
}
