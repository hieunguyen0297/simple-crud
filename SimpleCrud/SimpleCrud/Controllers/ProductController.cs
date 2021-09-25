using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleCrud.Models;


namespace SimpleCrud.Controllers
{
    public class ProductController : Controller
    {
        List<ProductModel> products = new List<ProductModel>();
        public IActionResult Index()
        {

            products.Add(new ProductModel() { Id = 1, Name = "Mouse Pad", Price = 5.88m, Description = "A square piece of plastic to make mousing easier" });
            products.Add(new ProductModel() { Id = 2, Name = "Web Cam", Price = 20.48m, Description = "Enables you to attend more Zoom meetings" });
            products.Add(new ProductModel() { Id = 3, Name = "Hard Drive", Price = 10.58m, Description = "Back up all your work, you won't regret it" });
            products.Add(new ProductModel() { Id = 4, Name = "Wireless Mouse", Price = 15.98m, Description = "You don't have to connect to your computer using cable" });

            return View(products);
        }
    }
}
