using System.Web.Http;
using Framework.Date;
using Pulsar.Contracts.Portable.DataTypes.Enums;
using Pulsar.Infrastructure.DataCollector;

namespace Pulsar.Services.Rest.Controllers
{
    public class PingController : ApiController
    {
        public string Get()
        {
            From.HouseManagerDataSource.AddPulsarLog(
               typeof(PingController).Namespace, typeof(PingController).ToString(), "Pulsar.Services.Rest",
               "Ping", DeviceType.WebService, "PingController:Get", From.HouseManagerDataSource.GetLocation("Internal").Id,
               RomanceStandardTime.ToString() + " PingController Get");
           return  "pong";
        }
    }
}
