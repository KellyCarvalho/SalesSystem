using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Entities
{
    public class ProductsSales
    {
        [ForeignKey("Sale")]
        public int SaleId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public double Quantity { get; set; }
        public decimal UnitaryValue { get; set; }
        public decimal TotalValue { get; set; }

        public Product Product { get; set; }
        public Sale Sale { get; set; }


       



    }
}
