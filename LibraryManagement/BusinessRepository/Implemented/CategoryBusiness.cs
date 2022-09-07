using LibraryManagement.BusinessRepository.Contracts;
using LibraryManagement.DataRepository.Contracts;
using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.BusinessRepository.Implemented
{
    public class CategoryBusiness : ICatgeoryBusiness
    {
        private readonly ICategoryData categoryData;

        public CategoryBusiness(ICategoryData _categoryData)
        {
            categoryData = _categoryData;
        }
        public IEnumerable<Category> GetAllCategories()
        {
            return categoryData.GetAllCategories();
        }
    }
}
