using MyLibraryStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibraryStore.Repository
{
    public class MockBookRepository : IBookRepository
    {
        public void CreateBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        public void EditBook(int id, Book book)
        {
            throw new NotImplementedException();
        }

        public Book GetBookById(int id)
        {
            var books = GetBooks();

            return books.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book{Id=1,BookName="Maths",ISBN="12341",Author="Siddhu",PublishDate=new DateTime(2020,12,12)},
                new Book{Id=2,BookName="Physics",ISBN="12342",Author="Mukesh",PublishDate=new DateTime(2019,12,12)},
                new Book{Id=3,BookName="Chemistry",ISBN="12345",Author="Chandra",PublishDate=new DateTime(2018,12,12)},

            };
        }
    }
}
