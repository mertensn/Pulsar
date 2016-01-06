using System.ServiceModel;
using Pulsar.Contracts.Portable;
using Pulsar.Contracts.Portable.DataTypes;

namespace Pulsar.Contracts.Services
{
    [ServiceContract(Namespace = Constants.HouseManagerNamespace)]
    public interface IDeviceService
    {
        [OperationContract]
        string Ping();

        [OperationContract]
        Pulse TurnOnLampLiving();

        [OperationContract]
        Pulse TurnOffLampLiving();

        [OperationContract]
        Pulse TurnOnDev_MySwitch1();

        [OperationContract]
        Pulse TurnOffDev_MySwitch1();
    }
}