using System.Linq;
using NUnit.Framework;
using Pulsar.Contracts.Portable.DataTypes.MySensors;
using Pulsar.Test;

namespace Pulsar.Infrastructure.DataCollector.Test.Tests.Repositories
{
    [TestFixture]
    public class MySensorsMessageTypeRepositoryTests : MySensorsMessageSetUp
    {
        [Test]
        public void GetAllMySensorsMessageTypes_TypesAreReturnedFromDB()
        {
            var mySensorsMessageTypes = From.HouseManagerDataSource.GetAllMySensorsMessageTypes();
            Assert.IsTrue(mySensorsMessageTypes.Any());
        }

        [Test]
        public void Given_ObjectAdded_ObjectCanBeFetched()
        {
            var addedMySensorsMessageType = From.HouseManagerDataSource.AddMySensorsMessageType(new MySensorsMessageType
            {
                Type = "TestType",
                Value = 88888,
                Comment = "TestComment"
            });

            Assert.IsNotNull(addedMySensorsMessageType);
            Assert.IsNotNull(addedMySensorsMessageType.Id);
            Assert.IsNotNull(addedMySensorsMessageType.RowCreated);
            Assert.AreEqual(88888, addedMySensorsMessageType.Value);
        }

        [Test]
        public void Given_GetTypeForValue_ReturnsObject()
        {
            var mySensorsMessageType = From.HouseManagerDataSource.GetMySensorsMessageTypeForValue(MySensorsMessageType.Value);

            Assert.IsNotNull(mySensorsMessageType);
            Assert.AreEqual(99999, mySensorsMessageType.Value);
            Assert.AreEqual("Test", mySensorsMessageType.Type);
            Assert.AreEqual("TestComment", mySensorsMessageType.Comment);
        }

        [Test]
        [ExpectedPulsarException("E_PUL_IDC.004")]
        public void Given_NonExistingValueForMessageType_ThrowsException()
        {
           From.HouseManagerDataSource.GetMySensorsMessageTypeForValue(111111111);
        }

        [Test]
        public void Given_NoTypesInDatabase_InitialDataIsFilled()
        {
            var types = From.HouseManagerDataSource.GetAllMySensorsMessageTypes();
            Assert.IsNotNull(types);
        }
    }
}