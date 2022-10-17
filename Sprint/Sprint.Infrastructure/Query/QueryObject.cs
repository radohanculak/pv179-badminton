﻿using System.Linq.Expressions;

namespace Sprint.Infrastructure.Query;

public abstract class QueryObject<TEntity> : IQueryObject<TEntity> where TEntity : class, new()
{
    protected IQueryable<TEntity> _query;

    public QueryObject<TEntity> Filter(Expression<Func<TEntity, bool>> predicate)
    {
        _query = _query.Where(predicate);

        return this;
    }

    public QueryObject<TEntity> Page(int page, int pageSize)
    {
        _query = _query.Skip((page - 1) * pageSize).Take(pageSize);

        return this;
    }

    public QueryObject<TEntity> OrderBy<TKey>(Expression<Func<TEntity, TKey>> selector, bool ascending = true)
    {
        _query = ascending ? _query = _query.OrderBy(selector) : _query.OrderByDescending(selector);

        return this;
    }

    public abstract Task<IEnumerable<TEntity>> ExecuteAsync();
}
