using System.Collections.Generic;
using Entity;

namespace Domain.Interfaces
{
    public interface ICategoryRepo
    {
        IEnumerable<Category> GetCategories();
        void AddCategory(Category category);
        void UpdateCategory(Category category);

        Category GetCategoryById(int categoryId);
    }
}