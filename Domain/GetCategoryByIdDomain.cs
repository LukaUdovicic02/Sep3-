using Domain.Interfaces;
using Entity;

namespace Domain
{
    public class GetCategoryByIdDomain : IGetCategoryByIdDomain
    {
        private readonly ICategoryRepo _categoryRepo;

        public Category Execute(int categoryId)
        {
           return _categoryRepo.GetCategoryById(categoryId);
        }

        public GetCategoryByIdDomain(ICategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }
    }
    
}