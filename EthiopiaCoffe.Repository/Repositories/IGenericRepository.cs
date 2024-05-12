using EthiopiaCoffe.Domain.Abstract.Entities;
using System.Linq.Expressions;

namespace EthiopiaCoffe.Repository.Repositories
{
    public interface IGenericRepository<T> where T : class, IBaseEntity, new()
    {


        Task<IReadOnlyList<T>> All();
        Task<IReadOnlyList<T>> All(Expression<Func<T, bool>> expression);
        Task<IReadOnlyList<T>> AllPaged(int page,int pageSize);
        Task<Guid> AddAsync(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task<T> GetByIdAsync(Guid id);
      



    }
}
