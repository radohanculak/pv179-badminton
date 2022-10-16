using Microsoft.EntityFrameworkCore;
using Sprint.Infrastructure.Query;

namespace Sprint.Infrastructure.EFCore.Query;

public class EFCoreQueryObject<TEntity> : QueryObject<TEntity> where TEntity : class, new()
{
    private readonly DbContext _dbContext;

    public EFCoreQueryObject(DbContext dbContext)
    {
        _dbContext = dbContext;
        _query = _dbContext.Set<TEntity>().AsQueryable();
    }

    public override async Task<IEnumerable<TEntity>> ExecuteAsync()
    {
        return await _query.ToListAsync();
    }
}
