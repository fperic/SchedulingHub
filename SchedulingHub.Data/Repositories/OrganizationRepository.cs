using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchedulingHub.Model;
using SchedulingHub.Data.Infrastructure;


namespace SchedulingHub.Data.Repositories
{
    public class OrganizationRepository : RepositoryBase<Organization>, IOrganizationRepository
    {
        public OrganizationRepository(IDbFactory dbFactory) : base (dbFactory)
        {

        }
    }
}
