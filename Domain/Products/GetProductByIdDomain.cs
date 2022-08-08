using Domain.Products.Interfaces;
using Entity;

namespace Domain
{
    public class GetProductByIdDomain : IGetProductByIdDomain
    {
        private readonly IProductRepo _productRepo;

        public Product Execute(int productId)
        {
          return _productRepo.GetProductById(productId);
        }
        
        public GetProductByIdDomain(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }
    }
}