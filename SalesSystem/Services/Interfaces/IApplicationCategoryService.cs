using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Services.Interfaces;
using SalesSystem.Models;

namespace Application.Services.Interfaces
{
   public interface IApplicationCategoryService 
    {
        IEnumerable<CategoryViewModel> ListCategories();

    }
}
