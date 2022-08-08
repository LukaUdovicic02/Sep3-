using System.Collections.Generic;
using Entity;

namespace Domain.Products.Interfaces
{
    public interface IViewProductDomain
    {
        IEnumerable<Product> Run();
    }
}