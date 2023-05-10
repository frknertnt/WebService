using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebServiceApp.entities;

namespace WebServiceApp.context
{
    public class DatabaseLogicLayer:IDisposable
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        int returnvalue;
        OutputType outputType;

        public DatabaseLogicLayer()
        {
            con = new SqlConnection("server=DESKTOP-GMK1DNE\\SQLEXPRESS; database=WebService; user id =sa; password =123;");
        }
        public void Connection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else
                con.Close();
        }
        public OutputType AddProduct(Product product)
        {
            cmd = new SqlCommand("insert into Product values (@Identify,@Description,@Explanation,@Stock)", con);
            cmd.Parameters.AddWithValue("@Identify", product.Identify);
            cmd.Parameters.AddWithValue("@Description", product.Description);
            cmd.Parameters.AddWithValue("@Explanation", product.Explanation);
            cmd.Parameters.AddWithValue("@Stock", product.Stock);

            Connection();

            outputType = cmd.ExecuteNonQuery() > 0 ? OutputType.TransactionSuccessfull : OutputType.TransactionFailed;

            Connection();

            return outputType;
        }
        public OutputType ProducttIdentityControl(string productIdentity)
        {
            cmd = new SqlCommand("select count(1) from Product where Identify = (@Identify)", con);
            cmd.Parameters.AddWithValue("@Identify", productIdentity);

            Connection();

            outputType = ((int)cmd.ExecuteScalar()) > 0 ? OutputType.RegisteredProduct : OutputType.NewProduct;

            Connection();

            return outputType;
        }

        public OutputType EditProduct(Product product)
        {
            cmd = new SqlCommand(@"
update Product 
set Description = @Description,
Explanation = @Explanation,
Stock = @Stock where Identify = @Identify", con);
            cmd.Parameters.AddWithValue("@Identify", product.Identify);
            cmd.Parameters.AddWithValue("@Description", product.Description);
            cmd.Parameters.AddWithValue("@Explanation", product.Explanation);
            cmd.Parameters.AddWithValue("@Stock", product.Stock);

            Connection();
            outputType = cmd.ExecuteNonQuery() > 0 ? OutputType.TransactionSuccessfull : OutputType.TransactionFailed;
            return outputType;
        }
        public OutputType DeleteProduct(string productIdentity)
        {
            cmd = new SqlCommand("delete Product where Identify = (@Identify)", con);
            cmd.Parameters.AddWithValue("@Identify", productIdentity);

            Connection();

            outputType = cmd.ExecuteNonQuery() > 0 ? OutputType.TransactionSuccessfull : OutputType.TransactionFailed;

            Connection();

            return outputType;
        }
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            cmd = new SqlCommand("select * from Product", con);

            Connection();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                products.Add(new Product()
                {
                    ID = reader.IsDBNull(0) ? -1 : reader.GetInt32(0),
                    Identify = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    Description = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    Explanation = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                    Stock = reader.IsDBNull(3) ? -1 : reader.GetInt32(3),

                });
            }
            reader.Close();
            Connection();
            return products;
        }
        public Product GetProductsByID(string productIdentity)
        {
            Product foundproduct = null;
            cmd = new SqlCommand("select * from Product where Identify = @Identify", con);
            cmd.Parameters.AddWithValue("@Identify", productIdentity);
            Connection();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                foundproduct = new Product()
                {
                    ID = reader.IsDBNull(0) ? -1 : reader.GetInt32(0),
                    Identify = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    Description = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    Explanation = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                    Stock = reader.IsDBNull(3) ? -1 : reader.GetInt32(3),

                };
            }
            reader.Close();
            Connection();
            return foundproduct;
        }

        public void Dispose()//Bu nesneyi ben bellekten using blokları arasından çıktıktan sonra düşür
        {
            GC.SuppressFinalize(this);
        }
    }
}