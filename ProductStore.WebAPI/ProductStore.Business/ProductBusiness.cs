using ProductStore.Business.Base;
using ProductStore.Business.Interfaces;
using ProductStore.Data.Interfaces.Repositories;
using ProductStore.Model;

namespace ProductStore.Business
{
    public class ProductBusiness : Business<Product, IProductRepository>, IProductBusiness
    {
        public ProductBusiness(IProductRepository repository) : base(repository)
        {
        }
    }
}
