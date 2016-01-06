using System.Web.Http;
using Pulsar.Gateways.Pimatic;

namespace Pulsar.Services.Rest.Controllers
{
    public class TurnOffLampLivingController : ApiController
    {
        public bool Get()
        {
            PimSwitchGateway.TurnOffLampLiving();
            return true;
        }
    }
}
