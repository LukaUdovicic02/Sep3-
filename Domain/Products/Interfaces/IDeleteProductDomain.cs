using Entity;

namespace Domain.Products.Interfaces
{
    public interface IDeleteProductDomain
    {
        void DeleteProduct(int productId);
    }
}