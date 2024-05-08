using EthiopiaCoffe.Domain.Abstract.Entities;
using EthiopiaCoffe.Repository.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EthiopiaCoffe.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IBaseEntity, new()
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
            _dbSet = _context.Set<T>();
        }
        public async Task AddAsync(T entity) => await _dbSet.AddAsync(entity);

        // bunu nasıl async task yaparız?
        public IQueryable<T> AllAsync() => _dbSet.AsQueryable();
        public void DeleteAsync(T entity) => _dbSet.Remove(entity);
        public async void DeleteAsync(Guid id)
        {
            var entity = await GetById(id);
            DeleteAsync(entity);
        }

        public Task<T> GetById(Guid id) => _dbSet.FirstOrDefaultAsync(x => x.Id == id)!;
        public void UpdateAsync(T entity) => _dbSet.Update(entity);
        public IQueryable<T> Where(Expression<Func<T, bool>> expression)=> _dbSet.Where(expression);
   
    }
}
