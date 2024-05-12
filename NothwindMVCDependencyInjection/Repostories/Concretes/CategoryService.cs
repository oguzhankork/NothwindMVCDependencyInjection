using NothwindMVCDependencyInjection.Models;
using NothwindMVCDependencyInjection.Repostories.Abstracts;

namespace NothwindMVCDependencyInjection.Repostories.Concretes
{
    public class CategoryService : ICategoryService
    {
        NorthwndContext _northwndContext= new NorthwndContext();
        public void CreateCategory(Category category)
        {
            _northwndContext.Categories.Add(category);
        }

        public List<Category> GetCategories()
        {
            return _northwndContext.Categories.ToList();
        }
    }
}
