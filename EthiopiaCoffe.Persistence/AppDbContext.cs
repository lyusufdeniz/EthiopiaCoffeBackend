using EthiopiaCoffe.Domain.Concrete.Entities;
using Microsoft.EntityFrameworkCore;

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

    }
}
