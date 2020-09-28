using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyLibraryStore.Models;
using MyLibraryStore.Repository; 

namespace MyLibraryStore.Controllers
{
    public class BooksController : Controller
    {
        private IBookRepository _bookRepository = null;

        public BooksController(IBookRepository repository)
        {
            _bookRepository = repository;
        }
        public IActionResult Index()
        {
            var books = _bookRepository.GetBooks();
            return View(books);
        }

        public IActionResult GetBookById(int id)
        {
            var book = _bookRepository.GetBookById(id);
            return View(book);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book )
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _bookRepository.CreateBook(book);

            return RedirectToAction("Index", "Books");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var book = _bookRepository.GetBookById(id);

            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(int id,Book book)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _bookRepository.EditBook(id, book);

            return RedirectToAction("Index", "Books");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _bookRepository.DeleteBook(id);

            return RedirectToAction("Index", "Books");
        }

        public void GetName()
        {

        }
    }
}
