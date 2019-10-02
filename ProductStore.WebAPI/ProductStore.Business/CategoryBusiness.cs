using ProductStore.Business.Base;
using ProductStore.Business.Interfaces;
using ProductStore.Data.Interfaces.Repositories;
using ProductStore.Model;

namespace ProductStore.Business
{
    public class CategoryBusiness : Business<Category, ICategoryRepository>, ICategoryBusiness
    {
        public CategoryBusiness(ICategoryRepository repository) : base(repository)
        {
        }
    }
}
