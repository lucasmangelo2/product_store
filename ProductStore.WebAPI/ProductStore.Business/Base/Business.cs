using ProductStore.Business.Interfaces.Base;
using ProductStore.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductStore.Business.Base
{
    public class Business<TModel, TRepository> : IBusiness<TModel>
        where TModel : class
        where TRepository : IRepository<TModel>

    {
        protected readonly TRepository _repository;

        public Business(TRepository repository)
        {
            _repository = repository;
        }

        public async virtual Task<bool> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async virtual Task<List<TModel>> GetAllAsync()
        {
            return (await _repository.GetAllAsync()).ToList();
        }

        public async virtual Task<TModel> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async virtual Task<TModel> InsertAsync(TModel model)
        {
            return await _repository.InsertAsync(model);
        }

        public async virtual Task<TModel> UpdateAsync(TModel model)
        {
            return await _repository.UpdateAsync(model);
        }
    }
}
