using System;
using System.Collections.Generic;
using Framework.DataClient.Portable.Interfaces;

namespace Pulsar.Contracts.Portable.DataTypes.MySensors
{
    public class MySensorsMessageSubType : IEntity
    {
        public int Id { get; set; }
        public DateTime RowCreated { get; set; }
        public int Value { get; set; }
        public string Type { get; set; }
        public string Comment { get; set; }
        public List<string> Variables { get; set; }
        public int MessageTypeValue { get; set; }
    }
}