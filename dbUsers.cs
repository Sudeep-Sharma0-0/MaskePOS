using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskePOS
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
            SqlConnection conn = GetConnection();

            if (user == null)
            {
                throw new ArgumentNullException("user");
            }
            string query = "INSERT INTO users_table (userid, username, userpass) VALUES (user.Id, user.Name, user.Password)";
            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully added user: ", user.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding new user: \n", ex.Message);
            }
        }

        public static void SearchUser(string userId)
        {
            SqlConnection conn = GetConnection();
            
            if (userId == null)
            {
                throw new ArgumentNullException("username");
            }
            string query = "SELECT * FROM users_table WHERE username=username";
            SqlCommand cmd = new SqlCommand(query, conn);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string id = reader.GetString(reader.GetOrdinal("userid"));
                        if (id == userId)
                        {
                            string username = reader.GetString(reader.GetOrdinal("username"));
                            string userpass = reader.GetString(reader.GetOrdinal("userpass"));
                            MessageBox.Show($"UserId: {id}, Username: {username}, Password: {userpass}");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No user found with the specified username.");
                }
            }
        }
    }
}
