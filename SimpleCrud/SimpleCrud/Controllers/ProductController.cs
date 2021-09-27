using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleCrud.Models;
using SimpleCrud.Services;

namespace SimpleCrud.Controllers
{
    public class ProductController : Controller
    {
        
        public IActionResult Index()
        {
            ProductsDataAccessObject products = new ProductsDataAccessObject();

            return View(products.GetAllProducts());
        }
    }
}
