using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ProductStore.Business.Interfaces.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductStore.WebAPI.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    public class BaseCRUDController<TBusiness, TModel, TRequest, TResponse> : ControllerBase
        where TModel: class
        where TBusiness : IBusiness<TModel>
    {
        protected readonly TBusiness _business;
        protected readonly IMapper _mapper;

        public BaseCRUDController(TBusiness business, IMapper mapper)
        {
            _business = business;
            _mapper = mapper;
        }

        [HttpGet]
        public async virtual Task<IActionResult> GetAllAsync()
        {
            var list = _mapper.Map<List<TResponse>>(await _business.GetAllAsync());
            return Ok(list);
        }

        [HttpGet("{id}")]
        public async virtual Task<IActionResult> GetByIdAsync(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var obj = _mapper.Map<TResponse>(await _business.GetByIdAsync(id));
            return Ok(obj);
        }

        [HttpPost]
        public async virtual Task<IActionResult> InsertASync([FromBody] TRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var model = _mapper.Map<TModel>(request);

            var obj = _mapper.Map<TResponse>(await _business.InsertAsync(model));

            return Ok(obj);
        }

        [HttpPut]
        public async virtual Task<IActionResult> UpdateASync(int id, [FromBody] TRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var model = _mapper.Map<TModel>(request);

            var obj = _mapper.Map<TResponse>(await _business.InsertAsync(model));

            return Ok(obj);
        }

        [HttpDelete("{id}")]
        public async virtual Task<IActionResult> DeleteAsync(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(await _business.DeleteAsync(id));
        }
    }
}
