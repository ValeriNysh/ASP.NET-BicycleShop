﻿using BicyclesShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BicyclesShop.Controllers
{
    public class HomeController : Controller
    {
        readonly ILogger<HomeController> _logger;

        BicycleContext context;

        public HomeController(BicycleContext context, ILogger<HomeController> logger)
        {
            this.context = context;
            _logger = logger;
        }

        public async Task<IActionResult> Index(string thanks="", int pageNumber=1)
        {
            if (!string.IsNullOrEmpty(thanks))
                ViewBag.Thanks = thanks;

            var bicycles = context.Bicycles.OrderBy(x => x.BicycleId);

            int pageSize = 10;

            //var bicycles = context.Bicycles.ToList();
            //return View(bicycles);

            return View(await PaginatedList<Bicycle>.CreateAsync(bicycles.AsNoTracking(), pageNumber, pageSize));
            
        }

        
        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null)
                return RedirectToAction("Index");
            ViewBag.CarId = id;
            return View();
        }

        [HttpPost]
        public IActionResult Buy(Order order)
        {
            if (ModelState.IsValid)
            {
                context.Orders.Add(order);
                context.SaveChanges();
                return RedirectToAction("Index", new { thanks = "Спасибо за покупку!" });
            }
            else
                return View();
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }
}
