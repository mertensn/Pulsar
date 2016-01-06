using System.Data.Entity;
using System.Linq;
using Framework.DataClient;
using Pulsar.Contracts.Portable.DataTypes;
using Pulsar.Infrastructure.DataCollector.DataContexts;

namespace Pulsar.Infrastructure.DataCollector.Repositories
{
    /// <summary>
    /// Use this class to add overloads to the generic repository
    /// </summary>
    internal sealed class PulseRepository : Repository<Pulse>
    {
        internal PulseRepository() : base(ContextObjects.PulsarDataContext) { }

        public override IQueryable<Pulse> Get()
        {
            return base.Get().Include(s => s.Device);
        }
    }
}
