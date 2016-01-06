using Framework.DataClient;
using Pulsar.Contracts.Portable.DataTypes.MySensors;
using Pulsar.Infrastructure.DataCollector.DataContexts;

namespace Pulsar.Infrastructure.DataCollector.Repositories
{
    internal sealed class MySensorsMessageTypeRepository : Repository<MySensorsMessageType>
    {
        internal MySensorsMessageTypeRepository() : base(ContextObjects.PulsarDataContext){}
    }
}