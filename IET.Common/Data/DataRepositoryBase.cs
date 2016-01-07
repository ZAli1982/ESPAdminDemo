using IET.Common.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IET.Common.Data
{
    public abstract class DataRepositoryBase<T, U> : IDataRepository<T>
        where T : class, new()
        where U : DbContext, new()
    {
        protected abstract T AddEntity(U entityContext, T entity);
        protected abstract T UpdateEntity(U entityContext, T entity);
        protected abstract IEnumerable<T> GetEntities(U context);
        protected abstract T GetEntity(U entityContext, int id);
        protected abstract T GetEntity(U entityContext, string id);

        public T Add(T entity)
        {
            using (U entityContext = new U())
            {
                T entityToAdd = AddEntity(entityContext, entity);
                entityContext.SaveChanges();
                return entityToAdd;
            }
        }

        public void Remove(T entity)
        {
            using (U entityContext = new U())
            {
                entityContext.Entry<T>(entity).State = EntityState.Deleted;
                entityContext.SaveChanges();
            }
        }

        public void Remove(int id)
        {
            using (var entityContext = new U())
            {
                T entityToDelete = GetEntity(entityContext, id);
                entityContext.Entry(entityToDelete).State = EntityState.Deleted;
                entityContext.SaveChanges();
            }
        }

        public T Update(T entity)
        {
            using (var entityContext = new U())
            {
                T updateEntity = UpdateEntity(entityContext, entity);
                entityContext.Entry(updateEntity).State = EntityState.Modified;
                entityContext.SaveChanges();
                return updateEntity;
            }
        }

        public IEnumerable<T> Get()
        {
            using (var context = new U())
            {
                return (GetEntities(context));
            }
        }

        public T Get(int id)
        {
            using (var entityContext = new U())
            {
                return (GetEntity(entityContext, id));
            }
        }

        public T Get(string id)
        {
            using (var entityContext = new U())
            {
                return (GetEntity(entityContext, id));
            }
        }
    }
}
