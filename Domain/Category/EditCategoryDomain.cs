using Domain.Interfaces;
using Entity;

namespace Domain
{
    public class EditCategoryDomain : IEditCategoryDomain
    {
        
        private ICategoryRepo CategoryRepo;
        
        public EditCategoryDomain(ICategoryRepo CategoryRepo)
        {
            this.CategoryRepo = CategoryRepo;
        }
        public void Execute(Entity.Category category)
        {
            CategoryRepo.UpdateCategory(category);
        }
    }
}