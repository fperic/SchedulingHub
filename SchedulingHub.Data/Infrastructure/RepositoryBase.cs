using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace SchedulingHub.Data.Infrastructure
{
    public abstract class RepositoryBase<T> where T : class
    {
        private SchedulingHubEntities dataContext;
        private readonly IDbSet<T> dbSet;

        protected IDbFactory DbFactory { get; private set; }
        protected SchedulingHubEntities DbContext
        {
            get { return dataContext ?? (dataContext = DbFactory.Init()); }
        }

        protected RepositoryBase(IDbFactory dbFactory)
        {
            this.DbFactory = dbFactory;
            dbSet = DbContext.Set<T>();
        }

        #region Implementation
        // The implementations are marked as virtual, so any repository can ovveride a specific operation as required.

        public virtual void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            dbSet.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public virtual void Delete(Expression<Func<T, bool>> whereCondition)
        {
            IEnumerable<T> entities = dbSet.Where<T>(whereCondition).AsEnumerable();

            foreach (T entity in entities)
            {
                dbSet.Remove(entity);
            }
        }

        public virtual T GetByID(int id)
        {
            return dbSet.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> whereCondition)
        {
            return dbSet.Where(whereCondition).ToList();
        }

        public virtual T Get(Expression<Func<T, bool>> whereCondition)
        {
            return dbSet.Where(whereCondition).FirstOrDefault<T>();
        }

        #endregion
    }
}
