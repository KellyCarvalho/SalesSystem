
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesSystem.DAL;
using SalesSystem.Helpers;
using SalesSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SalesSystem.Controllers
{
    public class LoginController : Controller

    {
        protected ApplicationDbContext mContext;
        protected IHttpContextAccessor _httpContextAccessor;
        

        public LoginController(ApplicationDbContext context, IHttpContextAccessor httpContext)
        {
            mContext = context;
            _httpContextAccessor = httpContext;
        }

        public IActionResult Index()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
               var password = Cryptography.GetMd5Hash(loginViewModel.Password);
               var validation = mContext.User.Where(x=>x.Email==loginViewModel.Email && x.Password== password).FirstOrDefault();
               
                ViewData["ErrorLogin"] = string.Empty;
                if (validation == null)
                {



                   ViewData["Message"] = "The Email or Password User doesn't exist";

                   return View(loginViewModel);
                }
                else
                {
                    _httpContextAccessor.HttpContext.Session.SetString(Session.USER_NAME, validation.Name);
                    _httpContextAccessor.HttpContext.Session.SetString(Session.USER_EMAIL, validation.Email);
                    _httpContextAccessor.HttpContext.Session.SetInt32(Session.USER_ID, (int)validation.Id);
               

                    var a = _httpContextAccessor.HttpContext.Session.GetString(Session.USER_ID);

                   













                    return RedirectToAction("Index", "Home");
                }
                
               
            }
            else
            {
                return View(loginViewModel);
            }
        

        }

    }
}
