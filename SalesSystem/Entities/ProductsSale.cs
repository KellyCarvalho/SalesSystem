using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Entities
{
    public class ProductsSale
    {
        public int IdSale { get; set; }
        public int IdProduct { get; set; }
        public double Quantity { get; set; }
        public decimal UnityValue { get; set; }
        public decimal TotalValue { get; set; }

        public Category category { get; set; }
    }
}
