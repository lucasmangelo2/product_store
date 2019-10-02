using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using ProductStore.Data.Interfaces;
using ProductStore.Model;
using System.Linq;

namespace ProductStore.Data.Context
{
    public class ProductStoreContext : DbContext, IDbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Document> Document { get; set; }

        public ProductStoreContext(DbContextOptions<ProductStoreContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelBuilder);
        }


    }
}
