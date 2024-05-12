using NothwindMVCDependencyInjection.Models;

namespace NothwindMVCDependencyInjection.Repostories.Abstracts
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
