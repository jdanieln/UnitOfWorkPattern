using UnitOfWorkPattern.Services;

namespace UnitOfWorkPattern.Configuration
{
    public interface IUnitOfWork
    {
        IProductRepository ProductRepository { get; }

        void Commit();
        void Dispose();
    }
}
