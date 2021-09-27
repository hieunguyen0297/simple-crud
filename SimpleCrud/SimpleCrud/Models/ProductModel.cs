using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCrud.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        [DisplayName("Product Name")]
        public string Name { get; set; }

        //add $ in front for each price
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public string Description { get; set; }


    }
}
