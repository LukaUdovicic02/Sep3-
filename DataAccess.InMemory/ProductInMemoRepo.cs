using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Products.Interfaces;
using Entity;

namespace DataAccess.InMemory
{
    public class ProductInMemoRepo : IProductRepo
    {
        private List<Product> _products;

        public ProductInMemoRepo()
        {
            _products = new List<Product>()
            {
                new Product { ProductId = 1, CategoryId = 1, Name = "Apple" , Quantity = 100 , Price = 4.99 },
                new Product { ProductId = 2, CategoryId = 1, Name = "Banana" , Quantity = 150 , Price = 2.99 }
            };
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }

        public void AddProduct(Product product)
        {
            if (_products.Any(x => x.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase))) return;
            if (_products != null && _products.Count > 0)
            {
                var maxId = _products.Max(x => x.ProductId);
                product.ProductId = maxId + 1;
            }
            else product.ProductId = 1;

            _products.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            var productToChange = _products?.FirstOrDefault(x => x.ProductId == product.ProductId);
            if (productToChange != null)
            {
                productToChange.Name = product.Name;
                productToChange.CategoryId = product.CategoryId;
                productToChange.Price = product.Price;
                productToChange.Quantity = product.Quantity;
                
            }
        }
        
        public Product GetProductById(int productId)
        {
            return _products?.FirstOrDefault(x => x.ProductId == productId);
        }

        public void DeleteProduct(int productId)
        {
            var toDelete = GetProductById(productId);

            if (toDelete != null)
            {
                _products.Remove(toDelete);
            }
        }
    }
}