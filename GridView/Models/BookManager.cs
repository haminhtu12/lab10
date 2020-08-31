using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridView.Models
{
    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();
            books.Add(new Book { BookId = 1, Title = "Naruto", Author = "Uzumaki", CoverImage = "Assets/1.jpg" });
            books.Add(new Book { BookId = 2, Title = "Itachi ", Author = "Uchiha", CoverImage = "Assets/2.jpg" });
            books.Add(new Book { BookId = 3, Title = "Kakashi ", Author = "",  CoverImage = "Assets/3.jpg" });
            return books;
        }

    }
}
