using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "mongodb://localhost:27017";

            var client = new MongoClient(connectionString);

            var database = client.GetDatabase("books");

            var books = database.GetCollection<Book>("books");

            var book = new Book();

            book.Title = "Harry Potter 2";
            book.YearPublished = 2005;
            books.InsertOne(book);

            var firstBook = books.Find(b => b.Title == "Harry Potter 2").First();

            Console.WriteLine($"book title: {firstBook.Title}, year published: {firstBook.YearPublished}");
            Console.Read();
        }
    }
}
