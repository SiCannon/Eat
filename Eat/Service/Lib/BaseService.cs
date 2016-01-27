using Eat.Database;
using Eat.Entity.Interface;

namespace Eat.BusinessLogic
{
    public class BaseService
    {
        protected IUnitOfWork work;

        public BaseService(IUnitOfWork work)
        {
            this.work = work;
        }

        protected TEntity InternalSave<TEntity>(TEntity entity, bool commit = true) where TEntity : class, IIsNew
        {
            if (entity.IsNew)
            {
                work.GetDbSet<TEntity>().Add(entity);
            }
            else
            {
                var dbSet = work.GetDbSet<TEntity>();
                dbSet.Attach(entity);
                work.Modified(entity);
            }
            if (commit)
            {
                work.SaveChanges();
            }
            return entity;
        }

        protected void InternalDelete<TEntity>(TEntity entity, bool saveChanges = true) where TEntity : class
        {
            work.GetDbSet<TEntity>().Remove(entity);
            if (saveChanges)
            {
                work.SaveChanges();
            }
        }
    
    }
}
