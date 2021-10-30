using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Entities
{
    public class Sale
    {
        public int? Id { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public decimal Total { get; set; }
    }
}
