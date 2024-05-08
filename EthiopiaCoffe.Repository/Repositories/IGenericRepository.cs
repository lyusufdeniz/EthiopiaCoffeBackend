using EthiopiaCoffe.Domain.Abstract.Entities;
using System.Linq.Expressions;

namespace EthiopiaCoffe.Repository.Repositories
{
    public interface IGenericRepository<T> where T : class, IBaseEntity, new()
    {


        IQueryable<T> AllAsync();
        Task AddAsync(T entity);
        void UpdateAsync(T entity);
        void DeleteAsync(Guid id);
        void DeleteAsync(T entity);
        Task<T> GetById(Guid id);
        IQueryable<T> Where(Expression<Func<T,bool>> expression);



    }
}
