using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using Pulsar.Contracts.Portable.DataTypes;
using Pulsar.Contracts.Portable.DataTypes.Enums;
using Pulsar.Contracts.Portable.DataTypes.MySensors;

namespace Pulsar.Infrastructure.DataCollector.DbInitializers
{
    public class DeviceInitializer
    {
        public void InitializeDefaultDatabaseValues()
        {
            var home = From.HouseManagerDataSource.GetLocation("Home");
            var defaultDevices = new List<Device>
            {
                _createType("dev_temp1", "dev_temp1", "dev_temp1.temperature", DeviceType.Sensor, "HomeduinoRFSwitch", PulseType.Temperature, home.Id, DeviceHardware.Pimatic),
                _createType("dev_temp1", "dev_temp1", "dev_temp1.humidity", DeviceType.Sensor, "HomeduinoRFSwitch", PulseType.Temperature, home.Id, DeviceHardware.Pimatic),
                _createType("dev_switch1", "dev_switch1", "", DeviceType.Switch, "HomeduinoRFSwitch", PulseType.OnOff, home.Id, DeviceHardware.Pimatic),
                _createType("dev_switch2", "dev_switch2", "", DeviceType.Switch, "HomeduinoRFSwitch", PulseType.OnOff, home.Id, DeviceHardware.Pimatic),
                _createType("dev_switch3", "dev_switch3", "", DeviceType.Switch, "HomeduinoRFSwitch", PulseType.OnOff, home.Id, DeviceHardware.Pimatic),
                _createType("dev_coll1", "2", "1", DeviceType.Switch, "", PulseType.OnOff, home.Id, DeviceHardware.MySensors),
                _createType("dev_hum1", "1", "0", DeviceType.Sensor, "", PulseType.Humidity, home.Id, DeviceHardware.MySensors),
                _createType("dev_temp1", "1", "1", DeviceType.Sensor, "", PulseType.Temperature, home.Id, DeviceHardware.MySensors)
            };

            foreach (var device in defaultDevices)
                From.HouseManagerDataSource.AddDevice(device);
        }

        private static Device _createType(string name, string deviceIdentifier, string sensorId, 
            DeviceType deviceType, string @class, PulseType pulseType, int locationId, DeviceHardware deviceHardware)
        {
            return new Device
            {
              Name = name,
              DeviceIdentifier = deviceIdentifier,
              SensorId = sensorId,
              DeviceType = deviceType,
              Class = @class,
              PulseType = pulseType,
              LocationId = locationId,
              DeviceHardware = deviceHardware
            };
        }
    }
}