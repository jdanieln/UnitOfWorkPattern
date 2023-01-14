using Microsoft.EntityFrameworkCore;
using UnitOfWorkPattern.Data;
using UnitOfWorkPattern.Models;

namespace UnitOfWorkPattern.Services
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(UnitOfWorkPatternContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
    }
}
