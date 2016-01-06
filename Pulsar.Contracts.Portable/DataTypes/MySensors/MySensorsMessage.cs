using System;
using Framework.DataClient.Portable.Interfaces;

namespace Pulsar.Contracts.Portable.DataTypes.MySensors
{
    public class MySensorsMessage : IEntity
    {
        public int Id { get; set; }
        public DateTime RowCreated { get; set; }
        public string OriginalMessage { get; set; }
        public int NodeId { get; set; }
        public int ChildSensorId { get; set; }
        public MySensorsMessageType MySensorsMessageType { get; set; }
        public int MySensorsMessageTypeId { get; set; }
        public int Ack { get; set; }
        public MySensorsMessageSubType MySensorsMessageSubType { get; set; }
        public int MySensorsMessageSubTypeId { get; set; }
        public string Payload { get; set; }
    }
}
