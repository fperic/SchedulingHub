using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingHub.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        SchedulingHubEntities dbContext;

        public SchedulingHubEntities Init()
        {
            return dbContext ?? (dbContext = new SchedulingHubEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
