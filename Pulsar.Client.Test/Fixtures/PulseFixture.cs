using Pulsar.Contracts.Portable.DataTypes;

namespace Pulsar.Client.Test.Fixtures
{
    public class PulseFixture
    {
        public Pulse Create()
        {
            return new Pulse
            {
                Id =  3,
                DeviceId =  2,
                Value =  "22"
            };
        }
    }
}
