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
    [Route("api/")]
    public class ProductControllerAPI : ControllerBase
    {
        ProductsDataAccessObject products;
        public ProductControllerAPI()
        {
            products = new ProductsDataAccessObject();
        }

        //return a list of products
        [HttpGet]
        public ActionResult <IEnumerable<ProductModel>> Index()
        {
            return products.GetAllProducts();
        }
        
       

        //This method will do the search form
        //The searchTerm will correspond to the name= "searchTerm" in the SearchFrom.cshtml
        //CAN NOT use "/searchproducts"
        [HttpGet("searchproducts/{searchTerm}")]
        public ActionResult <IEnumerable<ProductModel>> SearchResult(string searchTerm)
        {
            return products.SearchProductByName(searchTerm);
        }

         
        
        
        //Return a view with one product
        //Ienumerable return an array // remove that to return a product
        //params id or ID does not matter
        [HttpGet("showoneproduct/{id}")]
        public ActionResult <ProductModel> ShowOneProduct(int id)
        {
            
            return products.GetProductDetails(id);
        }
        
        
        //Insert a product
        //Expecting a product in JSON format in the body of the request
       
        [HttpPost("insertproduct")]
        public ActionResult <int> InsertProduct(ProductModel product)
        {
            int newID = products.CreateProduct(product);
            return newID;
        }


       
        // "insert/{id}" => the id is corresponding to the int id in the method's parameter/
       
        //Now Edit ]
        //Edit a product has to take in a product model
        [HttpPut("edit")]
        public ActionResult <string> ProcessEdit(ProductModel product)
        {
            products.Update(product);
            return $"Edit product with the ID of {product.Id} was successfully";
        }
       

         
        //Delete a product
        
        [HttpDelete("delete/{id}")]
        public ActionResult <string> Delete(int id)
        {
            products.Delete(id);
            return $"Product with ID of {id} was deleted successfull";
        }

        
    }
}
