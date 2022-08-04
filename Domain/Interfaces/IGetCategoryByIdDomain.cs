using Entity;

namespace Domain.Interfaces
{
    public interface IGetCategoryByIdDomain
    {
        Category Execute(int categoryId);
    }
}