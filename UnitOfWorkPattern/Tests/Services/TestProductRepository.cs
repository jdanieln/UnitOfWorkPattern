using UnitOfWorkPattern.Models;
using UnitOfWorkPattern.Services;

namespace UnitOfWorkPattern.Tests.Services
{
    public class TestProductRepository : TestGenericRepository<Product>, IProductRepository
    {
    }
}
