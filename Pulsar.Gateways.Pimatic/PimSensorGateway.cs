using System;
using System.Linq;
using Framework.Date;
using Pimatic.NET.Contracts.DataTypes.Messages;
using Pimatic.NET.ServiceClient.Factories;
using Pulsar.Contracts.Portable.DataTypes;
using Pulsar.Contracts.Portable.DataTypes.Enums;
using Pulsar.Contracts.Portable.Exceptions;
using Pulsar.Gateways.Pimatic.Interfaces;
using Pulsar.Infrastructure.DataCollector;

namespace Pulsar.Gateways.Pimatic
{
    /// <summary>
    /// The SensorGateway calls the PimaticVariableFactory and reads out the values of all sensors.
    /// When a value is fetched it creates a Pulse in the database.
    /// </summary>
    public class PimSensorGateway : IPimSensorGateway
    {
        public readonly GetVariablesMessage Variables;

        public PimSensorGateway()
        {
            Variables = new PimaticVariableFactory().GetVariables();
        }

        [Obsolete("The device dev_temp1 has been deleted from Pimatic")]
        public Pulse GetPulse_dev_temp1_temperature()
        {
            _log("GetPulse_dev_temp1_temperature");

            var pimVariable = Variables.variables.SingleOrDefault(s => s.name == "dev_temp1.temperature");
            if (pimVariable == null) return _throwPimaticException("dev_temp1", "dev_temp1.temperature");

            var device = From.HouseManagerDataSource.GetDevice("dev_temp1", "dev_temp1.temperature", NavigationPropertyState.Omit);
            return _createPulse(pimVariable.value.ToString(), device);
        }

        [Obsolete("The device dev_temp1 has been deleted from Pimatic")]
        public Pulse GetPulse_dev_temp1_humidity()
        {
            _log("GetPulse_dev_temp1_humidity");

            var pimVariable = Variables.variables.SingleOrDefault(s => s.name == "dev_temp1.humidity");
            if (pimVariable == null) return _throwPimaticException("dev_temp1", "humidity");

            var device = From.HouseManagerDataSource.GetDevice("dev_temp1", "dev_temp1.humidity", NavigationPropertyState.Omit);
            return _createPulse(pimVariable.value.ToString(), device);
        }

        private static void _log(string method)
        {
            From.HouseManagerDataSource.AddPulsarLog(
                typeof(PimSensorGateway).Namespace, typeof(PimSensorGateway).ToString(), "Pulsar.Gateways.Pimatic",
                method, DeviceType.Sensor, typeof(PimSensorGateway) + ":" + method, From.HouseManagerDataSource.GetLocation("Home").Id,
                RomanceStandardTime.ToString() + " PimSensorGateway " + method);
        }

        private static Pulse _createPulse(string value, Device device)
        {
            return new Pulse
            {
                DeviceId = device.Id,
                Value = value
            };
        }

        private static Pulse _throwPimaticException(string device, string variable)
        {
            throw new PulsarException("E_PUL_GWPIM.001", "Variable {0} for device {1} could not be found", variable, device);
        }
    }
}