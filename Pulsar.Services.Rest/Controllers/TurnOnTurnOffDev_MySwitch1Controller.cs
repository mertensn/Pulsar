using System.Web.Http;
using Pulsar.Gateways.Pimatic;

namespace Pulsar.Services.Rest.Controllers
{
    public class TurnOnTurnOffDev_MySwitch1Controller : ApiController
    {
        public bool Get()
        {
            PimSwitchGateway.TurnOffDev_MySwitch1();
            return true;
        }
    }
}
