using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyManager.Data
{
    public interface IRepository<TEntity> : IReadOnlyRepository<TEntity> where TEntity : class
    {
        TEntity Create(TEntity entity);
        void Save();
    }

    public class Repository<TEntity> : ReadOnlyRepository<TEntity>, IRepository<TEntity> where TEntity : class
    {
        public Repository(DbContext context)
            : base(context)
        {
        }

        public TEntity Create(TEntity entity)
        {
            return Table.Add(entity);           
        }

        public virtual void Save()
        {
            context.SaveChanges();
        }

    }
}
