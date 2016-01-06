using NUnit.Framework;
using Pulsar.Infrastructure.DataCollector;

namespace Pulsar.Test
{
    [TestFixture]
    public class InitDatabaseTests
    {
        [Test]
        [Ignore]
        public void InitDatabase()
        {
            From.HouseManagerDataSource.GetAllMySensorsMessageTypes();
            From.HouseManagerDataSource.GetAllMySensorsMessageSubTypes();
            From.HouseManagerDataSource.GetAllLocations();
            From.HouseManagerDataSource.GetAllDevices();
            From.HouseManagerDataSource.GetAllDevices();
        }
    }
}