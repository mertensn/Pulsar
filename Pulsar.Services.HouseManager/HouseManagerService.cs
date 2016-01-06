using Framework.Date;
using Pulsar.Contracts.Portable.DataTypes;
using Pulsar.Contracts.Portable.DataTypes.Enums;
using Pulsar.Contracts.Services;
using Pulsar.Infrastructure.DataCollector;

namespace Pulsar.Services.HouseManager
{
    public class HouseManagerService : IHouseManagerService
    {
        public string Ping()
        {
            From.HouseManagerDataSource.AddPulsarLog(
               typeof(HouseManagerService).Namespace, typeof(HouseManagerService).ToString(), "Pulsar.Services.HouseManager",
               "Ping", DeviceType.WebService, "HouseManagerService:Get", From.HouseManagerDataSource.GetLocation("Internal").Id,
               RomanceStandardTime.ToString() + " HouseManagerService Get");
            return "pong";
        }

        public Pulse AddPulse(Pulse pulse)
        {
            return From.HouseManagerDataSource.AddPulse(pulse);
        }

        public Device AddDevice(Device device)
        {
            return From.HouseManagerDataSource.AddDevice(device);
        }
    }
}
