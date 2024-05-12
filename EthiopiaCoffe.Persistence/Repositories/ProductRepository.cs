using EthiopiaCoffe.Domain.Concrete.Entities;
using EthiopiaCoffe.Repository.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EthiopiaCoffe.Persistence.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        


        public ProductRepository(AppDbContext appDbContext) :base(appDbContext)
        {
        
        }

        public async Task<IReadOnlyList<Product>> ProductsWithCategory ()
        {
          return  (await _context.Products.Include(p => p.Category).ToListAsync()).AsReadOnly();   
        }
    }
}
