using LibraryManagement.BusinessRepository.Contracts;
using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICatgeoryBusiness catgeoryContext;

        public CategoriesController(ICatgeoryBusiness _catgeoryContext)
        {
            catgeoryContext = _catgeoryContext;
        }
        public IActionResult GetAllCategories()
        {
            var categories = catgeoryContext.GetAllCategories();
            return View(categories);
        }
    }
}
