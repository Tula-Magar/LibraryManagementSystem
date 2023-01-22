using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class BookManagementSystem
    {
        private string _ISBN { get; set; }
        
        public string ISBN
        {
            get { return _ISBN; }
            set { _ISBN = value; }
        }
       
        
        private string _Title { get; set; }

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        private string _AuthorID { get; set; }

        public string AuthorID
        {
            get { return _AuthorID; }
            set { _AuthorID = value; }
        }

        private string _PublisherID { get; set; }

        public string PublisherID
        {
            get { return _PublisherID; }
            set { _PublisherID = value; }
        }

        private DateTime _PublicationYear { get; set; }

        public DateTime PublicationYear
        {
            get { return _PublicationYear; }
            set { _PublicationYear = value; }
        }
        
        private int _Pages { get; set; }
        
        public int Pages
        {
            get { return _Pages; }
            set { _Pages = value; }
        }
        
        public string GetAuthor()
        {
            return AuthorID.ToString();
        }
        public string GetPublisher()
        {
            return PublisherID.ToString();
        } 

        public bool AddBook()
        {
            // Code to add the book to the database
            // Return true if the book was added successfully, otherwise false
            return true;
        }

        public bool UpdateBook()
        {
            // Code to update the book in the database
            // Return true if the book was updated successfully, otherwise false
            return true;
        }

        public bool DeleteBook()
        {
            // Code to delete the book from the database
            // Return true if the book was deleted successfully, otherwise false
            return true;
        }

        private bool IsValid()
        {
            // Code to validate the properties of the book object
            // Return true if the book object is valid, otherwise false
            return true;
        }
    }
    class Author
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfDeath { get; set; }
        public List<string> Books { get; set; }

        

        public bool AddAuthor()
        {
            // Code to add the author to the database
            // Return true if the author was added successfully, otherwise false
            return true;
        }

        public bool UpdateAuthor()
        {
            // Code to update the author in the database
            // Return true if the author was updated successfully, otherwise false
            return true;
        }

        public bool DeleteAuthor()
        {
            // Code to delete the author from the database
            // Return true if the author was deleted successfully, otherwise false
            return true;
        }

        private bool IsValid()
        {
            // Code to validate the properties of the author object
            // Return true if the author object is valid, otherwise false
            return true;
        }
    }

    class Publisher
    {
        public int PublisherID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public List<string> Books { get; set; }

        public bool AddPublisher()
        {
            // Code to add the publisher to the database
            // Return true if the publisher was added successfully, otherwise false
            return true;
        }

        public bool UpdatePublisher()
        {
            // Code to update the publisher in the database
            // Return true if the publisher was updated successfully, otherwise false
            return true;
        }
        
        public bool DeletePublisher()
        {
            // Code to delete the publisher from the database
            // Return true if the publisher was deleted successfully, otherwise false
            return true;
        }

        private bool IsValid()
        {
            // Code to validate the properties of the publisher object
            // Return true if the publisher object is valid, otherwise false
            return true;
        }
    }
}