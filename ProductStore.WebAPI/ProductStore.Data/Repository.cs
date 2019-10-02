using Microsoft.EntityFrameworkCore;
using ProductStore.Data.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ProductStore.Data
{
    public class Repository<TModel, TContext> : IRepository<TModel>
        where TModel : class
        where TContext : IDbContext
    {
        protected readonly TContext _context;

        public Repository(TContext context)
        {
            _context = context;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var model = await GetByIdAsync(id);

            if (model != null)
            {
                _context.Set<TModel>().Remove(model);

                return SaveChanges();
            }

            return false;
        }

        public Task<TModel> GetByIdAsync(int id)
        {
            return Task.Run(() =>
            {
                var key = GetKeyProperty();

                if (key != null)
                {
                    return _context.Set<TModel>().FirstOrDefault(x => int.Parse(key.GetValue(x).ToString()) == id);
                }

                return null;
            });
        }

        public Task<IQueryable<TModel>> GetAllAsync()
        {
            return Task.Run(() => _context.Set<TModel>().AsNoTracking());
        }

        public async Task<TModel> InsertAsync(TModel model)
        {
            await _context.Set<TModel>().AddAsync(model);

            SaveChanges();

            return model;
        }

        public Task<TModel> UpdateAsync(TModel model)
        {
            return Task.Run(() =>
            {

                var dbSet = _context.Set<TModel>();

                dbSet.Update(model);
                (_context as DbContext).Entry(model).State = EntityState.Modified;

                SaveChanges();

                return model;
            });
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }


        private PropertyInfo GetKeyProperty()
        {
            var props = typeof(TModel).GetProperties();
            return props.FirstOrDefault(x => x.GetCustomAttribute(typeof(KeyAttribute)) != null);
        }


    }
}
