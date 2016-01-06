using Framework.Date;
using Pulsar.Contracts.Portable.DataTypes.Enums;
using Pulsar.Infrastructure.DataCollector;
using PushbulletSharp;
using PushbulletSharp.Models.Responses;

namespace Pulsar.Gateways.PushBullet
{
    public class PbDeviceGateway
    {
        private readonly PushbulletClient _pushbulletClient = new PushbulletClient(PbSettings.AccessToken);

        public  UserDevices GetDevices()
        {
            From.HouseManagerDataSource.AddPulsarLog(
               typeof(PbDeviceGateway).Namespace, typeof(PbDeviceGateway).ToString(), "Pulsar.Gateways.PushBullet",
               "GetDevices", DeviceType.PushBullet, "PushbulletClient:GetDevices",
               From.HouseManagerDataSource.GetLocation("Home").Id,
               RomanceStandardTime.ToString() + " PbDeviceGateway PushbulletClient retrieved device list");

            return _pushbulletClient.CurrentUsersDevices();
        }
    }
}