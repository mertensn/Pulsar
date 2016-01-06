using Framework.DataClient;
using Pulsar.Contracts.Services.Data.Messages;
using Pulsar.Infrastructure.DataCollector.DataContext;

namespace Pulsar.Infrastructure.DataCollector.DataHandlers
{
    public class GasMeasurementDataHandler : Repository<GasMeasurement>
    {
        public static readonly PulsarDataContext PulsarDataContext = new PulsarDataContext();
        public GasMeasurementDataHandler() : base(PulsarDataContext){}
    }
}
