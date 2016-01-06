using System.Linq;
using NUnit.Framework;
using Pulsar.Contracts.Portable.DataTypes;
using Pulsar.Contracts.Portable.DataTypes.Enums;
using Pulsar.Infrastructure.DataCollector;
using Pulsar.Test;

namespace Pulsar.Services.HouseManager.Test.Tests
{
    [TestFixture]
    public class AddPulseTests : ScopedTestBase
    {
        private Pulse _pulse;
        private Location _location;
        private Device _device;
        private DeviceHardware _deviceHardware;

        [SetUp]
        public void SetUp()
        {
            _location = From.HouseManagerDataSource.AddLocation(new Location { Name = "TestLocation" });

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

            _pulse = From.HouseManagerDataSource.AddPulse(new Pulse
            {
                DeviceId = _device.Id,
                Value = "23"
            });
        }

        [Test]
        public void GivenValidInputMessage_PulseIsAddedToDatabase()
        {
            var pulsesForLocation = From.HouseManagerDataSource.GetAllPulsesForLocation(_location.Id);
            var addedPulse = pulsesForLocation.FirstOrDefault(s => s.Id == _pulse.Id);

            Assert.IsNotNull(addedPulse);
            Assert.AreEqual(addedPulse.Value, _pulse.Value);
            Assert.AreEqual(addedPulse.Id, _pulse.Id);
            Assert.AreEqual(addedPulse.DeviceId, _pulse.DeviceId);
        }
    }
}
