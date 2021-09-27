using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using SimpleCrud.Models;

namespace SimpleCrud.Services
{
    public class ProductsDataAccessObject
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //Get all products from the list
        public List<ProductModel> GetAllProducts()
        {
            //Start off as an empty list
            List<ProductModel> products = new List<ProductModel>();

            //Make SQL statement and connection to get data from database

            string sqlStatement = "Select * from Products";

            //Make a connection to get data from database

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Create command or make a query to the database
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        products.Add(new ProductModel { Id = (int)reader[0], Name = (string)reader[1], Price = (decimal)reader[2], Description = (string)reader[3] });
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

            return products;
        }
    }
}
