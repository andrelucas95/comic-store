using System.Linq;
using System.Threading.Tasks;
using ComicStore.Catalog.Domain;
using ComicStore.Core.Data;
using Microsoft.EntityFrameworkCore;

namespace ComicStore.Catalog.Data
{
    public class CatalogDbContext : DbContext, IUnitOfWork
    {
        public CatalogDbContext(DbContextOptions<CatalogDbContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetMaxLength(100);


            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CatalogDbContext).Assembly);
        }

        public async Task<bool> Commit()
        {
            return await base.SaveChangesAsync() > 0;
        }
    }
}