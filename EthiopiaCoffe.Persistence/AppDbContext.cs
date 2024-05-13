using EthiopiaCoffe.Domain.Abstract.Entities;
using EthiopiaCoffe.Domain.Concrete.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;
using System.Reflection;

namespace EthiopiaCoffe.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Offer> Offers { get; set; }


        //insert createddate to saved entity
        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            SetDate();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {

            SetDate();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
        private void SetDate()
        {

            foreach (var entityEntry in ChangeTracker.Entries().Where(e => e.Entity is BaseEntity && (e.State == EntityState.Added)))
            {

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).CreateDate = DateTime.Now;
                }
            }
        }

        //apply entity configurations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }


    }
}
