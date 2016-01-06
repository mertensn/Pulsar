using System;
using System.Collections.Generic;
using Framework.DataClient.Portable.Interfaces;

namespace Pulsar.Contracts.Portable.DataTypes
{
    public class Location : IEntity
    {
        public int Id { get; set; }
        public DateTime RowCreated { get; set; }
        public string Name { get; set; }
        public ICollection<Pulse> Pulses { get; set; }
    }
}
