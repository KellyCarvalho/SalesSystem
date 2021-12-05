using Domain.Interfaces;
using Repository.Interfaces;
using SalesSystem.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
    public class ServiceCategory : ICategoryService
    {
        ICategoryRepository CategoryCategory;

        public ServiceCategory(ICategoryRepository categoryRepository)
        {
            CategoryCategory = categoryRepository;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> ListCategories()
        {
            

         /*   List<Category> ListCategories = new List<Category>();
            Category category = new Category()
            {

                Id = 1,
                Description="test"
            };
            ListCategories.Add(category);*/

            return CategoryCategory.Read();
        }

        public Category LoadCategories(int id)
        {
            throw new NotImplementedException();
        }

        public void Registration(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
