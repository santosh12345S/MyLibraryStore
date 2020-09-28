using MyLibraryStore.Data;
using MyLibraryStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MyLibraryStore.Repository
{
    public class BookRepository : IBookRepository
    {
        private ApplicationDbContext _dbContext=null;
        public BookRepository(ApplicationDbContext applicationDb)
        {
            _dbContext = applicationDb;
        }
        public Book GetBookById(int id)
        {
            return _dbContext.Books.FirstOrDefault(z => z.Id == id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return _dbContext.Books.ToList();
        }

         public void CreateBook(Book book)
        {
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
        }


        public void EditBook(int id,Book book)
        {
            var note = _dbContext.Books.SingleOrDefault(d => d.Id == id);

            note.BookName = book.BookName;
            note.Author = book.Author;
            note.ISBN = book.ISBN;
            note.PublishDate = book.PublishDate;
            note.Genre = book.Genre;
            _dbContext.SaveChanges();
        }


        public void DeleteBook(int id)
        {
            var book = _dbContext.Books.FirstOrDefault(x => x.Id == id);
            _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();
        }
    }
}
