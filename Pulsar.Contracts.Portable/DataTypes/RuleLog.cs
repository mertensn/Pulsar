using System;
using Framework.DataClient.Portable.Interfaces;
using Pulsar.Contracts.Portable.DataTypes.Enums;

namespace Pulsar.Contracts.Portable.DataTypes
{
    public class RuleLog : IEntity
    {
        public int Id { get; set; }
        public DateTime RowCreated { get; set; }
        public string Rule { get; set; }
        public RuleAction RuleAction { get; set; }
    }
}
