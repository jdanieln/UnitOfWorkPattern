using Microsoft.EntityFrameworkCore;
using UnitOfWorkPattern.Data;
using UnitOfWorkPattern.Models;

namespace UnitOfWorkPattern.Services
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected UnitOfWorkPatternContext _context;
        internal DbSet<T> _dbSet;

        public GenericRepository(UnitOfWorkPatternContext context)
        {
            _context= context;
            _dbSet = context.Set<T>();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync() {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async void Add(T entity)
        {
            _dbSet.Add(entity);
        }
        public virtual async void Delete(int id)
        {
            var entity = await _dbSet.FindAsync(id);

            if(entity == null)
            {
                throw new Exception("La entidad no existe");
            } 
            _dbSet.Remove(entity);
        }   

        public virtual void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
