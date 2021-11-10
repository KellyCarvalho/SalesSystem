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
    public class ClientController : Controller
    {
        protected ApplicationDbContext mContext;

        public ClientController(ApplicationDbContext context)
        {
            mContext = context;
        }
       
        public IActionResult Index()
        {
            IEnumerable<Client> clients = mContext.Client.ToList();
            mContext.Dispose();

            return View(clients);
        }

        [HttpGet]
        public IActionResult Registration(int? id)
        {
            ClientViewModel viewModel = new ClientViewModel();

            if (id != null)
            {
                var entity = mContext.Client.Where(x => x.Id == id).FirstOrDefault();
                viewModel.Id = entity.Id;
                viewModel.Name = entity.Name;
                viewModel.Phone = entity.Phone;
                viewModel.CNPJ_CPF = entity.CNPJ_CPF;
                viewModel.Email = entity.Email;
            }

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Registration(ClientViewModel entity) 
        {
            var a = entity;
            if (ModelState.IsValid)
            {
                Client objClient = new Client() {

                    Id = entity.Id,
                    Name = entity.Name,
                    CNPJ_CPF = entity.CNPJ_CPF,
                    Email = entity.Email,
                    Phone = entity.Phone
                    
                
                };
                if (entity.Id == null)
                {
                    mContext.Client.Add(objClient);
                }
                else
                {
                    mContext.Entry(objClient).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
            var entity = new Client() { Id = id };
            mContext.Attach(entity);
            mContext.Remove(entity);
            mContext.SaveChanges();

            return RedirectToAction("Index");
        }












    }
}
