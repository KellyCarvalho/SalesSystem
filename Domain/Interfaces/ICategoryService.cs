using SalesSystem.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface ICategoryService
    {
            IEnumerable<Category> ListCategories();      
            void Registration(Category category);
            Category LoadCategories(int id);
            void Delete(int id);

    }
}
