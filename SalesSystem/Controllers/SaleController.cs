using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SalesSystem.DAL;
using SalesSystem.Entities;
using SalesSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Controllers
{
    public class SaleController : Controller
    {
        protected ApplicationDbContext mContext;

        public SaleController(ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Sale> sales = mContext.Sale.Include(y=>y.Client).ToList();
            mContext.Dispose();

            return View(sales);
        }

        private IEnumerable<SelectListItem> ProductsList()
        {

            List<SelectListItem> list = new List<SelectListItem>();

            list.Add(new SelectListItem()
            {
                Value = string.Empty,
                Text = string.Empty
            });

            foreach (var item in mContext.Product.ToArray())
            {
                list.Add(new SelectListItem()
                {
                    Value = item.Id.ToString(),
                    Text = item.Description.ToString()

                });
            }
            return list;
        }


        private IEnumerable<SelectListItem> ClientsList()
        {

            List<SelectListItem> list = new List<SelectListItem>();

            list.Add(new SelectListItem()
            {
                Value = string.Empty,
                Text = string.Empty
            });

            foreach (var item in mContext.Client.ToArray())
            {
                list.Add(new SelectListItem()
                {
                    Value = item.Id.ToString(),
                    Text = item.Name.ToString()

                });
            }
            return list;
        }

        [HttpGet]
        public IActionResult Registration(int? id)
        {
           SaleViewModel viewModel = new SaleViewModel();

            viewModel.ProductsList = ProductsList();
            viewModel.ClientsList = ClientsList();


            if (id != null)
            {
                var entity = mContext.Sale.Where(x => x.Id == id).FirstOrDefault();
                viewModel.Id = entity.Id;
                viewModel.ClientId = entity.ClientId;
                viewModel.Date = entity.Date;
                viewModel.Total = entity.Total;
                viewModel.ClientId = (int)entity.Client.Id;
                viewModel.Total = entity.Total;

      

            }

            return View(viewModel);
        }

       

        [HttpPost]
        public IActionResult Registration(SaleViewModel entity)
        {
            if (ModelState.IsValid)
            {
                Sale objSale = new Sale()
                {

                    Id = entity.Id,
                    Date = (DateTime)entity.Date,
                    ClientId = entity.ClientId,
                    Total = entity.Total,
                    Products = JsonConvert.DeserializeObject<ICollection<ProductsSales>>(entity.JsonProducts)

                };
                if (entity.Id == null)
                {
                    mContext.Sale.Add(objSale);
                }
                else
                {
                    mContext.Entry(objSale).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }

                mContext.SaveChanges();
            }
            else
            {
                entity.ProductsList = ProductsList();
                entity.ClientsList = ClientsList();
                return View(entity);
            }

            return RedirectToAction("Index");

        }




        [HttpGet]
        public IActionResult Delete(int id)
        {
            var entity = new Sale() { Id = id };
            mContext.Attach(entity);
            mContext.Remove(entity);
            mContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet("ReadProductValue/{ProductId}/")]
        public decimal ReadProductValue(int productId)
        {
       

            return (decimal) mContext.Product.Where(x => x.Id == productId).Select(y => y.Value).FirstOrDefault();
        }


    }
}
