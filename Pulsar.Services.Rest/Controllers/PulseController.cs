using System.Collections.Generic;
using System.Web.Http;
using Pulsar.Contracts.Portable.DataTypes;
using Pulsar.Infrastructure.DataCollector;

namespace Pulsar.Services.Rest.Controllers
{
    public class PulseController : ApiController
    {
        public IEnumerable<Pulse> Get()
        {
            return From.HouseManagerDataSource.GetAllPulses();
        }

        public Pulse Get(int id)
        {
            return From.HouseManagerDataSource.GetPulse(id);
        }

        public Pulse Post(Pulse pulse)
        {
            return From.HouseManagerDataSource.AddPulse(pulse);
        }

        public void Put(Pulse pulse)
        {
            From.HouseManagerDataSource.AddPulse(pulse);
        }

        public void Delete(int id)
        {
            From.HouseManagerDataSource.DeletePulse(id);
        }
    }
}
