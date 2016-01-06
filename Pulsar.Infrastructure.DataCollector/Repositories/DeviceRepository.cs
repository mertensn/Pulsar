using System.Data.Entity;
using System.Linq;
using Framework.DataClient;
using Pulsar.Contracts.Portable.DataTypes;
using Pulsar.Contracts.Portable.DataTypes.Enums;
using Pulsar.Infrastructure.DataCollector.DataContexts;

namespace Pulsar.Infrastructure.DataCollector.Repositories
{
    internal sealed class DeviceRepository : Repository<Device>
    {
        internal DeviceRepository() : base(ContextObjects.PulsarDataContext){}

        public IQueryable<Device> Get(NavigationPropertyState navigationPropertyState)
        {
            return navigationPropertyState == NavigationPropertyState.Omit ? Get() : Get().Include(s => s.Location);
        }
    }
}