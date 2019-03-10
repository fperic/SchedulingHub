using System;

namespace SchedulingHub.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        SchedulingHubEntities Init();
    }
}
