using LibraryManagement.BusinessRepository.Contracts;
using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookBusiness bookContext;
        private readonly ICatgeoryBusiness catgeoryContext;

        public BooksController(IBookBusiness _bookContext, ICatgeoryBusiness _catgeoryContext)
        {
            bookContext= _bookContext;
            catgeoryContext = _catgeoryContext;
        }
        public IActionResult GetAllBooks()
        {
            var books = bookContext.GetAllBooks();
            return View(books);
        }

        public IActionResult CreateBook()
        {
            List<Category> allCategories = catgeoryContext.GetAllCategories().ToList();
            ViewData["allCategories"] = allCategories;
            return View();
        }

        [HttpPost]
        public IActionResult CreateBook(Book book)
        {
            bookContext.CreateBook(book);
            return RedirectToAction("GetAllBooks");
        }
    }
}
