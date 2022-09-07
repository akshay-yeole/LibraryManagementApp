using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.DataRepository.Contracts
{
    public interface IBookData
    {
        IEnumerable<Book> GetAllBooks();

        Book CreateBook(Book book);
    }
}
