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

        public IQueryable<Product> ProductsWithCategory ()
        {
          return  _context.Products.Include(p => p.Category).AsQueryable();   
        }
    }
}
