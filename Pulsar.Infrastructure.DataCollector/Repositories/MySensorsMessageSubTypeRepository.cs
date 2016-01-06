using Framework.DataClient;
using Pulsar.Contracts.Portable.DataTypes.MySensors;
using Pulsar.Infrastructure.DataCollector.DataContexts;

namespace Pulsar.Infrastructure.DataCollector.Repositories
{
    internal sealed class MySensorsMessageSubTypeRepository : Repository<MySensorsMessageSubType>
    {
        internal MySensorsMessageSubTypeRepository() : base(ContextObjects.PulsarDataContext){}
    }
}