using AutoMapper;
using ProductStore.Business.Interfaces;
using ProductStore.Model;
using ProductStore.WebAPI.Request;
using ProductStore.WebAPI.Response;

namespace ProductStore.WebAPI.Controllers
{
    public class CategoryController : BaseCRUDController<ICategoryBusiness, Category, CategoryRequest, CategoryResponse>
    {
        public CategoryController(ICategoryBusiness business, IMapper mapper) : base(business, mapper)
        {
        }
    }
}
