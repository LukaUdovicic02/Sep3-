using Entity;

namespace Domain.Products.Interfaces
{
    public interface IAddProductsDomain
    {
        void Run(Product product);
    }
}