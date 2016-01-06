using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Pulsar.Contracts.Portable.DataTypes;
using Pulsar.Contracts.Portable.DataTypes.Enums;
using Pulsar.Test;

namespace Pulsar.Infrastructure.DataCollector.Test.Tests.Repositories
{
    [TestFixture]
    public class PulseRepositoryTests : ScopedTestBase
    {
        private Device _device;
        private Pulse _pulse;
        private Location _location;

       [SetUp]
        public void SetUp()
        {
            _location = From.HouseManagerDataSource.AddLocation(new Location
            {
                Name = "Test"
            });

            _device = From.HouseManagerDataSource.AddDevice(new Device
            {
                Name = "test_coll1",
                DeviceIdentifier = "TEST",
                SensorId = "1",
                DeviceType = DeviceType.Test,
                Class = null,
                PulseType = PulseType.Test,
                LocationId = _location.Id,
                DeviceHardware = DeviceHardware.Test
            });

            _pulse = From.HouseManagerDataSource.AddPulse(new Pulse
            {
                DeviceId = _device.Id,
                Value = "23.1"
            });
        }

        [Test]
        public void PulseIsAddedToDatabase_CanBeFetchedFromDatabase()
        {
            Assert.IsNotNull(_pulse);
            Assert.IsNotNull(_pulse.Id);
            Assert.IsNotNull(_pulse.RowCreated);
            Assert.AreEqual(_device.Id, _pulse.DeviceId);
            Assert.AreEqual("23.1", _pulse.Value);
        }

        [Test]
        public void Given_PulsesAdded_HappyFlow()
        {
            var pulses = new List<Pulse> { _pulse, _pulse };
            var addedPulses = From.HouseManagerDataSource.AddPulses(pulses);

            Assert.IsNotNull(addedPulses);
            Assert.IsTrue(addedPulses.Any());
        }

        [Test]
        public void Given_PulseDeleted_PulseCannotBeFoundInDb()
        {
            var pulseIsDeleted = From.HouseManagerDataSource.DeletePulse(_pulse.Id);
            Assert.IsTrue(pulseIsDeleted);
        }

        [Test]
        [ExpectedPulsarException("E_PUL_IDC.021")]
        public void Given_DeletedPulse_GetPulse_ThrowsException()
        {
            From.HouseManagerDataSource.DeletePulse(_pulse.Id);
            From.HouseManagerDataSource.GetPulse(_pulse.Id);
        }

        [Test]
        public void Given_GetAllPulses_AllPulsesAreFetchedFromDb()
        {
            var pulses = From.HouseManagerDataSource.GetAllPulses();
            Assert.IsNotNull(pulses);
            Assert.IsTrue(pulses.Any());
        }

        [Test]
        public void Given_GetPulse_PulseCanBeFetchedFromDatabse()
        {
            var pulse = From.HouseManagerDataSource.GetPulse(_pulse.Id);

            Assert.IsNotNull(pulse);
            Assert.IsNotNull(pulse.Id);
            Assert.IsNotNull(pulse.RowCreated);
            Assert.AreEqual(_pulse.Value, pulse.Value);
            Assert.AreEqual(_pulse.DeviceId, pulse.DeviceId);
        }

        [Test]
        public void Given_GetAllPulsesForLocation_HappyFlow()
        {
            var pulsesForLocation = From.HouseManagerDataSource.GetAllPulsesForLocation(_location.Id);
            Assert.IsNotNull(pulsesForLocation);
            Assert.IsTrue(pulsesForLocation.Any());
        }

        [Test]
        [ExpectedPulsarException("E_PUL_IDC.012")]
        public void Given_GetAllPulsesForLocation_NonExistingLocation_ThrowsException()
        {
            From.HouseManagerDataSource.GetAllPulsesForLocation(-1);
        }
    }
}