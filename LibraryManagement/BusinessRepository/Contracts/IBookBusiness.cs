using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.BusinessRepository.Contracts
{
    public interface IBookBusiness
    {
        IEnumerable<Book> GetAllBooks();

        Book CreateBook(Book book);
    }
}
