using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Components
{
    public class CartViewComponent : ViewComponent
    {
        private IBookstoreRepository repo { set; get; }
        public CartViewComponent(IBookstoreRepository temp)
        {
            repo = temp;
        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
