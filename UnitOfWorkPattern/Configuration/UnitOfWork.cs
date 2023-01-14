using UnitOfWorkPattern.Data;
using UnitOfWorkPattern.Services;

namespace UnitOfWorkPattern.Configuration
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly UnitOfWorkPatternContext _context;
        public IProductRepository ProductRepository { get; private set; }
        public UnitOfWork(UnitOfWorkPatternContext context) {
            _context= context;
            ProductRepository = new ProductRepository(context);
        }

        public void Commit()
        {
           _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
