using NothwindMVCDependencyInjection.Models;

namespace NothwindMVCDependencyInjection.Repostories.Abstracts
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        public void CreateCategory(Category category);
    }
}
