using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Controllers
{
    public class ShopController : Controller
    {
        private ICheckoutRepository repo { get; set; }
        private Basket basket { get; set; }

        public ShopController(ICheckoutRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }

        // ACTIONS ACTIONS ACTIONS ACTIONS ACTIONS


        [HttpGet]
        public IActionResult Checkout()
        {
            return View(new Checkout());
        }

        [HttpPost]
        public IActionResult Checkout(Checkout checkout)
        {
            if (basket.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }
            if (ModelState.IsValid)
            {
                checkout.Lines = basket.Items.ToArray();
                repo.SaveCheckout(checkout);
                basket.ClearBasket();

                return RedirectToPage("/CheckoutComplete");
            }
            else
            {
                return View();
            }
        }
    }
}
