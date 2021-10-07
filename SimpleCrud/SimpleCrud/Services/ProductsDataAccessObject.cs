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

            //Make SQL statement

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






        //Search products by Name
        public List<ProductModel> SearchProductByName(string searchTerm)
        {
            //Found products will be store here for return later
            List<ProductModel> products = new List<ProductModel>();
            
           
            //Make SQL statement
            string sqlStatement = "select * from Products where product_name like @Name";

            //Make a connection to get data from database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Make command 
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                
                //The @Name is corresponding to @Name in the sql statement 
                command.Parameters.AddWithValue("@Name", '%' + searchTerm + '%');

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while(reader.Read())
                    {
                        products.Add(new ProductModel { Id = (int)reader[0], Name = (string)reader[1], Price = (decimal)reader[2], Description = (string)reader[3] });
                    }

                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

            return products;

        }

        //Get one product from the database. Product details
        public ProductModel GetProductDetails(int id)
        {
            ProductModel product = null;

            //Make a sql Statement
            string sqlStatement = "select * from Products where product_id = @Id";

            //Make a connection
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                //Make command 
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@Id", id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        product = new ProductModel { Id = (int)reader[0], Name = (string)reader[1], Price = (decimal)reader[2], Description = (string)reader[3] };
                    }

                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return product;
        }


        //Update a product
        public int Update(ProductModel product)
        {
            int newIdNumber = -1;
            string sqlStatement = "update products SET product_name = @Name, price = @Price, description = @Des where product_id = @Id";

            //Make a connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Make command 
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@Des", product.Description);
                command.Parameters.AddWithValue("@Id", product.Id);

                try
                {
                    connection.Open();
                    newIdNumber = Convert.ToInt32( command.ExecuteScalar());
                    

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

            return newIdNumber;
        }

        //Delete a product
        //We can use the ProductModel as parameter, and then delete using product.Id
        //ALWAYS RETURN SOMETHING
        //Here, we return the id of the product that was deleted
        //Use command.ExecuteScalar()
        //Alternative to Convert into int32 -- (int32) command.ExecuteScalar()
        public int Delete(int id)
        {
            int newIdNumber = -1;
            string sqlStatement = "delete from products where product_id = @Id";

            //Make a connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Make command 
                SqlCommand command = new SqlCommand(sqlStatement, connection);
             
                command.Parameters.AddWithValue("@Id", id);

                try
                {
                    connection.Open();
                    newIdNumber = Convert.ToInt32(command.ExecuteScalar());
                   

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

            return newIdNumber;
        }


        //Create product
        public int CreateProduct(ProductModel product)
        {
            //return an int
            int newProductId = -1;

            //Make a sql statement
            string sqlStatement = "Insert into products (product_name, price, description) values  (@Name, @Price, @Description)";

            //Making a connection
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                //Make a sql command 
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@Description", product.Description);

                try
                {
                    connection.Open();
                    newProductId = Convert.ToInt32(command.ExecuteScalar());

                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }


            return newProductId;
        }
    }
}
