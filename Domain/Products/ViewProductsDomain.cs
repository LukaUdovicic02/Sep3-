using System.Collections.Generic;
using Domain.Products.Interfaces;
using Entity;

namespace Domain.Products
{
    public class ViewProductDomain : IViewProductDomain
    {
        private readonly IProductRepo _productRepo;

        public ViewProductDomain(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }
        public IEnumerable<Product> Run()
        {
            return _productRepo.GetAllProducts();
        }
    }
}