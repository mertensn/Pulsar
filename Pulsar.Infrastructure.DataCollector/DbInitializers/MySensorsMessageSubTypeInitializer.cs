using System.Collections.Generic;
using System.Linq;
using Pulsar.Contracts.Portable.DataTypes.MySensors;

namespace Pulsar.Infrastructure.DataCollector.DbInitializers
{
    public class MySensorsMessageSubTypeInitializer
    {
        private  readonly IList<MySensorsMessageSubType> _defaultSubTypes = new List<MySensorsMessageSubType>();

        public void InitializeDefaultDatabaseValues()
        {
            _initDefaultSubTypes();

            foreach (var defaultSubType in _defaultSubTypes)
                From.HouseManagerDataSource.AddMySensorsMessageSubType(defaultSubType);
        }

        private void _initDefaultSubTypes()
        {
            _initDefaultPresentationValues();
            _initDefaultSetReqValues();
            _initDefaultInternalValues();
        }

        private MySensorsMessageSubType _createSubType(string type, int value, string comment, List<string> variables, int messageTypeValue)
        {
            return new MySensorsMessageSubType
            {
                MessageTypeValue = messageTypeValue,
                Type = type,
                Value = value,
                Comment = comment,
                Variables = variables
            };
        }

        private void _initDefaultPresentationValues()
        {
            _defaultSubTypes.Add(_createSubType("S_DOOR", 0, "Door and window sensors", new List<string> { "V_TRIPPED", "V_ARMED" }, 0));
            _defaultSubTypes.Add(_createSubType("S_MOTION", 1, "Motion sensors", new List<string> { "V_TRIPPED", "V_ARMED" }, 0));
            _defaultSubTypes.Add(_createSubType("S_SMOKE", 2, "Smoke sensor", new List<string> { "V_TRIPPED", "V_ARMED" }, 0));
            _defaultSubTypes.Add(_createSubType("S_LIGHT", 3, "Light Actuator (on/off)", new List<string> { "V_STATUS (or V_LIGHT)", " V_WATT" }, 0));
            _defaultSubTypes.Add(_createSubType("S_DIMMER", 4, "Dimmable device of some kind", new List<string> { "V_STATUS (on/off)", "V_DIMMER (dimmer level 0-100)", "V_WATT" }, 0));
            _defaultSubTypes.Add(_createSubType("S_COVER", 5, "Window covers or shades", new List<string> { "V_UP", "V_DOWN", "V_STOP", "V_PERCENTAGE" }, 0));
            _defaultSubTypes.Add(_createSubType("S_TEMP", 6, "Temperature sensor", new List<string> { "V_TEMP", "V_ID" }, 0));
            _defaultSubTypes.Add(_createSubType("S_HUM", 6, "Humidity sensor", new List<string> { "V_HUM" }, 0));
        }

        private void _initDefaultSetReqValues()
        {
            for (var i = 1; i < 3; i++)
            {
                _defaultSubTypes.Add(_createSubType("V_TEMP", 0, "Temperature", new List<string> { "S_TEMP, S_HEATER, S_HVAC" }, i));
                _defaultSubTypes.Add(_createSubType("V_HUM", 1, "Humidity", new List<string> { "S_HUM" }, i));
            }
        }

        private void _initDefaultInternalValues()
        {
            _defaultSubTypes.Add(_createSubType("I_BATTERY_LEVEL", 0, "Use this to report the battery level (in percent 0-100).", new List<string>(), 3));
            _defaultSubTypes.Add(_createSubType("I_TIME", 1, "Sensors can request the current time from the Controller using this message. The time will be reported as the seconds since 1970", new List<string>(), 3));
            _defaultSubTypes.Add(_createSubType("I_VERSION", 2, "Used to request gateway version from controller.", new List<string>(), 3));
            _defaultSubTypes.Add(_createSubType("I_ID_REQUEST", 3, "Use this to request a unique node id from the controller.", new List<string>(), 3));
            _defaultSubTypes.Add(_createSubType("I_ID_RESPONSE", 4, "Id response back to sensor. Payload contains sensor id.", new List<string>(), 3));
            _defaultSubTypes.Add(_createSubType("I_INCLUSION_MODE", 5, "Start/stop inclusion mode of the Controller (1=start, 0=stop).", new List<string>(), 3));
            _defaultSubTypes.Add(_createSubType("I_CONFIG", 6, "Config request from node. Reply with (M)etric or (I)mperal back to sensor.", new List<string>(), 3));
            _defaultSubTypes.Add(_createSubType("I_FIND_PARENT", 7, "When a sensor starts up, it broadcast a search request to all neighbor nodes. They reply with a I_FIND_PARENT_RESPONSE.", new List<string>(), 3));
            _defaultSubTypes.Add(_createSubType("I_FIND_PARENT_RESPONSE", 8, "Reply message type to I_FIND_PARENT request.", new List<string>(), 3));
            _defaultSubTypes.Add(_createSubType("I_LOG_MESSAGE", 9, "Sent by the gateway to the Controller to trace-log a message", new List<string>(), 3));
            _defaultSubTypes.Add(_createSubType("I_CHILDREN", 10, "A message that can be used to transfer child sensors (from EEPROM routing table) of a repeating node.", new List<string>(), 3));
        }
    }
}