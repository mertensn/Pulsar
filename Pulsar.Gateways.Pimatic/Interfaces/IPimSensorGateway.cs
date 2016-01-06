using Pulsar.Contracts.Portable.DataTypes;

namespace Pulsar.Gateways.Pimatic.Interfaces
{
    public interface IPimSensorGateway
    {
        Pulse GetPulse_dev_temp1_temperature();
        Pulse GetPulse_dev_temp1_humidity();
    }
}
