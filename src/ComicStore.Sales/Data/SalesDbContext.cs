using System.Linq;
using System.Threading.Tasks;
using ComicStore.Core.Data;
using ComicStore.Sales.Domain;
using Microsoft.EntityFrameworkCore;

namespace ComicStore.Sales.Data
{
    public class SalesDbContext : DbContext, IUnitOfWork
    {
        public SalesDbContext(DbContextOptions<SalesDbContext> options) : base(options) { }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
            .SelectMany(e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                if (string.IsNullOrEmpty(property.GetColumnType()) && !property.GetMaxLength().HasValue) property.SetColumnType("VARCHAR(100)");


            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SalesDbContext).Assembly);
        }

        public async Task<bool> Commit()
        {
            return await base.SaveChangesAsync() > 1;
        }
    }
}