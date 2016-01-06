using Framework.ServiceClient;
using Pulsar.Contracts.Services;

namespace Pulsar.Client
{
    public class HouseManagerServiceClientFactory : ServiceClientFactory<IHouseManagerService>
    {
        public HouseManagerServiceClientFactory() :
            base("Services", "HouseManagerService")
        {
            EnableDirectClient();
            EnableInjectedClient();
        }
    }
}
