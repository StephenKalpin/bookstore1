using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webgentle.bookstore.Models;

namespace webgentle.bookstore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string author)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id=1,   Title="MVC",   Author="Nitish", Description="This is the desciption for MCV book", Category="Programming", Language="English", TotalPages=134 },
                new BookModel() { Id = 2, Title = "Dot net core", Author = "Nitish", Description="This is the desciption for Dot net core book", Category="Framework", Language="Chinese", TotalPages=567 },
                new BookModel() { Id = 3, Title = "C#", Author = "Monika" , Description="This is the desciption for C# book", Category="Developer", Language="Hindi", TotalPages=897 },
                new BookModel() { Id = 4, Title = "Java", Author = "WebGentle", Description="This is the desciption for Java book", Category="Concept", Language="English", TotalPages=100 },
                new BookModel() { Id = 5, Title = "PHP", Author = "WebGentle", Description="This is the desciption for PHP book", Category="DevOps", Language="English", TotalPages=800 }, 
            };
        }
    }

    
}
