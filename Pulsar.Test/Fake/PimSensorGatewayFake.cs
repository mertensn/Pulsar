using Pulsar.Contracts.Portable.DataTypes;
using Pulsar.Gateways.Pimatic.Interfaces;

namespace Pulsar.Test.Fake
{
    public class PimSensorGatewayFake : IPimSensorGateway
    {
        public int DeviceId { get; set; }
        public string TemperatureValue { get; set; }
        public string HumidityValue { get; set; }

        public Pulse GetPulse_dev_temp1_temperature()
        {
            return new Pulse
            {
                DeviceId = DeviceId,
                Value = TemperatureValue
            };
        }

        public Pulse GetPulse_dev_temp1_humidity()
        {
            return new Pulse
            {
                DeviceId = DeviceId,
                Value = HumidityValue
            };
        }
    }
}
