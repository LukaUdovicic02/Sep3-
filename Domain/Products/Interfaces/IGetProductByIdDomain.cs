using Entity;

namespace Domain.Products.Interfaces
{
    public interface IGetProductByIdDomain
    {
        Product Execute(int productId);
    }
}