using Microsoft.AspNetCore.Mvc;
using SalesSystem.DAL;
using SalesSystem.Entities;
using SalesSystem.Helpers;
using SalesSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Controllers
{
    public class UserController : Controller
    {
        protected ApplicationDbContext mContext;

        public UserController(ApplicationDbContext context)
        {
            mContext = context;
        }


        public IActionResult Index()
        {
            IEnumerable<User> users = mContext.User.ToList();

            return View(users);
        }
        [HttpGet]
        public IActionResult Registration(int? id)
        { 
            UserInsertViewModel userInsertViewModel= new UserInsertViewModel();

            if (id !=null)
            {
                var entity = mContext.User.Where(x => x.Id == id).FirstOrDefault();
                userInsertViewModel.Id = entity.Id;
                userInsertViewModel.Name = entity.Name;
                userInsertViewModel.Email = entity.Email;
                userInsertViewModel.Password = Cryptography.GetMd5Hash(entity.Password);

            }
            return View(userInsertViewModel);
        }

        [HttpPost]
        public IActionResult Registration(UserInsertViewModel entity)
        {
            if (ModelState.IsValid)
            {

                User objUser = new User()
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    Email = entity.Email,
                    Password = Cryptography.GetMd5Hash(entity.Password)
                };

                if (entity.Id == null)
                {
                    mContext.User.Add(objUser);
                }
                else
                {
                    mContext.Entry(objUser).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                mContext.SaveChanges();
            }
            else
            {
                return View(entity);
            }

            return RedirectToAction("Index");



        }

        public IActionResult Delete(int id)
        {
            var entity = new User() { Id = id };
            mContext.Attach(entity);
            mContext.Remove(entity);
            mContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
