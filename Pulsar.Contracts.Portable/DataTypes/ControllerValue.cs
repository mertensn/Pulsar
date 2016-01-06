using System;
using Framework.DataClient.Portable.Interfaces;

namespace Pulsar.Contracts.Portable.DataTypes
{
    public class ControllerValue : IEntity
    {
        public int Id { get; set; }
        public DateTime RowCreated { get; set; }
        public string Controller { get; set; }
        public string ControllerComponent { get; set; }
        public string Value { get; set; }
    }
}