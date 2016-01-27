using System;
using System.Data.Entity;
using Eat.Entity;

namespace Eat.Database
{
    public interface IUnitOfWork
    {
        IDbSet<Food> Foods { get; }

        int SaveChanges();
        void Added<TEntity>(TEntity entity) where TEntity : class;
        void Modified<TEntity>(TEntity entity) where TEntity : class;
        void Unchanged<TEntity>(TEntity entity) where TEntity : class;
        void Deleted<TEntity>(TEntity entity) where TEntity : class;
        IDbSet<TEntity> GetDbSet<TEntity>() where TEntity : class;
        void RefreshFromDatabase(object entity);
        bool IsAttached<TEntity>(TEntity entity, Func<TEntity, bool> predicate) where TEntity : class;
        void Attach<TEntity>(TEntity entity) where TEntity : class;
        void Detach(object entity);
        void SetValues(object dbEntity, object sourceEntity);
    }
}
