using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductStore.Business.Interfaces.Base
{
    public interface IBusiness<TModel> where TModel: class
    {
        Task<List<TModel>> GetAllAsync();

        Task<TModel> GetByIdAsync(int id);
        Task<TModel> InsertAsync(TModel model);
        Task<TModel> UpdateAsync(TModel model);
        Task<bool> DeleteAsync(int id);
    }
}
