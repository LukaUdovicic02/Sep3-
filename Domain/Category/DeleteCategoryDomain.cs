using Domain.Interfaces;

namespace Domain
{
    public class DeleteCategoryDomain : IDeleteCategoryDomain
    {
        private readonly ICategoryRepo _repo;

        public void Delete(int categoryId)
        {
            _repo.RemoveCategory(categoryId);
        }

        public DeleteCategoryDomain(ICategoryRepo repo)
        {
            _repo = repo;
        }
    }

  
}