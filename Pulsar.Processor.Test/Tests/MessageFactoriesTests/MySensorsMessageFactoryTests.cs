using System.Linq;
using NUnit.Framework;
using Pulsar.Contracts.Portable.DataTypes.MySensors;
using Pulsar.Infrastructure.DataCollector;
using Pulsar.Processor.MessageFactories;
using Pulsar.Test;

namespace Pulsar.Processor.Test.Tests.MessageFactoriesTests
{
    [TestFixture]
    public class MySensorsMessageFactoryTests : ScopedTestBase
    {
        [Test]
        [TestCase("1;0;1;0;1;50.3")]
        [TestCase("0;0;3;0;9;read: 1-1-0 s=0,c=1,t=1,pt=7,l=5,sg=0:50.3")]
        public void GivenValidInputMessage_CanBeDeserializedIntoObject(string message)
        {
            var deSerializedObject = new MySensorsMessageFactory().Deserialize(message);
            var addedMessage = From.HouseManagerDataSource.AddMySensorsMessage(deSerializedObject);
            var addedMessageFromDb = From.HouseManagerDataSource.GetAllMySensorsMessages().SingleOrDefault(s => s.Id == addedMessage.Id);

            Assert.IsNotNull(deSerializedObject);
            Assert.AreEqual(deSerializedObject.GetType(), typeof(MySensorsMessage));

            Assert.IsNotNull(addedMessageFromDb);
        }

        [Test]
        [TestCase("1;0;1;0;1;50.3")]
        public void Given_MySensorsMessage_CanBeConvertedToPulse(string message)
        {
            var messageFactory = new MySensorsMessageFactory();

            var deSerializedObject = messageFactory.Deserialize(message);
            var pulse = messageFactory.ConvertToPulse(deSerializedObject);

            Assert.IsNotNull(pulse);
        }
    }
}