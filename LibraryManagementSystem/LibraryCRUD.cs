using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace LibraryManagementSystem
{
    interface ICRUD
    {
        void AddBook();
        void DeleteBook();
        void UpdateBook();
        void SearchBook();
    }
    class LibraryCRUD : ICRUD
    {
        public void AddBook()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.Open();
                string query = "INSERT INTO BookDetails (BookName, Author, Edition, Price, Quantity) VALUES (@BookName, @Author, @Edition, @Price, @Quantity)";

                SqlCommand cmd = new SqlCommand(query, con);
                 cmd.Parameters.AddWithValue("@BookName", txtBookName.Text);
                 cmd.Parameters.AddWithValue("@Author", txtAuthor.Text);
                 cmd.Parameters.AddWithValue("@Edition", txtEdition.Text);
                 cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
                 cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);

                cmd.ExecuteNonQuery();
                Console.WriteLine("Book Added Successfully");
            }
        }

        public void DeleteBook()
        {
            throw new NotImplementedException();
        }

        public void UpdateBook()
        {
            throw new NotImplementedException();
        }

        public void SearchBook()
        {
            throw new NotImplementedException();
        }

  

     }
}
