using Microsoft.AspNetCore.Mvc.Rendering;
using SalesSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models
{
    public class SaleViewModel
    {
        public int? Id { get; set; }
        [Required(ErrorMessage="Enter Sale Date")]
        public DateTime? Date { get; set; }

        [Required(ErrorMessage = "Enter Customer")]
        public int ClientId { get; set; }

        public int ProductId { get; set; }
        public IEnumerable<SelectListItem> ClientsList { get; set; }
        public IEnumerable<SelectListItem> ProductsList { get; set; }

        public string JsonProducts { get; set; }

    

        public decimal Total { get; set; }

    
    }
}
