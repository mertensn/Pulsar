using System;
using System.Collections.Generic;
using Pulsar.Client.Test.Spies;
using Pulsar.Contracts.Portable.DataTypes;
using Pulsar.Contracts.Services;

namespace Pulsar.Client.Test.Fakes
{
    public class HouseManagerServiceFake : IHouseManagerService
    {
        private readonly Pulse _pulse;

        public HouseManagerServiceFake()
        {
            _pulse = new Pulse
            {
                Id = 1,
                RowCreated = DateTime.Now,
                DeviceId = 0,
                Value = "23"
            };
        }

        public string Ping()
        {
            return "HouseManagerServiceFake_pong";
        }

        public Pulse AddPulse(Pulse pulse)
        {
            HouseManagerServiceSpy.LastAddedPulse = pulse;
            return pulse;
        }

        public IEnumerable<Pulse> GetPulsesForLocation(int locationId)
        {
            return new List<Pulse> {_pulse, _pulse};
        }

        public Device AddDevice(Device device)
        {
            throw new NotImplementedException();
        }
    }
}
