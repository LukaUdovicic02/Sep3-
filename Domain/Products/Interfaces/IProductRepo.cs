using System.Collections.Generic;
using Entity;

namespace Domain.Products.Interfaces
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetAllProducts();
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        Product GetProductById(int productId);
        void DeleteProduct(int productId);

    }
}