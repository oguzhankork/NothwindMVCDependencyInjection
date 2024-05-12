using Microsoft.AspNetCore.Mvc;
using NothwindMVCDependencyInjection.Models;
using NothwindMVCDependencyInjection.Repostories.Abstracts;

namespace NothwindMVCDependencyInjection.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _product;

        public ProductController(IProductService product)
        {
            _product = product;
        }
        public IActionResult Index()
        {
            var products=_product.GetProducts();
            return View(products);
        }
    }
}
