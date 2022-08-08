using Entity;

namespace Domain
{
    public interface IAddCategoryDomain
    {
         void Execute(Entity.Category category);
    }
}