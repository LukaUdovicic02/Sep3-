using System.Collections.Generic;
using Entity;

namespace Domain.Interfaces
{
    public interface ICategoryRepo
    {
        IEnumerable<Entity.Category> GetCategories();
        void AddCategory(Entity.Category category);
        void UpdateCategory(Entity.Category category);

        Entity.Category GetCategoryById(int categoryId);
        void RemoveCategory(int categoryId);
    }
}