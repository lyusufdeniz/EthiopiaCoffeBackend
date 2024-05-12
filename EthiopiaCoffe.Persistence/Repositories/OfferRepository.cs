using EthiopiaCoffe.Domain.Concrete.Entities;
using EthiopiaCoffe.Repository.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EthiopiaCoffe.Persistence.Repositories
{
    public class OfferRepository : GenericRepository<Offer>, IOfferRepository
    {
        public OfferRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }

      public async  Task<IReadOnlyList<Offer>> OffersWithCategory()
        {
            return (await _context.Offers.Include(o => o.Category).ToListAsync()).AsReadOnly(); 
        }
    }
}
