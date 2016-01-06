using System.Linq;
using Pulsar.Contracts.Portable.DataTypes.Enums;
using Pulsar.Contracts.Portable.Exceptions;

namespace Pulsar.Infrastructure.DataCollector.DataSources
{
    /// <summary>
    /// Use this DataSource to retreive data from the database which is related to Pulsar devices
    /// </summary>
    public class DeviceDataSource
    {
        public string GetTemperatureKitchen()
        {
            var device = From.HouseManagerDataSource.GetDevice("dev_temp1", "dev_temp1.temperature", NavigationPropertyState.Omit);
            var lastPulseForDevice = From.HouseManagerDataSource.GetAllPulses()
                .Where(s => s.DeviceId == device.Id)
                .OrderByDescending(s => s.RowCreated).FirstOrDefault();

            if (lastPulseForDevice != null)
                return lastPulseForDevice.Value;

            throw new PulsarException("E_PUL_SREST.002", "Could not get latest dev_temp1 value");
        }

        public string GetHumidityKitchen()
        {
            var device = From.HouseManagerDataSource.GetDevice("dev_temp1", "dev_temp1.humidity", NavigationPropertyState.Omit);
            var lastPulseForDevice = From.HouseManagerDataSource.GetAllPulses()
                .Where(s => s.DeviceId == device.Id)
                .OrderByDescending(s => s.RowCreated).FirstOrDefault();

            if (lastPulseForDevice != null)
                return lastPulseForDevice.Value;

            throw new PulsarException("E_PUL_SREST.002", "Could not get latest dev_temp1 value");
        }
    }
}