using System.Collections.Generic;
using System.Linq;
using Pulsar.Contracts.Portable.DataTypes.MySensors;

namespace Pulsar.Infrastructure.DataCollector.DbInitializers
{
    public class MySensorsMessageTypeInitializer
    {
        public void InitializeDefaultDatabaseValues()
        {
            var defaultTypes = new List<MySensorsMessageType>
            {
                _createType("presentation", 0, "Sent by a node when they present attached sensors. This is usually done in setup() at startup"),
                _createType("set", 1, "This message is sent from or to a sensor when a sensor value should be updated"),
                _createType("req", 2, "Requests a variable value (usually from an actuator destined for controller)"),
                _createType("internal", 3, "This is a special internal message. See table below for the details"),
                _createType("stream", 4, "Used for OTA firmware updates")
            };

            foreach (var type in defaultTypes)
                From.HouseManagerDataSource.AddMySensorsMessageType(type);
        }

        private static MySensorsMessageType _createType(string type, int value, string comment)
        {
            return new MySensorsMessageType
            {
                Type = type,
                Value = value,
                Comment = comment
            };
        }
    }
}