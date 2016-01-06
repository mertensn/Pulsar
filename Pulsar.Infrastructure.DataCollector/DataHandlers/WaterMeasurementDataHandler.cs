using Framework.DataClient;
using Pulsar.Contracts.Services.Data.Messages;
using Pulsar.Infrastructure.DataCollector.DataContext;

namespace Pulsar.Infrastructure.DataCollector.DataHandlers
{
    public class WaterMeasurementDataHandler : Repository<WaterMeasurement>
    {
        public static readonly PulsarDataContext PulsarDataContext = new PulsarDataContext();
        public WaterMeasurementDataHandler() : base(PulsarDataContext){}
    }
}
