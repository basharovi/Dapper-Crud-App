using Dapper.Application.Interfaces;

namespace Dapper.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IProductRepository productRepository)
        {
            Products = productRepository;
        }
        public IProductRepository Products { get; }
    }
}
