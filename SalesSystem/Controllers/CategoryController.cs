using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SalesSystem.DAL;
using SalesSystem.Entities;
using SalesSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Controllers
{
    public class CategoryController : Controller
    {
      
        readonly IApplicationCategoryService ApplicationCategoryService;

        public CategoryController(IApplicationCategoryService applicationCategoryService)
        {
            ApplicationCategoryService = applicationCategoryService;
        }
       
        public IActionResult Index()
        {
         

            return View(ApplicationCategoryService.ListCategories());
        }
        /*
        [HttpGet]
        public IActionResult Registration(int? id)
        {
            CategoryViewModel viewModel = new CategoryViewModel();

            if (id != null)
            {
                var entity = mContext.Category.Where(x => x.Id == id).FirstOrDefault();
                viewModel.Id = entity.Id;
                viewModel.Description = entity.Description;
            }

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Registration(CategoryViewModel entity) 
        {
            if (ModelState.IsValid)
            {
                Category objCategory = new Category() {

                    Id = entity.Id,
                    Description = entity.Description
                
                };
                if (entity.Id == null)
                {
                    mContext.Category.Add(objCategory);
                }
                else
                {
                    mContext.Entry(objCategory).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }

                mContext.SaveChanges();
            }
            else
            {
                return View(entity);
            }

            return RedirectToAction("Index");

        }




        [HttpGet]
        public IActionResult Delete(int id)
        {
            var entity = new Category() { Id = id };
            mContext.Attach(entity);
            mContext.Remove(entity);
            mContext.SaveChanges();

            return RedirectToAction("Index");
        }

        */










    }
}
