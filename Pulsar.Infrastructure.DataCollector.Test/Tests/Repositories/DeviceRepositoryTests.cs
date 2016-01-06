using System.Linq;
using NUnit.Framework;
using Pulsar.Contracts.Portable.DataTypes;
using Pulsar.Contracts.Portable.DataTypes.Enums;
using Pulsar.Test;

namespace Pulsar.Infrastructure.DataCollector.Test.Tests.Repositories
{
    [TestFixture]
    public class DeviceRepositoryTests : ScopedTestBase
    {
        private Device _dht22Himidity;

        [SetUp]
        public void SetUp()
        {
            _dht22Himidity = From.HouseManagerDataSource.AddDevice(new Device
            {
                Name = "DHT22",
                DeviceIdentifier = "999999999",
                SensorId = "1",
                DeviceType = DeviceType.Sensor,
                PulseType = PulseType.Humidity,
                DeviceHardware = DeviceHardware.MySensors,
                LocationId = From.HouseManagerDataSource.GetLocation("Home").Id,
                Class = "TestClass"
            });
        }

        [Test]
        public void GivenDeviceIsAddedToDatabase_DeviceCanBeFoundInDatabase()
        {
            Assert.IsNotNull(_dht22Himidity);
            Assert.IsNotNull(_dht22Himidity.Id);
            Assert.IsNotNull(_dht22Himidity.RowCreated);
            Assert.AreEqual(_dht22Himidity.DeviceType, DeviceType.Sensor);
            Assert.AreEqual(_dht22Himidity.Name, "DHT22");
            Assert.AreEqual(_dht22Himidity.DeviceIdentifier, "999999999");
            Assert.AreEqual(_dht22Himidity.SensorId, "1");
            Assert.AreEqual(_dht22Himidity.PulseType, PulseType.Humidity);
            Assert.AreEqual(_dht22Himidity.Class, "TestClass");
            Assert.AreEqual(_dht22Himidity.DeviceHardware, DeviceHardware.MySensors);
        }

        [Test]
        [ExpectedPulsarException("E_PUL_IDC.014")]
        public void Given_WhenAddingDevice_NodeIdAlreadyExistingInDatabase_ThrowsException()
        {
            From.HouseManagerDataSource.AddDevice(_dht22Himidity);
        }

        [Test]
        public void Given_GetAllDevices_DeviceListCannotBeEmpty()
        {
            var devices = From.HouseManagerDataSource.GetAllDevices();
            Assert.IsTrue(devices.Any());
        }

        [Test]
        public void Given_GetDeviceForId_DeviceListCannotBeEmpty()
        {
            var firstDevice = From.HouseManagerDataSource.GetAllDevices().FirstOrDefault();
            Assert.IsNotNull(firstDevice);
            var firstDeviceId = firstDevice.Id;
            var device = From.HouseManagerDataSource.GetDevice(firstDeviceId, NavigationPropertyState.Omit);

            Assert.IsNotNull(device);
        }

        [Test]
        public void Given_GetDeviceForDeviceIdentifierAndSensorId_DeviceisReturned()
        {
            var firstDevice = From.HouseManagerDataSource.GetAllDevices().FirstOrDefault();
            var device = From.HouseManagerDataSource.GetDevice(firstDevice.DeviceIdentifier, firstDevice.SensorId, 
                NavigationPropertyState.Omit);

            Assert.IsNotNull(device);
        }

        [Test]
        [TestCase("", "")]
        [TestCase(null, null)]
        [TestCase("TestDeviceIdentifier", "TestSensorId")]
        [ExpectedPulsarException("E_PUL_IDC.011")]
        public void Given_GetDeviceForNonExistingDeviceIdentifierAndSensorId_ExpectsException(string deviceIdentifier, string sensorId)
        {
            From.HouseManagerDataSource.GetDevice(deviceIdentifier, sensorId, NavigationPropertyState.Omit);
        }

        [Test]
        public void Given_GetDevicesForLocationId_DevicesCanBeFound()
        {
            var location = From.HouseManagerDataSource.GetLocation("Home");
            _dht22Himidity.DeviceIdentifier = "Test1234567";
            _dht22Himidity.LocationId = location.Id;
            From.HouseManagerDataSource.AddDevice(_dht22Himidity);
            
            var devices = From.HouseManagerDataSource.GetDevicesForLocation(location.Id);
            Assert.IsTrue(devices.Any());
        }

        [Test]
        public void Given_GetDevicesForLocationName_DevicesCanBeFound()
        {
            var location = From.HouseManagerDataSource.GetLocation("Home");
            _dht22Himidity.DeviceIdentifier = "Test1234567";
            _dht22Himidity.LocationId = location.Id;
            From.HouseManagerDataSource.AddDevice(_dht22Himidity);

            var devices = From.HouseManagerDataSource.GetDevicesForLocation(location.Name);
            Assert.IsTrue(devices.Any());
        }
    }
}