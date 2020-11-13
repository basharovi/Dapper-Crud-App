namespace Dapper.Application.Interfaces
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }
    }
}
