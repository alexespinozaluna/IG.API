using IG.API.SUNAT.FE.Entity;
using System.Linq.Expressions;

namespace IG.API.SUNAT.FE.Repository
{
    public interface IRepositoryBase<TEntity>
        where TEntity : EntityBase
    {

        Task<ICollection<TEntity>> ListAsync();

        Task<ICollection<TEntity>> ListAsync(Expression<Func<TEntity, bool>> predicate);

        Task<ICollection<TEntity>> ListAsync<TKey>(Expression<Func<TEntity, bool>> predicate,
            Expression<Func<TEntity, TKey>> orderBy);

        Task<(ICollection<TInfo> Collection, int Total)> ListAsync<TInfo, TKey>(
            Expression<Func<TEntity, bool>> predicate,
            Expression<Func<TEntity, TInfo>> selector,
            Expression<Func<TEntity, TKey>> orderby,
            int page, int rows,
            string? relationships = null);

        Task<TEntity?> FindByIdAsync(int id);

        Task<int> AddAsync(TEntity entity);

        Task UpdateAsync();

        Task DeleteAsync(int id);

    }
}
