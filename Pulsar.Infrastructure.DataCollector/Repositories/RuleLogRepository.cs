using Framework.DataClient;
using Pulsar.Contracts.Portable.DataTypes;
using Pulsar.Infrastructure.DataCollector.DataContexts;

namespace Pulsar.Infrastructure.DataCollector.Repositories
{
    internal sealed class RuleLogRepository : Repository<RuleLog>
    {
        internal RuleLogRepository() : base(ContextObjects.PulsarDataContext) { }
    }
}