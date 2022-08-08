using System.Collections.Generic;
using Domain.Interfaces;
using Entity;

namespace Domain
{
    public class ViewCategoriesDomain : IViewCategoriesDomain
    {
        private readonly ICategoryRepo _categoryRepo;

        public ViewCategoriesDomain(ICategoryRepo categoryRepo)
        {
           _categoryRepo = categoryRepo;
        }
        public IEnumerable<Entity.Category> Execute()
        {
            return _categoryRepo.GetCategories();
        }
    }
    
}