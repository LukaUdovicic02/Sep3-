using Entity;

namespace Domain.Interfaces
{
    public interface IEditCategoryDomain
    {
        void Execute(Entity.Category category);
    }
}