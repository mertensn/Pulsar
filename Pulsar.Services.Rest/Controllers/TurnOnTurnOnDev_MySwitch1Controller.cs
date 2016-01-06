using System.Web.Http;
using Pulsar.Gateways.Pimatic;

namespace Pulsar.Services.Rest.Controllers
{
    public class TurnOnTurnOnDev_MySwitch1Controller : ApiController
    {
        public bool Get()
        {
            PimSwitchGateway.TurnOnDev_MySwitch1();
            return true;
        }
    }
}
