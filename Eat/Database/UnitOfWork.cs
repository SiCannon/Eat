using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using Eat.Entity;

namespace Eat.Database
{
    public class UnitOfWork : IUnitOfWork
    {
        public IDbSet<Food> Foods { get { return db.Foods; } }

        private EatContext db;

        public UnitOfWork()
        {
            this.db = new EatContext();
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }

        public void Added<TEntity>(TEntity entity) where TEntity : class
        {
            db.Entry(entity).State = EntityState.Added;
        }

        public void Modified<TEntity>(TEntity entity) where TEntity : class
        {
            db.Entry(entity).State = EntityState.Modified;
        }

        public void Unchanged<TEntity>(TEntity entity) where TEntity : class
        {
            db.Entry(entity).State = EntityState.Unchanged;
        }

        public void Deleted<TEntity>(TEntity entity) where TEntity : class
        {
            db.Entry(entity).State = EntityState.Deleted;
        }

        public IDbSet<TEntity> GetDbSet<TEntity>() where TEntity : class
        {
            return db.Set<TEntity>();
        }

        public void RefreshFromDatabase(object entity)
        {
            ((IObjectContextAdapter)db).ObjectContext.Refresh(RefreshMode.StoreWins, entity);
        }

        public bool IsAttached<TEntity>(TEntity entity, Func<TEntity, bool> predicate) where TEntity : class
        {
            return GetDbSet<TEntity>().Any(predicate);
        }

        public void Attach<TEntity>(TEntity entity) where TEntity : class
        {
            GetDbSet<TEntity>().Attach(entity);
        }

        public void Detach(object entity)
        {
            ((IObjectContextAdapter)db).ObjectContext.Detach(entity);
        }

        public void SetValues(object dbEntity, object sourceEntity)
        {
            db.Entry(dbEntity).CurrentValues.SetValues(sourceEntity);
        }
    }
}
