using System.ComponentModel.DataAnnotations.Schema;

namespace SalesSystem.Domain.Repository
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
