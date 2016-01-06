using Framework.Date;
using Pulsar.Contracts.Portable.DataTypes;
using Pulsar.Contracts.Portable.DataTypes.Enums;
using Pulsar.Contracts.Services;
using Pulsar.Gateways.Pimatic;
using Pulsar.Infrastructure.DataCollector;

namespace Pulsar.Services.HouseManager
{
    public class DeviceService : IDeviceService
    {
        public string Ping()
        {
            From.HouseManagerDataSource.AddPulsarLog(
               typeof(DeviceService).Namespace, typeof(DeviceService).ToString(), "Pulsar.Services.HouseManager",
               "Ping", DeviceType.WebService, "DeviceService:Get", From.HouseManagerDataSource.GetLocation("Internal").Id,
               RomanceStandardTime.ToString() + " DeviceService Get");
            return "pong";
        }

        public Pulse TurnOnLampLiving()
        {
            return PimSwitchGateway.TurnOnLampLiving();
        }

        public Pulse TurnOffLampLiving()
        {
            return PimSwitchGateway.TurnOffLampLiving();
        }

        public Pulse TurnOnDev_MySwitch1()
        {
            return PimSwitchGateway.TurnOnDev_MySwitch1();
        }

        public Pulse TurnOffDev_MySwitch1()
        {
            return PimSwitchGateway.TurnOffDev_MySwitch1();
        }
    }
}