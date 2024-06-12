using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskeyPOS
{
    class dbUsers
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
                MessageBox.Show("Error connecting to SQL server: \n", ex.Message);
            }
            return conn;
        }

        public static void AddUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            using (SqlConnection conn = GetConnection())
            {
                string query = "INSERT INTO users_table (username, userpass) VALUES (@Name, @Password)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", user.Name);
                    cmd.Parameters.AddWithValue("@Password", user.Password);

                    try
                    {
                        int success = cmd.ExecuteNonQuery();
                        if (success > 0) 
                        {
                            MessageBox.Show($"Successfully added {user.Name}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error adding user: {ex.Message}");
                    }
                }
            }
        }

        public static User SearchUser(string id)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT id, name, password FROM users_table WHERE id = @Id";
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
                                return new User(
                                    reader["id"].ToString(),
                                    reader["username"].ToString(),
                                    reader["userpass"].ToString()
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
                        MessageBox.Show($"Error retrieving user: {ex.Message}");
                        return null;
                    }
                }
            }
        }

        public static void UpdateUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            using (SqlConnection conn = GetConnection())
            {
                string query = "UPDATE users_table SET username = @Name, userpass = @Password WHERE id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", user.Id);
                    cmd.Parameters.AddWithValue("@Name", user.Name);
                    cmd.Parameters.AddWithValue("@Password", user.Password);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating user: {ex.Message}");
                    }
                }
            }
        }

        public static void DeleteUser(int id)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "DELETE FROM users_table WHERE id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    try
                    {
                        int success = cmd.ExecuteNonQuery();
                        if (success > 0)
                        {
                            MessageBox.Show($"Successfully deleted user with id: {id}");
                        }
                        else
                        {
                            MessageBox.Show("Error deleting the user.");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting user: {ex.Message}");
                    }
                }
            }
        }
    }
}