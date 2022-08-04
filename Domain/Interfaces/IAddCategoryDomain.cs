using Entity;

namespace Domain
{
    public interface IAddCategoryDomain
    {
         void Execute(Category category);
    }
}