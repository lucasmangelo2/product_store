using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Data.Interfaces
{
    public interface IRepository<TModel> where TModel : class
    {
        Task<IQueryable<TModel>> GetAllAsync();

        Task<TModel> GetByIdAsync(int id);
        Task<TModel> InsertAsync(TModel model);
        Task<TModel> UpdateAsync(TModel model);
        Task<bool> DeleteAsync(int id);
    }
}
