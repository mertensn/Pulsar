using System.Linq;
using NUnit.Framework;
using Pulsar.Contracts.Portable.DataTypes;
using Pulsar.Contracts.Portable.DataTypes.Enums;
using Pulsar.Test;

namespace Pulsar.Infrastructure.DataCollector.Test.Tests.Repositories
{
    [TestFixture]
    public class PulsarLogRepositoryTests : ScopedTestBase
    {
        private PulsarLog _pulsarLog;
        private Location _homeLocation;

        [SetUp]
        public void SetUp()
        {
             _homeLocation = From.HouseManagerDataSource.GetLocation("Home");
             _pulsarLog = From.HouseManagerDataSource.AddPulsarLog(new PulsarLog
            {
                NameSpace = typeof(PulsarLogRepositoryTests).Namespace,
                Class = typeof(PulsarLogRepositoryTests).ToString(),
                Project = "Pulsar.Infrastructure.DataCollector.Test",
                Method = "Given_AddPulsarLog_PulsarLogIsAddedToDatabase",
                DeviceType = DeviceType.Test,
                LocationId = _homeLocation.Id,
                Message = "Given_AddPulsarLog_PulsarLogIsAddedToDatabase:RunTest",
                Value = "Running Test to check AddPulsarLog"
            });
        }

        [Test]
        public void Given_AddPulsarLog_PulsarLogIsAddedToDatabase()
        {
            Assert.IsNotNull(_pulsarLog);
            Assert.IsNotNull(_pulsarLog.Id);
            Assert.IsNotNull(_pulsarLog.RowCreated);
            Assert.AreEqual(typeof(PulsarLogRepositoryTests).Namespace, _pulsarLog.NameSpace);
            Assert.AreEqual(typeof(PulsarLogRepositoryTests).ToString(), _pulsarLog.Class);
            Assert.AreEqual("Pulsar.Infrastructure.DataCollector.Test", _pulsarLog.Project);
            Assert.AreEqual("Given_AddPulsarLog_PulsarLogIsAddedToDatabase", _pulsarLog.Method);
            Assert.AreEqual(DeviceType.Test, _pulsarLog.DeviceType);
            Assert.AreEqual(_pulsarLog.LocationId, _pulsarLog.LocationId);
            Assert.AreEqual("Given_AddPulsarLog_PulsarLogIsAddedToDatabase:RunTest", _pulsarLog.Message);
            Assert.AreEqual("Running Test to check AddPulsarLog", _pulsarLog.Value);
        }

        [Test]
        public void Given_GetAllPulsarLogs_ReturnsCollection()
        {
            var allPulsarLogs = From.HouseManagerDataSource.GetAllPulsarLogs();
            Assert.IsNotNull(allPulsarLogs);
            Assert.IsTrue(allPulsarLogs.Any());
        }

        [Test]
        public void Given_GetPulsarLog_ReturnsCollection_AssertProperties()
        {
            var allPulsarLogs = From.HouseManagerDataSource.GetPulsarLog(_pulsarLog.Id);
            Assert.IsNotNull(allPulsarLogs);
            Assert.IsNotNull(allPulsarLogs.Id);
            Assert.IsNotNull(allPulsarLogs.RowCreated);
            Assert.AreEqual(typeof(PulsarLogRepositoryTests).Namespace, allPulsarLogs.NameSpace);
            Assert.AreEqual(typeof(PulsarLogRepositoryTests).ToString(), allPulsarLogs.Class);
            Assert.AreEqual("Pulsar.Infrastructure.DataCollector.Test", allPulsarLogs.Project);
            Assert.AreEqual("Given_AddPulsarLog_PulsarLogIsAddedToDatabase", allPulsarLogs.Method);
            Assert.AreEqual(DeviceType.Test, allPulsarLogs.DeviceType);
            Assert.AreEqual(_pulsarLog.LocationId, allPulsarLogs.LocationId);
            Assert.AreEqual("Given_AddPulsarLog_PulsarLogIsAddedToDatabase:RunTest", allPulsarLogs.Message);
            Assert.AreEqual("Running Test to check AddPulsarLog", allPulsarLogs.Value);
        }
    }
}