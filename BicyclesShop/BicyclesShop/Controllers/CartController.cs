using BicyclesShop.Extensions;
using BicyclesShop.Models;
using BicyclesShop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicyclesShop.Controllers
{
    public class CartController : Controller
    {
        BicycleContext context;
        public CartController(BicycleContext context)
        {
            this.context = context;
        }

        public IActionResult Index(string returnUrl)
        {
            var cart = GetCart();

            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            }) ;
        }

        public IActionResult AddToCart(int bicycleId, string returnUrl)
        {
            Bicycle bicycle = context.Bicycles.FirstOrDefault(x => x.BicycleId == bicycleId);
            if(bicycle != null)
            {
                var cart = GetCart();
                cart.AddItem(bicycle, 1);
                HttpContext.Session.SetObjectAsJson("Cart", cart);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public IActionResult RemoveFromCart(int bicycleId, string returnUrl)
        {
            Bicycle bicycle = context.Bicycles.FirstOrDefault(x => x.BicycleId == bicycleId);
            if (bicycle != null)
            {
                var cart = GetCart();
                cart.RemoveLine(bicycle);
                HttpContext.Session.SetObjectAsJson("Cart", cart);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        private Cart GetCart()
        {
            Cart cart = HttpContext.Session.GetObjectFromJson<Cart>("Cart"); 
            if(cart == null)
            {
                cart = new Cart();
                HttpContext.Session.SetObjectAsJson("Cart", cart);
            }
            return cart;
        }

    }
}
