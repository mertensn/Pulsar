using System;
using System.Runtime.Serialization;
using Framework.DataClient.Portable.Interfaces;

namespace Pulsar.Contracts.Portable.DataTypes
{
    [DataContract(Name = "Pulse", Namespace = Constants.HouseManagerNamespace)]
    public class Pulse : IEntity
    {
        [DataMember(Order = 1)]
        public int Id { get; set; }

        [DataMember(Order = 2)]
        public DateTime RowCreated { get; set; }

        [DataMember(Order = 3)]
        public string Value { get; set; }

        [DataMember(Order = 4)]
        public Device Device { get; set; }

        [DataMember(Order = 5)]
        public int DeviceId { get; set; }

        public bool Equals(IEntity other)
        {
            return Id == other.Id;
        }
    }
}