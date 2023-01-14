using UnitOfWorkPattern.Configuration;
using UnitOfWorkPattern.Services;

namespace UnitOfWorkPattern.Tests.Configuration
{
    public class TestUnitOfWork : IUnitOfWork, IDisposable
    {
        public IProductRepository ProductRepository => throw new NotImplementedException();

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
