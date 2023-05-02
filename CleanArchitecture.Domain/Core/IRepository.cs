using System.Linq.Expressions;

namespace CleanArchitecture.Domain.Core;

public interface IRepository <TEntity> where TEntity : Entity
{
    public Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity,bool>> filter , CancellationToken cancellationToken = default);
    public Task<TEntity> FindOneAsync(Expression<Func<TEntity,bool>> filter , CancellationToken cancellationToken = default);
    public Task<TEntity> FindOneAsync(Guid Id, CancellationToken cancellationToken = default);
    public Task<TEntity> InsertAsync(TEntity entity, CancellationToken cancellationToken = default);
}