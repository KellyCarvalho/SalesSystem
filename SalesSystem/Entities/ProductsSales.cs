using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Entities
{
    public class ProductsSales
    {
        public int IdSale { get; set; }
        public int IdProduct { get; set; }
        public double Quantity { get; set; }
        public decimal UnityValue { get; set; }
        public decimal TotalValue { get; set; }

        public Product Product { get; set; }
        public Sale Sale { get; set; }


       



    }
}
