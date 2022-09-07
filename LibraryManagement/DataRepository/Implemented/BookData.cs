using LibraryManagement.DataContext;
using LibraryManagement.DataRepository.Contracts;
using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.DataRepository.Implemented
{
    public class BookData : IBookData
    {
        private readonly AppDataContext dataContext;

        public BookData(AppDataContext _dataContext)
        {
            dataContext = _dataContext;
        }

        public Book CreateBook(Book book)
        {
            dataContext.Books.Add(book);
            dataContext.SaveChanges();
            return book;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return dataContext.Books.ToList();
        }
    }
}
