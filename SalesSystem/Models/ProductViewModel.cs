 using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SalesSystem.Models
{
    public class ProductViewModel
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "Enter the Product Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Enter the Product Quantity")]
        public double Quantity { get; set; }
        [Required(ErrorMessage = "Enter the Unitary Product Value")]

        [Range(0.1,Double.PositiveInfinity)]
        public decimal Value { get; set; }
        [Required(ErrorMessage = "Enter the Product Category")]


        [ForeignKey("Category")]
        public int? CategoryId { get; set; }

        public IEnumerable<SelectListItem> CategoriesList { get; set; }
      
    }
}
