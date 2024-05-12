using EthiopiaCoffe.Domain.Concrete.Entities;

namespace EthiopiaCoffe.Repository.Repositories
{
    public interface IOfferRepository:IGenericRepository<Offer>
    {
        Task<IReadOnlyList<Offer>> OffersWithCategory();
    }
}
