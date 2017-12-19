using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FacultyManager.Data
{
    public interface IReadOnlyRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll(
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = null,
            int? skip = null,
            int? take = null);
    }

    public class ReadOnlyRepository<TEntity> : IReadOnlyRepository<TEntity>
        where TEntity : class
    {
        protected readonly DbContext context;

        public ReadOnlyRepository(DbContext context)
        {
            this.context = context;
        }

        protected DbSet<TEntity> Table => context.Set<TEntity>();

        public IEnumerable<TEntity> GetAll(
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = null,
            int? skip = null,
            int? take = null)
        {
            return GetQueryable(null, orderBy, includeProperties, skip, take);
        }

        protected virtual IQueryable<TEntity> GetQueryable(
           Expression<Func<TEntity, bool>> filter = null,
           Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
           string includeProperties = null,
           int? skip = null,
           int? take = null)
        {
            IQueryable<TEntity> query = Table;

            if(filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                query = includeProperties
                    .Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                    .Aggregate(query, (current, includeProperty) => current.Include(includeProperty.Trim()));
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            if(skip != null)
            {
                query = query.Skip(skip.Value);
            }

            if(take != null)
            {
                query = query.Take(take.Value);
            }

            return query;
        }
    }
}
