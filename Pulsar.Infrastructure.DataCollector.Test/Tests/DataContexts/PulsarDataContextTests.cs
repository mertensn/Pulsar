using NUnit.Framework;
using Pulsar.Infrastructure.DataCollector.DataContexts;
using Pulsar.Infrastructure.DataCollector.DataTypes.Enums;
using Pulsar.Infrastructure.DataCollector.DbInitializers;

namespace Pulsar.Infrastructure.DataCollector.Test.Tests.DataContexts
{
    [TestFixture]
    public class PulsarDataContextTests
    {
        [Test]
        [Ignore]
        public void InitalizeLocalDatabaseData()
        {
            ContextObjects.PulsarEnvironment = Environment.Local;
            new CustomDatabaseInitializer(DbState.IsNew);
        }

        [Test]
        [Ignore]
        public void InitalizeAzureDatabaseData()
        {
            ContextObjects.PulsarEnvironment = Environment.Azure;
            new CustomDatabaseInitializer(DbState.IsNew);
        }
    }
}