﻿using Microsoft.AspNetCore.Mvc;
using SalesSystem.DAL;
using SalesSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Controllers
{
    public class ReportController : Controller
    {
        protected ApplicationDbContext mContext;

        public ReportController(ApplicationDbContext context)
        {
            mContext = context;
        }
        public IActionResult Index()
        {

            var list = mContext.ProductsSales.AsEnumerable().GroupBy(x => x.ProductId).Select(y => new GraphicViewModel { ProductId = y.First().ProductId,TotalSales=y.Sum(s=>s.Quantity)}).ToList();

           

            string values = string.Empty;
            string labels = string.Empty;
            string colors = string.Empty;

           var random = new Random();
           for (int i = 0; i < list.Count; i++)
            {
                values += list[i].ProductId.ToString()+",";
                labels +="'"+ list[i].TotalSales.ToString() + "' ,";
      

            }

            ViewBag.Values = values;
            ViewBag.Labels= labels;
            ViewBag.Colors = colors;


            return View();
        }
    }
}
