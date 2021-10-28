using BicyclesShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicyclesShop.Controllers
{
    public class AdminController : Controller
    {
        BicycleContext context;

        public AdminController(BicycleContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.Bicycles.ToList());
        }

        public IActionResult Create(int? bicycleId)
        {
            if (bicycleId == null)
                return View();
            else
                return View(context.Bicycles.FirstOrDefault(x => x.BicycleId == bicycleId));
        }

        [HttpPost]
        public IActionResult Create(Bicycle bicycle)
        {
            if (bicycle.BicycleId == 0)
                context.Bicycles.Add(bicycle);
            else
                context.Update(bicycle);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int BicycleId)
        {
            var bicycleToDelete = context.Bicycles.Find(BicycleId);
            context.Bicycles.Remove(bicycleToDelete);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
