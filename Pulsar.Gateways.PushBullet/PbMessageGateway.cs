using Framework.Date;
using Pulsar.Contracts.Portable.DataTypes.Enums;
using Pulsar.Infrastructure.DataCollector;
using PushbulletSharp;
using PushbulletSharp.Models.Requests;
using PushbulletSharp.Models.Responses;

namespace Pulsar.Gateways.PushBullet
{
    public class PbMessageGateway
    {
        private readonly PushbulletClient _pushbulletClient = new PushbulletClient(PbSettings.AccessToken);

        public PushResponse PushNoteToWindowsPhone(string title, string body)
        {
            var pushResponse = _pushbulletClient.PushNote(new PushNoteRequest
            {
                DeviceIden = PbSettings.WindowsPhoneDeviceIden,
                Title = title,
                Body = body
            });

            From.HouseManagerDataSource.AddPulsarLog(
                typeof(PbMessageGateway).Namespace, typeof(PbMessageGateway).ToString(), "Pulsar.Gateways.PushBullet",
                "PushNoteToWindowsPhone", DeviceType.PushBullet, "PushbulletClient:PushNoteToWindowsPhone", 
                From.HouseManagerDataSource.GetLocation("Home").Id,
                RomanceStandardTime.ToString() + " PbMessageGateway PushbulletClient pushed title '" + title + "' with body '" + body + "' to WindowsPhone");

            return pushResponse;
        }
    }
}