using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Domain.Repository
{
    public class Sale
    {   [Key]
        public int? Id { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
     

        public Client Client { get; set; }

        public decimal Total { get; set; }
        
        public ICollection<ProductsSales> Products { get; set; }

   

      
    }
}
