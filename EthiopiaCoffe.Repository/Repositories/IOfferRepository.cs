using EthiopiaCoffe.Domain.Concrete.Entities;

namespace EthiopiaCoffe.Repository.Repositories
{
    public interface IOfferRepository:IGenericRepository<Offer>
    {
        IQueryable<Offer> OffersWithCategory();
    }
}
