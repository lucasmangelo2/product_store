using ProductStore.Data.Interfaces;
using ProductStore.Data.Interfaces.Repositories;
using ProductStore.Model;

namespace ProductStore.Data.Repositories
{
    public class CategoryRepository : Repository<Category, IDbContext>, ICategoryRepository
    {
        public CategoryRepository(IDbContext context) : base(context)
        {
        }
    }
}
