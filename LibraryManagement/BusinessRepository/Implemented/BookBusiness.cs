using LibraryManagement.BusinessRepository.Contracts;
using LibraryManagement.DataRepository.Contracts;
using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.BusinessRepository.Implemented
{
    public class BookBusiness : IBookBusiness
    {
        private readonly IBookData bookData;

        public BookBusiness(IBookData _bookData)
        {
            bookData = _bookData;
        }

        public Book CreateBook(Book book)
        {         
            return bookData.CreateBook(book);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return bookData.GetAllBooks();
        }
    }
}
