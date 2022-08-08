using Entity;

namespace Domain.Interfaces
{
    public interface IGetCategoryByIdDomain
    {
        Entity.Category Execute(int categoryId);
    }
}