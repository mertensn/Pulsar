using Framework.DataClient;
using Pulsar.Contracts.Portable.DataTypes;
using Pulsar.Infrastructure.DataCollector.DataContexts;

namespace Pulsar.Infrastructure.DataCollector.Repositories
{
    internal sealed class PulsarLogRepository : Repository<PulsarLog>
    {
        internal PulsarLogRepository() : base(ContextObjects.PulsarDataContext){}
    }
}