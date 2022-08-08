using Domain.Category.Interfaces;
using Domain.Products.Interfaces;
using Entity;

namespace Domain
{
    public class EditProductDomain : IEditProductDomain
    {
        private readonly IProductRepo _repo;

        public void Execute(Product product)
        {
            _repo.UpdateProduct(product);
        }

        public EditProductDomain(IProductRepo repo)
        {
            _repo = repo;
        }
    }
}