using AutoMapper;
using ProductStore.Business.Interfaces;
using ProductStore.Model;
using ProductStore.WebAPI.Request;
using ProductStore.WebAPI.Response;

namespace ProductStore.WebAPI.Controllers
{
    public class ProductController : BaseCRUDController<IProductBusiness, Product, ProductRequest, ProductResponse>
    {
        public ProductController(IProductBusiness business, IMapper mapper) : base(business, mapper)
        {
        }
    }
}
