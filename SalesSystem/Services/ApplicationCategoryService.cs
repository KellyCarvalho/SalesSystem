using Application.Services.Interfaces;
using Domain.Interfaces;
using SalesSystem.Models;
using System;
using System.Collections.Generic;


namespace Application.Services
{
    public class ApplicationCategoryService : IApplicationCategoryService
    {
        private readonly ICategoryService CategoryService;
        public ApplicationCategoryService(ICategoryService categoryService)
        {
            CategoryService = categoryService;
        }

        public IEnumerable<CategoryViewModel> ListCategories()
        {
            var list = CategoryService.ListCategories();
            List<CategoryViewModel> categoryList = new List<CategoryViewModel>();

            foreach(var item in list)
            {
                CategoryViewModel category = new CategoryViewModel()
                {
                    Id = item.Id,
                    Description = item.Description
                };
                categoryList.Add(category);
            }
            return categoryList;


        }
    }
}
