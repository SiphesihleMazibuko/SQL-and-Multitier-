using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DataLayer
{
    public class DataLayerClass
    {
        private string connectionString = "Data Source=LAPTOP-A2F1LC11\\SQLEXPRESS01;Initial Catalog=Sandile_Store;Integrated Security=True;Encrypt=False";

        public void InsertProduct( string productName, int quantity, decimal price, decimal stock)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = " INSERT INTO PRODUCTS (Name_, Quantity, Price, Stock) VALUES (\r\n @Name_, @Quantity, @Price,@Stock\r\n );";
               
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        connection.Open();
                        command.Parameters.AddWithValue("@Name_", productName);
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        command.Parameters.AddWithValue("@Price", price);
                        command.Parameters.AddWithValue("@Stock", stock);
                        command.ExecuteNonQuery();
                       

                    }
                     connection.Close();
            }
        }
        public void UpdateProduct(string productName, int quantity, decimal price, decimal stock)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE PRODUCTS SET Name_ = @Name, Quantity = @Quantity, Price = @Price, Stock = @Stock WHERE Name_ = @ProductName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", productName);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Stock", stock);
                    command.Parameters.AddWithValue("@ProductName", productName); 

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteProduct(string productName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "\r\nDELETE FROM PRODUCTS WHERE Name_ = @Name";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Name", productName);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public DataTable ShowGrid()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PRODUCTS WHERE Quantity < 5";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;


                }
            }
        }
     
    }
}
