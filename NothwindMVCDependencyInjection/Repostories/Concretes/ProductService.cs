using NothwindMVCDependencyInjection.Models;
using NothwindMVCDependencyInjection.Repostories.Abstracts;

namespace NothwindMVCDependencyInjection.Repostories.Concretes
{
    public class ProductService : IProductService
    {
        NorthwndContext _northwndContext = new NorthwndContext();
        public List<Product> GetProducts()
        {
            return _northwndContext.Products.ToList();
        }
    }
}
