using System.Web.Http;
using Pulsar.Gateways.Pimatic;

namespace Pulsar.Services.Rest.Controllers
{
    public class TurnOnLampLivingController : ApiController
    {
        public bool Get()
        {
            PimSwitchGateway.TurnOnLampLiving();
            return true;
        }
    }
}
