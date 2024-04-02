using IG.API.SUNAT.FE.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace IG.API.SUNAT.FE.Repository
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity>
        where TEntity : EntityBase
    {
        protected readonly DbContext Context;

        protected RepositoryBase(DbContext context)
        {
            Context = context;
        }

        public virtual async Task<ICollection<TEntity>> ListAsync()
        {
            return await Context.Set<TEntity>()
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<ICollection<TEntity>> ListAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Context.Set<TEntity>()
                .Where(predicate)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<ICollection<TEntity>> ListAsync<TKey>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TKey>> orderBy)
        {
            return await Context.Set<TEntity>()
                .Where(predicate)
                .OrderBy(orderBy)
                .AsNoTracking()
                .ToListAsync();
        }

        public virtual async Task<TEntity?> FindByIdAsync(int id)
        {
            return await Context.Set<TEntity>().FindAsync(id);
        }

        public virtual async Task<int> AddAsync(TEntity entity)
        {
            await Context.Set<TEntity>().AddAsync(entity);
            await Context.SaveChangesAsync();

            return entity.Id;
        }

        public virtual async Task UpdateAsync()
        {


            await Context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var record = await FindByIdAsync(id);
            if (record is not null)
            {
                Context.Set<TEntity>().Remove(record);
                await UpdateAsync();
            }
        }

        public async Task<int> AddBulkAsync(List<TEntity> entities)
        {
            var response = 0;
            if (entities != null && entities.Any())
            {
                using (var dbContextTransaction = Context.Database.BeginTransaction())
                {
                    try
                    {
                        // Agrega todas las entidades a la colección
                        await Context.Set<TEntity>().AddRangeAsync(entities);
                        // Guarda los cambios
                        await Context.SaveChangesAsync();

                        // Confirma la transacción
                        dbContextTransaction.Commit();
                        response = entities.Count;
                    }
                    catch (Exception ex)
                    {
                        dbContextTransaction.Rollback();
                        throw ex;
                    }
                }
            }
            return response;
        }

        public async Task<(ICollection<TInfo> Collection, int Total)> ListAsync<TInfo, TKey>
            (Expression<Func<TEntity, bool>> predicate,
            Expression<Func<TEntity, TInfo>> selector,
            Expression<Func<TEntity, TKey>> orderby,
            int page,
            int rows,
            string? relationships = null)
        {
            var query = Context.Set<TEntity>()
            .Where(predicate)
            .IgnoreQueryFilters()
            .OrderBy(orderby)
            .Skip((page - 1) * rows)
            .Take(rows)
            .AsQueryable();

            // SELECT de Concert => "Genres"
            // SELECT de Sale => "Concert,Genre,Customer"

            if (!string.IsNullOrWhiteSpace(relationships))
            {
                foreach (var tabla in relationships.Split(',', StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(tabla);
                }
            }

            var collection = await query
                .Select(selector)
                .ToListAsync(); // Aqui recien se ejecuta el query

            var total = await Context.Set<TEntity>()
                .Where(predicate)
                .CountAsync();

            return (collection, total);
        }
    }
}
