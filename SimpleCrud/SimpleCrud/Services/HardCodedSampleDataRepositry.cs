using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using SimpleCrud.Models;

namespace SimpleCrud.Services
{
    //static will keep data the same if there are any refresh
    public class HardCodedSampleDataRepositry
    {
        static List<ProductModel> products = new List<ProductModel>();

        //Get all products from the list
        public List<ProductModel> GetAllProductsFromList()
        {
            if(products.Count == 0)
            {
                products.Add(new ProductModel() { Id = 1, Name = "Mouse Pad", Price = 5.88m, Description = "A square piece of plastic to make mousing easier" });
                products.Add(new ProductModel() { Id = 2, Name = "Web Cam", Price = 20.48m, Description = "Enables you to attend more Zoom meetings" });
                products.Add(new ProductModel() { Id = 3, Name = "Hard Drive", Price = 10.58m, Description = "Back up all your work, you won't regret it" });
                products.Add(new ProductModel() { Id = 4, Name = "Wireless Mouse", Price = 15.98m, Description = "You don't have to connect to your computer using cable" });

                //generate fake data using Bogus package 
                for (int i = 5; i < 21; i++)
                {
                    products.Add(new Faker<ProductModel>()
                        .RuleFor(p => p.Id, i)
                        .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                        .RuleFor(p => p.Price, f => f.Random.Decimal(50))
                        .RuleFor(p => p.Description, f => f.Rant.Review())

                        );
                }
            }
            

            return products;
        }


    }
}
