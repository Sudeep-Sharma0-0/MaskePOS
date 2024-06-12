using MaskeyPOS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskePOS
{
    class dbProducts
    {
        public static SqlConnection GetConnection()
        {
            string dbStr = "Data Source=DESKTOP-58J0S0K;Initial Catalog=maskeyDb; Integrated Security=True";

            SqlConnection conn = new SqlConnection(dbStr);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error connecting to SQL server: \n");
            }
            return conn;
        }

        public static void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            using (SqlConnection conn = GetConnection())
            {
                string query = "INSERT INTO products_table (name, price, desc, image) VALUES (@Name, @Price, @Desc, @Image)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", product.Name);
                    cmd.Parameters.AddWithValue("@Price", product.Price);
                    cmd.Parameters.AddWithValue("@Desc", product.Desc);
                    cmd.Parameters.AddWithValue("@Image", product.Image);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Successfully added product: {product.Name}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error adding new product: \n {ex.Message}");
                    }
                }
            }
        }

        public static Product SearhProduct(int id)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT id, name, price, desc, image FROM products_table WHERE id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Product(
                                    reader["id"].ToString(),
                                    reader["name"].ToString(),
                                    reader.GetDecimal(reader.GetOrdinal("price")),
                                    reader["desc"].ToString(),
                                    reader["image"].ToString()
                                );
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error retrieving product: {ex.Message}");
                        return null;
                    }
                }
            }
        }

        public static void UpdateProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            using (SqlConnection conn = GetConnection())
            {
                string query = "UPDATE products_table SET name = @Name, price = @Price, desc = @Desc, image = @Image WHERE id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", product.Id);
                    cmd.Parameters.AddWithValue("@Name", product.Name);
                    cmd.Parameters.AddWithValue("@Price", product.Price);
                    cmd.Parameters.AddWithValue("@Desc", product.Desc);
                    cmd.Parameters.AddWithValue("@Image", product.Image);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating product: {ex.Message}");
                    }
                }
            }
        }

        public static void DeleteProduct(int id)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "DELETE FROM products_table WHERE id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting product: {ex.Message}");
                    }
                }
            }
        }

        public static async Task<List<Product>> GetAllProductsAsync(int pageNumber, int pageSize)
        {
            List<Product> products = new List<Product>();

            using (SqlConnection conn = GetConnection())
            {
                string query = @"
                    SELECT id, name, price, desc, image 
                    FROM products_table 
                    ORDER BY id 
                    OFFSET @Offset ROWS 
                    FETCH NEXT @PageSize ROWS ONLY";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Offset", (pageNumber - 1) * pageSize);
                    cmd.Parameters.AddWithValue("@PageSize", pageSize);

                    try
                    {
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                products.Add(new Product(
                                    reader["id"].ToString(),
                                    reader["name"].ToString(),
                                    reader.GetDecimal(reader.GetOrdinal("price")),
                                    reader["desc"].ToString(),
                                    reader["image"].ToString()
                                ));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error retrieving products: {ex.Message}");
                    }
                }
            }
            return products;
        }
    }
}