using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleCrud.Models;
using SimpleCrud.Services;

namespace SimpleCrud.Controllers
{
    [ApiController]
    [Route("/api")]
    public class ProductControllerAPI : ControllerBase
    {
        ProductsDataAccessObject products;
        public ProductControllerAPI()
        {
            products = new ProductsDataAccessObject();
        }

        [HttpGet]
        public ActionResult <IEnumerable<ProductModel>> Index()
        {
            return products.GetAllProducts();
        }
        
        /*
        //Make a search form
        public IActionResult SearchForm()
        {
            return View();
        }
        */

        //This method will do the search form
        //The searchTerm will correspond to the name= "searchTerm" in the SearchFrom.cshtml
        [HttpGet("searchproducts/{searchTerm}")]
        public ActionResult <IEnumerable<ProductModel>> SearchResult(string searchTerm)
        {
            return products.SearchProductByName(searchTerm);
        }

         
        
        /*
        //Return a view with one product
        public IActionResult ShowDetails(int id)
        {
            ProductsDataAccessObject product = new ProductsDataAccessObject();
            
            return View(product.GetProductDetails(id));
        }
      

        public IActionResult ShowOneProductJson(int id)
        {
            ProductsDataAccessObject product = new ProductsDataAccessObject();

            return Json(product.GetProductDetails(id));
        }


        //Show the form to edit
        public IActionResult Edit(int id)
        {

            ProductsDataAccessObject product = new ProductsDataAccessObject();

            return View("ShowEditForm",product.GetProductDetails(id));
        }


        //Now Edit
        public IActionResult ProcessEdit(ProductModel product)
        {
            ProductsDataAccessObject products = new ProductsDataAccessObject();
            products.Update(product);
            return View("Index", products.GetAllProducts());
        }


        //Delete product
        
        public IActionResult Delete(int id)
        {
            ProductsDataAccessObject products = new ProductsDataAccessObject();
           
            products.Delete(id);
            return View("Index", products.GetAllProducts());
        }

        //Show form to create
        public IActionResult Create()
        {
            return View();
        }


        //Create product
      
        public IActionResult ProcessCreate(ProductModel product)
        {
            ProductsDataAccessObject products = new ProductsDataAccessObject();
            products.CreateProduct(product);
            return View("Index", products.GetAllProducts());
        }
        */
    }
}
