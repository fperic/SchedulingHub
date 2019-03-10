using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingHub.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory _dbFactory;
        private SchedulingHubEntities _dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this._dbFactory = dbFactory;
        }

        public SchedulingHubEntities DbContext
        {
            get { return _dbContext ?? (_dbContext = _dbFactory.Init()); } 
        }

        public void Commit()
        {
            DbContext.Commit();
        }
    }
}
