using System;
using System.Runtime.Serialization;
using Framework.DataClient.Portable.Interfaces;
using Pulsar.Contracts.Portable.DataTypes.Enums;

namespace Pulsar.Contracts.Portable.DataTypes
{
    [DataContract(Name = "Device", Namespace = Constants.HouseManagerNamespace)]
    public class Device : IEntity
    {
        [DataMember(Order = 1)]
        public int Id { get; set; }

        [DataMember(Order = 2)]
        public DateTime RowCreated { get; set; }

        [DataMember(Order = 3)]
        public string Name { get; set; } //dev_switch1, DHT22

        [DataMember(Order = 4)]
        public string DeviceIdentifier { get; set; } //dev_switch1, 1

        [DataMember(Order = 5)]
        public string SensorId { get; set; }

        [DataMember(Order = 6)]
        public DeviceType DeviceType { get; set; }

        [DataMember(Order = 7)]
        public string Class { get; set; } //HomeduinoRFSwitch

        [DataMember(Order = 8)]
        public PulseType PulseType { get; set; }

        [DataMember(Order = 9)]
        public DeviceHardware DeviceHardware { get; set; }

        [DataMember(Order = 11)]
        public Location Location { get; set; }

        [DataMember(Order = 12)]
        public int LocationId { get; set; }
    }
}