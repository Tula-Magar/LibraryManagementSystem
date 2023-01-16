using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\tmaga\\OneDrive\\Documents\\LibraryBookData.mdf;Integrated Security=True;Connect Timeout=30";
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string Query = "SELECT * FROM Credentials WHERE Username = @Username AND Password = @Password";

                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Successfully logged in");
                    }
                    else
                    {
                        MessageBox.Show("Incorrect");
                    }
                }
                catch (SqlException) {
                    MessageBox.Show("Incorrect Credentials");
                }

                finally { conn.Close();
                    MessageBox.Show("testing");
                }

            }
        }
    }
}