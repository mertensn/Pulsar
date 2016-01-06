using System.Web.Http;
using Pulsar.Infrastructure.DataCollector;

namespace Pulsar.Services.Rest.Controllers
{
    public class GetHumidityKitchenController : ApiController
    {
        public string Get()
        {
           return From.DeviceDataSource.GetHumidityKitchen();
        }
    }
}
