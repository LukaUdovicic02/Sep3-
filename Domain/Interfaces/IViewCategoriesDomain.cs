using System.Collections.Generic;
using Entity;

namespace Domain.Interfaces
{
    public interface IViewCategoriesDomain
    {
        IEnumerable<Category> Execute();
    }
}