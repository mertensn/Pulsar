using System.Collections.Generic;
using System.Web.Http;
using Pulsar.Contracts.Portable.DataTypes;
using Pulsar.Contracts.Portable.Exceptions;
using Pulsar.Infrastructure.DataCollector;

namespace Pulsar.Services.Rest.Controllers
{
    public class PulsarLogController : ApiController
    {
        public IEnumerable<PulsarLog> Get()
        {
            return From.HouseManagerDataSource.GetAllPulsarLogs();
        }

        public PulsarLog Get(int id)
        {
            return From.HouseManagerDataSource.GetPulsarLog(id);
        }

        public PulsarLog Post(PulsarLog pulsarLog)
        {
            return From.HouseManagerDataSource.AddPulsarLog(pulsarLog);
        }

        public void Put(PulsarLog pulsarLog)
        {
            From.HouseManagerDataSource.AddPulsarLog(pulsarLog);
        }

        public void Delete(int id)
        {
            throw new PulsarException("E_PUL_SREST.001", "PulsarLogController Delete method not implemented");
        }
    }
}
