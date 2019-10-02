using Microsoft.EntityFrameworkCore;

namespace ProductStore.Data.Interfaces
{
    public interface IDbContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        int SaveChanges();
    }
}
