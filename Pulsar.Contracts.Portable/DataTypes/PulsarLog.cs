using System;
using Framework.DataClient.Portable.Interfaces;
using Pulsar.Contracts.Portable.DataTypes.Enums;

namespace Pulsar.Contracts.Portable.DataTypes
{
    public class PulsarLog : IEntity
    {
        public int Id { get; set; }
        public DateTime RowCreated { get; set; }
        public string NameSpace { get; set; }
        public string Project { get; set; }
        public string Class { get; set; }
        public string Method { get; set; }
        public DeviceType DeviceType { get; set; }
        public string Message { get; set; }
        public Location Location { get; set; }
        public int LocationId { get; set; }
        public string Value { get; set; }
    }
}
