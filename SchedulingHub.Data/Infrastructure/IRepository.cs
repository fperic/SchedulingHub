using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingHub.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        // Marks an entity as new (and to be inserted in DB once SaveChanges() is called)
        void Add(T entity);
        // Marks an entity as modified (and to be updated in DB once SaveChanges() is called)
        void Update(T entity);
        // Marks an entity to be removed (and to be deleted once SaveChanges() is called)
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> where);
        // Get an entity by ID
        T GetByID(int id);
        // Get an entity using delegate
        T Get(Expression<Func<T, bool>> where);
        // Get all entities of type T
        IEnumerable<T> GetAll();
        // Gets entities using delegate
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
    }
}
