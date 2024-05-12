using EthiopiaCoffe.Domain.Abstract.Entities;
using EthiopiaCoffe.Repository.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EthiopiaCoffe.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IBaseEntity, new()
    {
        protected readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
            _dbSet = _context.Set<T>();
        }
        public async Task<Guid> AddAsync(T entity)=> (await _dbSet.AddAsync(entity)).Entity.Id;


        // bunu nasıl async task yaparız?
        public async Task<IReadOnlyList<T>> All()
        {
            return await _dbSet.ToListAsync();
        }
        public async Task<IReadOnlyList<T>> All(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.Where(expression).ToListAsync();
        }

        public async Task<IReadOnlyList<T>> AllPaged(int page, int pageSize)
        {
            var query= await _dbSet.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            return query;
        }

        public Task Delete(T entity)
        {
            _dbSet.Remove(entity);
            return Task.CompletedTask;
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public Task Update(T entity)
        {
           _dbSet.Update(entity);
            return Task.CompletedTask;
        }


    }
}
