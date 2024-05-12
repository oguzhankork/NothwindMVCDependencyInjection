using Microsoft.AspNetCore.Mvc;
using NothwindMVCDependencyInjection.Models;
using NothwindMVCDependencyInjection.Repostories.Abstracts;

namespace NothwindMVCDependencyInjection.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
                _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var categories= _categoryService.GetCategories();
            return View(categories);
        }

        public IActionResult Create(Category category)
        {
            _categoryService.CreateCategory(category);
            return View();
        }

    }
}
