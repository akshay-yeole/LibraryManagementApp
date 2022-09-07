using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.DataRepository.Contracts
{
    public interface ICategoryData
    {
        IEnumerable<Category> GetAllCategories();
    }
}
