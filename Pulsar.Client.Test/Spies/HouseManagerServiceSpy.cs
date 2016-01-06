using Pulsar.Contracts.Portable.DataTypes;

namespace Pulsar.Client.Test.Spies
{
    public static class HouseManagerServiceSpy
    {
        public static Pulse LastAddedPulse { get; set; }
    }
}
