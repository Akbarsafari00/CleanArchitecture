using System.Linq.Expressions;

namespace CleanArchitecture.Domain.Core;

public interface IRepository <TEntity>
{
    public IEnumerable<TEntity> FindAsync(Expression<Func<TEntity,bool>> filter , CancellationToken cancellationToken = default);
    public TEntity FindOneAsync(Expression<Func<TEntity,bool>> filter , CancellationToken cancellationToken = default);
    public TEntity FindOneAsync(Guid Id);
}