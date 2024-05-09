using EthiopiaCoffe.Domain.Abstract.Entities;
using System.Linq.Expressions;

namespace EthiopiaCoffe.Repository.Repositories
{
    public interface IGenericRepository<T> where T : class, IBaseEntity, new()
    {


        IQueryable<T> All();
        Task<Guid> AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<T> GetByIdAsync(Guid id);
        IQueryable<T> Where(Expression<Func<T,bool>> expression);



    }
}
