using System.Linq;
using NUnit.Framework;
using Pulsar.Contracts.Portable.DataTypes.MySensors;
using Pulsar.Test;

namespace Pulsar.Infrastructure.DataCollector.Test.Tests.Repositories
{
    [TestFixture]
    public class MySensorsMessageSubTypeRepositoryTests : MySensorsMessageSetUp
    {
        [Test]
        public void Given_NoSubTypesInDatabase_InitialDataIsFilled()
        {
            var subTypes = From.HouseManagerDataSource.GetAllMySensorsMessageSubTypes();
            Assert.IsNotNull(subTypes);
        }

        [Test]
        public void GetAllMySensorsMessageSubTypes_ReturnsAny()
        {
            var mySensorsMessageSubTypes = From.HouseManagerDataSource.GetAllMySensorsMessageSubTypes();

            Assert.IsNotNull(mySensorsMessageSubTypes);
            Assert.IsTrue(mySensorsMessageSubTypes.Any());
        }

        [Test]
        public void Given_GetSubTypesForTypeValue_SubTypesReturned()
        {
            var mySensorsMessageSubTypes =
                From.HouseManagerDataSource.GetAllMySensorsMessageSubTypesForTypeValue(MySensorsMessageType.Value);

            Assert.IsNotNull(mySensorsMessageSubTypes);
            Assert.IsTrue(mySensorsMessageSubTypes.Any());
        }

        [Test]
        [ExpectedPulsarException("E_PUL_IDC.005")]
        public void Given_GetSubTypesForNonExistingTypeValue_ThrowsException()
        {
            From.HouseManagerDataSource.GetAllMySensorsMessageSubTypesForTypeValue(-1);
        }

        [Test]
        public void MySensorsMessageSubTypeIsAdded()
        {
            var mySensorsMessageSubType = From.HouseManagerDataSource.AddMySensorsMessageSubType(new MySensorsMessageSubType
            {
                Value = 1111111,
                MessageTypeValue = MySensorsMessageType.Value,
                Comment = "Test",
                Type = "Temperature"
            });

            Assert.IsNotNull(mySensorsMessageSubType);
            Assert.IsNotNull(mySensorsMessageSubType.Id);
            Assert.IsNotNull(mySensorsMessageSubType.RowCreated);
            Assert.AreEqual(1111111, mySensorsMessageSubType.Value);
            Assert.AreEqual("Test", mySensorsMessageSubType.Comment);
            Assert.AreEqual("Temperature", mySensorsMessageSubType.Type);
            Assert.AreEqual(MySensorsMessageType.Value, mySensorsMessageSubType.MessageTypeValue);
        }

        [Test]
        public void Given_GetMySensorsMessageSubTypeForValue_ReturnsMySensorsMessageSubType()
        {
            var mySensorsMessageSubTypeFromDb =
                From.HouseManagerDataSource.GetMySensorsMessageSubTypeForValue(MySensorsMessageType.Value,
                    MySensorsMessageSubType.Value);

            Assert.IsNotNull(mySensorsMessageSubTypeFromDb);
            Assert.AreEqual(MySensorsMessageSubType.Id, mySensorsMessageSubTypeFromDb.Id);
            Assert.AreEqual(MySensorsMessageSubType.Value, mySensorsMessageSubTypeFromDb.Value);
            Assert.AreEqual(MySensorsMessageSubType.Comment, mySensorsMessageSubTypeFromDb.Comment);
            Assert.AreEqual(MySensorsMessageSubType.Type, mySensorsMessageSubTypeFromDb.Type);
            Assert.AreEqual(MySensorsMessageType.Value, mySensorsMessageSubTypeFromDb.MessageTypeValue);
        }

        [Test]
        [ExpectedPulsarException("E_PUL_IDC.009")]
        public void Given_GetMySensorsMessageSubTypeForNonExistingValue_ThrowsException()
        {
            From.HouseManagerDataSource.GetMySensorsMessageSubTypeForValue(MySensorsMessageType.Value, -1);
        }
    }
}