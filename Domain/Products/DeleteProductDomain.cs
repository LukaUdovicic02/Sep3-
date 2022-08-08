using Domain.Products.Interfaces;
using Entity;

namespace Domain.Products
{
    public class DeleteProductDomain : IDeleteProductDomain
    {
        private readonly IProductRepo _repo;

        public void DeleteProduct(int productId)
        {
            _repo.DeleteProduct(productId);
        }

        public DeleteProductDomain(IProductRepo repo)
        {
            _repo = repo;
        }
    }
}