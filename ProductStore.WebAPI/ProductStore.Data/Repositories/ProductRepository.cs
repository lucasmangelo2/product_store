using ProductStore.Data.Interfaces;
using ProductStore.Data.Interfaces.Repositories;
using ProductStore.Model;

namespace ProductStore.Data.Repositories
{
    public class ProductRepository : Repository<Product, IDbContext>, IProductRepository
    {
        public ProductRepository(IDbContext context) : base(context)
        {
        }
    }
}
