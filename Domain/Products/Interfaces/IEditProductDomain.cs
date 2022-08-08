using Entity;

namespace Domain.Category.Interfaces
{
    public interface IEditProductDomain
    {
        void Execute(Product product);
    }
}