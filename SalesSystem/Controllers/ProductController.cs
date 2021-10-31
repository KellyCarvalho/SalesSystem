using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SalesSystem.DAL;
using SalesSystem.Entities;
using SalesSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Controllers
{
    public class ProductController : Controller
    {
        protected ApplicationDbContext mContext;

        public ProductController(ApplicationDbContext context)
        {
            mContext = context;
        }
       
        public IActionResult Index()
        {
            IEnumerable<Product> products = mContext.Product.Include(x=>x.Category).ToList();
            mContext.Dispose();

            return View(products);
        }

         [HttpGet]
          public IActionResult Registration(int? id)
          {
              ProductViewModel viewModel = new ProductViewModel();

              viewModel.CategoriesList = CategoryList();


              if (id != null)
              {
                  var entity = mContext.Product.Where(x => x.Id == id).FirstOrDefault();
                  viewModel.Id = entity.Id;
                  viewModel.Description = entity.Description;
                  viewModel.Quantity = entity.Quantity;
                  viewModel.Value = entity.Value;
                  viewModel.CategoryId = entity.CategoryId;

              }

              return View(viewModel);
          }

          private IEnumerable<SelectListItem> CategoryList()
          {

              List<SelectListItem> list = new List<SelectListItem>();

              list.Add(new SelectListItem()
              {
                  Value=string.Empty,
                  Text=string.Empty
              });

              foreach(var item in mContext.Category.ToArray())
              {
                  list.Add(new SelectListItem()
                  {
                      Value= item.Id.ToString(),
                      Text = item.Description.ToString()

                  });
              }
              return list;
          }
   
      [HttpPost]
        public IActionResult Registration(ProductViewModel entity) 
        {
            if (ModelState.IsValid)
            {
                Product objProduct = new Product() {

                    Id = entity.Id,
                    Description=entity.Description,
                    Quantity = entity.Quantity,
                    Value=entity.Value,
                    CategoryId= (int) entity.CategoryId




                };
                if (entity.Id == null)
                {
                    mContext.Product.Add(objProduct);
                }
                else
                {
                    mContext.Entry(objProduct).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }

                mContext.SaveChanges();
            }
            else
            {
                entity.CategoriesList = CategoryList();
                return View(entity);
            }

            return RedirectToAction("Index");

        }




        [HttpGet]
        public IActionResult Delete(int id)
        {
            var entity = new Product() { Id = id };
            mContext.Attach(entity);
            mContext.Remove(entity);
            mContext.SaveChanges();

            return RedirectToAction("Index");
        }


 









    }
}
