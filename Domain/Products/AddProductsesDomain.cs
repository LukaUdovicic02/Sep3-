using Domain.Products.Interfaces;
using Entity;

namespace Domain.Products
{
    public class AddProductsesDomain : IAddProductsDomain
    {
        private readonly IProductRepo _repo;

        public AddProductsesDomain(IProductRepo repo)
        {
            _repo = repo;
        }

        public void Run(Product product)
        {
            _repo.AddProduct(product);
        }
    }
}