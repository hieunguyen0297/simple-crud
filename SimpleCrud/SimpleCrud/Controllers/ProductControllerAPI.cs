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
        public ActionResult <List<ProductModelDTO>> Index()
        {
            //get all products from the ProductModel
            List<ProductModel> allProduct = products.GetAllProducts();

            //make a list of new product using ProductModelDTO
            List<ProductModelDTO> productsDTO = new List<ProductModelDTO>();
            foreach (ProductModel product in allProduct)
            {
                productsDTO.Add(new ProductModelDTO(product));
            }

            return productsDTO;
        }
        
       

        //This method will do the search form
        //The searchTerm will correspond to the name= "searchTerm" in the SearchFrom.cshtml
        //CAN NOT use "/searchproducts"
        [HttpGet("searchproducts/{searchTerm}")]

        //cant be List<T> or IEnumerable<T>
        public ActionResult <List<ProductModelDTO>> SearchResult(string searchTerm)
        {
            //get all products from the ProductModel
            List<ProductModel> matchProducts = products.SearchProductByName(searchTerm);

            //make a list of new product using ProductModelDTO
            List<ProductModelDTO> matchProductsDTO = new List<ProductModelDTO>();

            foreach (ProductModel product in matchProducts)
            {
                matchProductsDTO.Add(new ProductModelDTO(product));
            }

            return matchProductsDTO;
        }

         
        
        
        //Return a view with one product
        //Ienumerable return an array // remove that to return a product
        //params id or ID does not matter
        [HttpGet("showoneproduct/{id}")]
        public ActionResult <ProductModelDTO> ShowOneProduct(int id)
        {
            //find the product by id
            ProductModel product = products.GetProductDetails(id);

            //if use product model, just passs in the model
            ProductModelDTO productDTO = new ProductModelDTO(product.Id, product.Name, product.Price, product.Description);

            return productDTO;
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
