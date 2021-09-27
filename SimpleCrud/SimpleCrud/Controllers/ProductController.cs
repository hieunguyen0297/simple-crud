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

        //Make a search form
        public IActionResult SearchForm()
        {
            return View();
        }

        //This method will do the search form
        //The searchTerm will correspond to the name= "searchTerm" in the SearchFrom.cshtml
        public IActionResult SearchResult(string searchTerm)
        {
            ProductsDataAccessObject products = new ProductsDataAccessObject();
            
            return View("Index", products.SearchProductByName(searchTerm));
        }
      

    }
}
