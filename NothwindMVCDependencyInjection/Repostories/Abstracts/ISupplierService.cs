using NothwindMVCDependencyInjection.Models;

namespace NothwindMVCDependencyInjection.Repostories.Abstracts
{
    public interface ISupplierService
    {
        List<Supplier> GetSuppliers();
    }
}
