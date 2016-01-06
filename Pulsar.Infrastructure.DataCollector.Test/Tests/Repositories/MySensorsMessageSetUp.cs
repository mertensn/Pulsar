using NUnit.Framework;
using Pulsar.Contracts.Portable.DataTypes.MySensors;
using Pulsar.Test;

namespace Pulsar.Infrastructure.DataCollector.Test.Tests.Repositories
{
    public class MySensorsMessageSetUp : ScopedTestBase
    {
        protected MySensorsMessageType MySensorsMessageType;
        protected MySensorsMessageSubType MySensorsMessageSubType;
        protected MySensorsMessage MySensorsMessage;

        [SetUp]
        public void SetUp()
        {
            MySensorsMessageType = From.HouseManagerDataSource.AddMySensorsMessageType(new MySensorsMessageType
            {
                Type = "Test",
                Value = 99999,
                Comment = "TestComment"
            });

            MySensorsMessageSubType = From.HouseManagerDataSource.AddMySensorsMessageSubType(new MySensorsMessageSubType
            {
                Value = 99999,
                MessageTypeValue = MySensorsMessageType.Value,
                Comment = "TestComment",
                Type = "Temperature"
            });

            MySensorsMessage = From.HouseManagerDataSource.AddMySensorsMessage(new MySensorsMessage
            {
                Ack = 1,
                ChildSensorId = 1,
                MySensorsMessageTypeId = MySensorsMessageType.Id,
                MySensorsMessageSubTypeId = MySensorsMessageSubType.Id,
                NodeId = 1,
                OriginalMessage = "Test",
                Payload = "23.1"
            });
        }
    }
}