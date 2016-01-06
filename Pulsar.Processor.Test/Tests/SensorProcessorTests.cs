using System;
using System.Linq;
using NUnit.Framework;
using Pulsar.Contracts.Portable.DataTypes;
using Pulsar.Contracts.Portable.DataTypes.Enums;
using Pulsar.Infrastructure.DataCollector;
using Pulsar.Test;
using Pulsar.Test.Fake;

namespace Pulsar.Processor.Test.Tests
{
    [TestFixture]
    public class SensorProcessorTests : ScopedTestBase
    {
        private PimSensorGatewayFake _pimSensorGatewayFake;
        private Device _device;

        [SetUp]
        public void SetUp()
        {
            var location = From.HouseManagerDataSource.AddLocation(new Location
            {
                Name = "TestLocation"
            });

            _device = From.HouseManagerDataSource.AddDevice(new Device
            {
                Class = "TestClass",
                DeviceHardware = DeviceHardware.Test,
                DeviceIdentifier = "TestIdentifier",
                SensorId = "TestSensorId",
                DeviceType = DeviceType.Test,
                LocationId = location.Id,
                Name = "TestDevice",
                PulseType = PulseType.Test,
            });

            _pimSensorGatewayFake = new PimSensorGatewayFake
            {
                DeviceId = _device.Id,
                TemperatureValue = "21.5",
                HumidityValue = "61"
            };
        }

        [Test]
        public void Given_ProcessAllPulses_PulsesAreAddedToDatabase()
        {
            var pulses = new SensorProcessor(_pimSensorGatewayFake).ProcessPimaticSensors();
            if (pulses == null) return;

            var pulsesList = pulses.ToList();
            Assert.IsNotNull(pulsesList);
            Assert.IsTrue(pulsesList.Any());

            foreach (var pulse in pulsesList)
            {
                Assert.IsNotNull(pulse);
                var pulseFromDb = From.HouseManagerDataSource.GetAllPulses().SingleOrDefault(s => s.Id == pulse.Id);

                Assert.IsNotNull(pulseFromDb);
                Assert.AreEqual(pulse.DeviceId, pulseFromDb.DeviceId);
                Assert.AreEqual(pulse.Id, pulseFromDb.Id);
                Assert.AreEqual(pulse.Value, pulseFromDb.Value);
            }
        }
    }
}
