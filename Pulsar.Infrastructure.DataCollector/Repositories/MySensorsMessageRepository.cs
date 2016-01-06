using System.Data.Entity;
using System.Linq;
using Framework.DataClient;
using Pulsar.Contracts.Portable.DataTypes.MySensors;
using Pulsar.Infrastructure.DataCollector.DataContexts;

namespace Pulsar.Infrastructure.DataCollector.Repositories
{
    internal sealed class MySensorsMessageRepository : Repository<MySensorsMessage>
    {
        internal MySensorsMessageRepository() : base(ContextObjects.PulsarDataContext){}

        public override IQueryable<MySensorsMessage> Get()
        {
            return base.Get().Include(s => s.MySensorsMessageType).Include(s => s.MySensorsMessageSubType);
        }
    }
}