using System.Collections.Generic;
using System.Linq;
using Framework.Date;
using Pulsar.Contracts.Portable.DataTypes;
using Pulsar.Contracts.Portable.DataTypes.Enums;
using Pulsar.Gateways.Pimatic;
using Pulsar.Gateways.Pimatic.Interfaces;
using Pulsar.Infrastructure.DataCollector;
using Pulsar.Processor.MessageFactories;

namespace Pulsar.Processor
{
    public class SensorProcessor
    {
        private IPimSensorGateway _pimSensorGateway;

        public SensorProcessor()
        {
        }

        public SensorProcessor(IPimSensorGateway pimSensorGateway)
        {
            _pimSensorGateway = pimSensorGateway;
        }

        public void ProcessAllSensors()
        {
            From.HouseManagerDataSource.AddPulsarLog(
                typeof(SensorProcessor).Namespace, typeof(SensorProcessor).ToString(), "Pulsar.Processor",
                "ProcessAllSensors", DeviceType.Sensor, "SensorProcessor:ProcessAllSensors", From.HouseManagerDataSource.GetLocation("Home").Id,
                 RomanceStandardTime.ToString() + " SensorProcessor ProcessAllSensors");

            ProcessPimaticSensors();
        }

        public IEnumerable<Pulse> ProcessPimaticSensors()
        {
            _pimSensorGateway = new PimSensorGateway();

            From.HouseManagerDataSource.AddPulsarLog(
                typeof(SensorProcessor).Namespace, typeof(SensorProcessor).ToString(), "Pulsar.Processor",
                "ProcessPimaticSensors", DeviceType.Sensor, "SensorProcessor:ProcessPimaticSensors", From.HouseManagerDataSource.GetLocation("Home").Id,
                 RomanceStandardTime.ToString() + " SensorProcessor ProcessPimaticSensors");

            var pimaticPulses = new List<Pulse>
            {
                _pimSensorGateway.GetPulse_dev_temp1_temperature(),
                _pimSensorGateway.GetPulse_dev_temp1_humidity()
            };

            return pimaticPulses.Any() ? From.HouseManagerDataSource.AddPulses(pimaticPulses) : null;
        }

        public Pulse ProcessMySensorsMessage(string message)
        {
            From.HouseManagerDataSource.AddPulsarLog(
                typeof(SensorProcessor).Namespace, typeof(SensorProcessor).ToString(), "Pulsar.Processor",
                "ProcessMySensorsMessage", DeviceType.Sensor, "SensorProcessor:ProcessMySensorsMessage", From.HouseManagerDataSource.GetLocation("Home").Id,
                 RomanceStandardTime.ToString() + " SensorProcessor ProcessMySensorsMessage");

            var mySensorsMessageFactory = new MySensorsMessageFactory();
            var mySensorsMessage = mySensorsMessageFactory.Deserialize(message);

            if (mySensorsMessage == null)
                return null;

            if (mySensorsMessage.NodeId == 0 && mySensorsMessage.ChildSensorId == 0)
                return null;

            var pulse = mySensorsMessageFactory.ConvertToPulse(mySensorsMessage);
            return pulse != null ? From.HouseManagerDataSource.AddPulse(pulse) : null;
        }
    }
}