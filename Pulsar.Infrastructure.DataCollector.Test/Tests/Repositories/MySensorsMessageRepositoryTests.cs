using System.Linq;
using NUnit.Framework;

namespace Pulsar.Infrastructure.DataCollector.Test.Tests.Repositories
{
    [TestFixture]
    public class MySensorsMessageRepositoryTests : MySensorsMessageSetUp
    {
        [Test]
        public void Given_AddedMySensorsMessageToDB_CanBeFetchedFromDb()
        {
            var mySensorsMessageFromDb =
                From.HouseManagerDataSource.GetAllMySensorsMessages().SingleOrDefault(s => s.Id == MySensorsMessage.Id);

            Assert.IsNotNull(mySensorsMessageFromDb);
            Assert.AreEqual(MySensorsMessage.Id, mySensorsMessageFromDb.Id);
            Assert.IsNotNull(mySensorsMessageFromDb.RowCreated);
            Assert.AreEqual(MySensorsMessage.OriginalMessage, mySensorsMessageFromDb.OriginalMessage);
            Assert.AreEqual(MySensorsMessage.Ack, mySensorsMessageFromDb.Ack);
            Assert.AreEqual(MySensorsMessage.NodeId, mySensorsMessageFromDb.NodeId);
            Assert.AreEqual(MySensorsMessage.ChildSensorId, mySensorsMessageFromDb.ChildSensorId);
            Assert.AreEqual(MySensorsMessage.MySensorsMessageTypeId, mySensorsMessageFromDb.MySensorsMessageTypeId);
            Assert.AreEqual(MySensorsMessage.MySensorsMessageSubTypeId, mySensorsMessageFromDb.MySensorsMessageSubTypeId);
            Assert.AreEqual(MySensorsMessage.Payload, mySensorsMessageFromDb.Payload);
        }

        [Test]
        public void AllMySensorsMessagesCanBeFetchedFromDatabase()
        {
            var mySensorsMessages = From.HouseManagerDataSource.GetAllMySensorsMessages();
            Assert.IsNotNull(mySensorsMessages);
            Assert.IsTrue(mySensorsMessages.Any());
        }
    }
}