using Framework.DataClient;
using Pulsar.Contracts.Portable.DataTypes;
using Pulsar.Infrastructure.DataCollector.DataContexts;

namespace Pulsar.Infrastructure.DataCollector.Repositories
{
    internal sealed class ControllerValueRepository : Repository<ControllerValue>
    {
        internal ControllerValueRepository() : base(ContextObjects.PulsarDataContext){}
    }
}