using EthiopiaCoffe.Domain.Concrete.Entities;

namespace EthiopiaCoffe.Repository.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {

        Task<IReadOnlyList<Product>> ProductsWithCategory();

    }
}
