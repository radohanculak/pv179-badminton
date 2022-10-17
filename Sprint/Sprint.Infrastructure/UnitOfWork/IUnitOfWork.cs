namespace Sprint.Infrastructure.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    Task Commit();
}
