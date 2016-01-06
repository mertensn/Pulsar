using System;
using Framework.Date;
using Pulsar.Contracts.Portable.DataTypes;
using Pulsar.Contracts.Portable.DataTypes.Enums;
using Pulsar.Contracts.Portable.DataTypes.MySensors;
using Pulsar.Infrastructure.DataCollector;

namespace Pulsar.Processor.MessageFactories
{
    public class MySensorsMessageFactory
    {
        public MySensorsMessage Deserialize(string message)
        {
            try
            {
                var mySensorsMessage = new MySensorsMessage();
                mySensorsMessage.OriginalMessage = message;

                mySensorsMessage.NodeId = Int32.Parse(message.Substring(0, message.IndexOf(";")));
                message = _recomposeMessage(message);

                mySensorsMessage.ChildSensorId = Int32.Parse(message.Substring(0, message.IndexOf(";")));
                message = _recomposeMessage(message);

                var messageTypeValue = Int32.Parse(message.Substring(0, message.IndexOf(";")));
                var messageType = From.HouseManagerDataSource.GetMySensorsMessageTypeForValue(messageTypeValue);
                mySensorsMessage.MySensorsMessageTypeId = messageType.Id;
                message = _recomposeMessage(message);

                mySensorsMessage.Ack = Int32.Parse(message.Substring(0, message.IndexOf(";")));
                message = _recomposeMessage(message);

                var messageSubTypevalue = Int32.Parse(message.Substring(0, message.IndexOf(";")));
                var messageSubType = From.HouseManagerDataSource.GetMySensorsMessageSubTypeForValue(messageTypeValue, messageSubTypevalue);
                mySensorsMessage.MySensorsMessageSubTypeId = messageSubType.Id;

                mySensorsMessage.Payload = _recomposeMessage(message);
                return mySensorsMessage;
            }
            catch (Exception ex)
            {
                From.HouseManagerDataSource.AddPulsarLog(
                     typeof(MySensorsMessageFactory).Namespace, typeof(MySensorsMessageFactory).ToString(), "Pulsar.Processor",
                     "Deserialize", DeviceType.Sensor, "MySensorsMessageFactory:Deserialize", From.HouseManagerDataSource.GetLocation("Home").Id,
                     RomanceStandardTime.ToString() +
                     " MySensorsMessageFactory failed to Deserialize message into MySensorsMessage with reason " + ex);
            }
            return null;
        }

        public Pulse ConvertToPulse(MySensorsMessage mySensorsMessage)
        {
            try
            {
                var device = From.HouseManagerDataSource
                                .GetDevice(mySensorsMessage.NodeId.ToString(), mySensorsMessage.ChildSensorId.ToString(),
                                NavigationPropertyState.Omit);

                return new Pulse
                {
                    DeviceId = device.Id,
                    Value = mySensorsMessage.Payload
                };
            }
            catch (Exception ex)
            {
                From.HouseManagerDataSource.AddPulsarLog(
                     typeof(MySensorsMessageFactory).Namespace, typeof(MySensorsMessageFactory).ToString(), "Pulsar.Processor",
                     "ConvertToPulse", DeviceType.Sensor, "MySensorsMessageFactory:ConvertToPulse", From.HouseManagerDataSource.GetLocation("Home").Id,
                     RomanceStandardTime.ToString() +
                     " MySensorsMessageFactory failed to Convert deserialized message into Pulse with reason " + ex);
            }
            return null;
        }

        private static string _recomposeMessage(string message)
        {
            return message.Substring(message.IndexOf(";") + 1);
        }
    }
}