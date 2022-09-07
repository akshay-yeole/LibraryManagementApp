using LibraryManagement.DataContext;
using LibraryManagement.DataRepository.Contracts;
using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.DataRepository.Implemented
{
    public class CategoryData : ICategoryData
    {
        private readonly AppDataContext dataContext;

        public CategoryData(AppDataContext _dataContext)
        {
            dataContext = _dataContext;
        }
        public IEnumerable<Category> GetAllCategories()
        {
            return dataContext.Categories.ToList();
        }
    }
}
