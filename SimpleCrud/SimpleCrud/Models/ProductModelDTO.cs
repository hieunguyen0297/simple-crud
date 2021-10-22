using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCrud.Models
{
    public class ProductModelDTO
    {
        public int Id { get; set; }

        [DisplayName("Product Name")]
        public string Name { get; set; }

        //add $ in front for each price
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public string PriceString { get; set; }


        public string Description { get; set; }

        public string ShortDescription { get; set; }

        public decimal Tax { get; set; }

        //make a constructor
        public ProductModelDTO(int id, string name, decimal price, string description)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;

            PriceString = string.Format($"${price}");
            ShortDescription = description.Length <= 25 ? description : description.Substring(0, 25);
            Tax = price * 0.08M;
        }


        //alternative format
        //take in model
        //either one work 
        
        public ProductModelDTO(ProductModel p)
        {
            Id = p.Id;
            Name = p.Name;
            Price = p.Price;
            Description = p.Description;

            PriceString = string.Format($"${p.Price}");
            ShortDescription = p.Description.Length <= 25 ? p.Description : p.Description.Substring(0, 25);
            Tax = p.Price * 0.08M;
        }
        
    }
}
