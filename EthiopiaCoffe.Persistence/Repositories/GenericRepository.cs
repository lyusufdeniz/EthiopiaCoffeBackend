using EthiopiaCoffe.Domain.Abstract.Entities;
using EthiopiaCoffe.Repository.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
        public IQueryable<T> All() => _dbSet.AsQueryable();
        public void Delete(T entity) => _dbSet.Remove(entity);
        public Task<T> GetByIdAsync(Guid id) => _dbSet.FirstOrDefaultAsync(x => x.Id == id)!;
        public void Update(T entity) => _dbSet.Update(entity);
        public IQueryable<T> Where(Expression<Func<T, bool>> expression)=> _dbSet.Where(expression);
   
    }
}
