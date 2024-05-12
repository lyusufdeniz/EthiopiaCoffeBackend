using EthiopiaCoffe.Domain.Concrete.Entities;
using EthiopiaCoffe.Repository.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EthiopiaCoffe.Persistence.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<IReadOnlyList<Category>> CategoryWithProducts()
        {
            var data = await _context.Categories.Include(c => c.Products).ToListAsync();
            return data.AsReadOnly();
        }
    }
}
