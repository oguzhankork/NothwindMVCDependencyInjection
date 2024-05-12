using NothwindMVCDependencyInjection.Models;
using NothwindMVCDependencyInjection.Repostories.Abstracts;

namespace NothwindMVCDependencyInjection.Repostories.Concretes
{
    public class SupplierService : ISupplierService
    {
        NorthwndContext northwndContext=new NorthwndContext();
        public List<Supplier> GetSuppliers()
        {
            return northwndContext.Suppliers.ToList();
        }
    }
}
