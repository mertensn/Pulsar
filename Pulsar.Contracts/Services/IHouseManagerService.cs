using System.ServiceModel;
using Pulsar.Contracts.Portable;
using Pulsar.Contracts.Portable.DataTypes;

namespace Pulsar.Contracts.Services
{
    [ServiceContract(Namespace = Constants.HouseManagerNamespace)]
    public interface IHouseManagerService
    {
        [OperationContract]
        string Ping();

        [OperationContract]
        Pulse AddPulse(Pulse pulse);

        [OperationContract]
        Device AddDevice(Device device);
    }
}
