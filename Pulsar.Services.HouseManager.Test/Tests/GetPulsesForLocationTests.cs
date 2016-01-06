using NUnit.Framework;
using Pulsar.Contracts.Portable.DataTypes;
using Pulsar.Contracts.Portable.DataTypes.Enums;
using Pulsar.Infrastructure.DataCollector;
using Pulsar.Test;

namespace Pulsar.Services.HouseManager.Test.Tests
{
    [TestFixture]
    public class GetPulsesForLocationTests : ScopedTestBase
    {
        private Pulse _firstPulse;
        private Pulse _secondPulse;
        private Location _location;
        private Device _device;

        [SetUp]
        public void SetUp()
        {
            _location = From.HouseManagerDataSource.AddLocation(new Location {Name = "TestLocation"});

            _device = From.HouseManagerDataSource.AddDevice(new Device
            {
                Name = "switch1",
                LocationId = _location.Id,
                DeviceIdentifier = "00",
                SensorId = "0",
                DeviceHardware = DeviceHardware.Pimatic,
                DeviceType = DeviceType.Sensor,
                PulseType = PulseType.Temperature
            });

            _firstPulse = new Pulse
            {
                DeviceId = _device.Id,
                Value = "23"
            };

            _secondPulse = new Pulse
            {
                DeviceId = _device.Id,
                Value = "23"
            };

            From.HouseManagerDataSource.AddPulse(_firstPulse);
            From.HouseManagerDataSource.AddPulse(_secondPulse);
        }
    }
}