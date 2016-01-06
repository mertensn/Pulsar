using System;
using System.Collections.Generic;
using System.Linq;
using Framework.Date;
using Pulsar.Contracts.Portable.DataTypes;
using Pulsar.Contracts.Portable.DataTypes.Enums;
using Pulsar.Contracts.Portable.DataTypes.MySensors;
using Pulsar.Contracts.Portable.Exceptions;
using Pulsar.Infrastructure.DataCollector.Repositories;

namespace Pulsar.Infrastructure.DataCollector.DataSources
{
    /// <summary>
    /// Use this DataSource to retreive data from the database which is related to internal Pulsar objects i.e. device, pulse, log, ... data
    /// </summary>
    public class HouseManagerDataSource
    {
        public IEnumerable<Pulse> GetAllPulsesForLocation(int locationId)
        {
            var pulses = new List<Pulse>();
            var devicesForLocation = GetDevicesForLocation(locationId).ToList();
            foreach (var device in devicesForLocation)
                pulses.AddRange(new PulseRepository().Get().Where(s => s.DeviceId == device.Id));
            
            if (!pulses.Any())
                throw new PulsarException("E_PUL_IDC.013", "Pulses for LocationId {0} could not be found in database", locationId);

            return pulses;
        }

        public IEnumerable<ControllerValue> GetAllControllerValues()
        {
            var controllerValues = new ControllerValueRepository().Get();
            if (!controllerValues.Any())
                throw new PulsarException("E_PUL_IDC.002", "ControllerValues could not be captured from database");
            return controllerValues;
        }

        public IEnumerable<PulsarLog> GetAllPulsarLogs()
        {
            var pulsarLogs = new PulsarLogRepository().Get();
            if (!pulsarLogs.Any())
                throw new PulsarException("E_PUL_IDC.024", "PulsarLogs could not be captured from database");
            return pulsarLogs;
        }

        public PulsarLog GetPulsarLog(int id)
        {
            var pulsarLog = new PulsarLogRepository().Get(id);
            if (pulsarLog == null)
                throw new PulsarException("E_PUL_IDC.025", "PulsarLog for Id {0} could not be found in database", id);
            return pulsarLog;
        }

        public ControllerValue AddControllerValue(ControllerValue controllerValue)
        {
            if (string.IsNullOrEmpty(controllerValue.Controller) || 
                string.IsNullOrEmpty(controllerValue.ControllerComponent) || 
                string.IsNullOrEmpty(controllerValue.Value))
                    throw new PulsarException("E_PUL_IDC.028", "Not all required fields are filled in to add a ControllerValue");
            
            return new ControllerValueRepository().Add(controllerValue);
        }

        public ControllerValue GetControllerValue(string controller, string controllerComponent)
        {
            var controllerValue = new ControllerValueRepository().Get().SingleOrDefault(s => s.Controller == controller && s.ControllerComponent == controllerComponent);
            if (controllerValue == null)
                throw new PulsarException("E_PUL_IDC.026", 
                    "ControllerValue for Controller {0} and ControllerComponent {1} could not be found in database", controller, controllerComponent);
            
            return controllerValue;
        }

        public Pulse GetPulse(int id)
        {
            var pulse = new PulseRepository().Get(id);
            if (pulse == null)
                throw new PulsarException("E_PUL_IDC.021", "Pulse for Id {0} could not be found in database", id);
            
            return pulse;
        }

        public IEnumerable<Device> GetDevicesForLocation(int locationId)
        {
            var devices = new DeviceRepository().Get(NavigationPropertyState.Include).Where(s => s.LocationId == locationId);
            if (!devices.Any())
                throw new PulsarException("E_PUL_IDC.012", "Devices for LocationId {0} could not be found in database", locationId);
            return devices;
        }

        public IEnumerable<Device> GetDevicesForLocation(string name)
        {
            var location = From.HouseManagerDataSource.GetLocation(name);
            var devices = new DeviceRepository().Get(NavigationPropertyState.Include).Where(s => s.LocationId == location.Id);
            if (!devices.Any())
                throw new PulsarException("E_PUL_IDC.027", "Devices for Location name {0} could not be found in database", name);
            return devices;
        }

        public IQueryable<Device> GetAllDevices()
        {
            var devices = new DeviceRepository().Get(NavigationPropertyState.Include);
            if (!devices.Any())
                throw new PulsarException("E_PUL_IDC.006", "Devices could not be captured from database");
            
            return devices;
        }

        public Device GetDevice(string deviceIdentifier, string sensorId, NavigationPropertyState navigationPropertyState)
        {
            Device device;

            if (sensorId == null)
                device = new DeviceRepository().Get(navigationPropertyState)
                    .SingleOrDefault(s => s.DeviceIdentifier == deviceIdentifier.ToString());
            else
                device = new DeviceRepository().Get(navigationPropertyState)
                .SingleOrDefault(s => s.DeviceIdentifier == deviceIdentifier.ToString() && s.SensorId == sensorId);

            if (device == null)
                throw new PulsarException("E_PUL_IDC.011", 
                    "Device for DeviceIdentifier {0} and SensorId {1} could not be found in database", 
                    deviceIdentifier, sensorId);
                
            return device;
        }

        public Device GetDevice(int deviceId, NavigationPropertyState navigationPropertyState)
        {
            var device = new DeviceRepository().Get(navigationPropertyState).SingleOrDefault(s => s.Id == deviceId);
            if (device == null)
                throw new PulsarException("E_PUL_IDC.010", "Device for DeviceId {0} could not be found in database", deviceId);

            return device;
        }

        public Device AddDevice(Device device)
        {
            if (device.LocationId == 0)
                throw new PulsarException("E_PUL_IDC.003", "LocationId cannot be 0 when adding a Device");
            if (new DeviceRepository().Get(NavigationPropertyState.Omit).Any(s => s.DeviceIdentifier == device.DeviceIdentifier && s.SensorId == device.SensorId))
                throw new PulsarException("E_PUL_IDC.014", "Device for DeviceIdentifier {0} already exists in database", device.DeviceIdentifier);  
            
            AddPulsarLog(typeof(HouseManagerDataSource).Namespace, typeof(HouseManagerDataSource).ToString(),
                "Pulsar.Infrastructure.DataCollector", "AddDevice", DeviceType.Internal,
                "HouseManagerDataSource:AddDevice", device.LocationId,
                RomanceStandardTime.ToString() + " HouseManagerDataSource Added Device with Name " + device.Name);

            return new DeviceRepository().Add(device);
        }

        public IEnumerable<MySensorsMessageType> GetAllMySensorsMessageTypes()
        {
            var mySensorsMessageTypes =  new MySensorsMessageTypeRepository().Get();
            if (!mySensorsMessageTypes.Any())
                throw new PulsarException("E_PUL_IDC.015", "MySensorsMessageTypes could not be found in database");
            
            return mySensorsMessageTypes;
        }

        public MySensorsMessageType GetMySensorsMessageTypeForValue(int value)
        {
            var mySensorsMessage = new MySensorsMessageTypeRepository().Get().SingleOrDefault(s => s.Value == value);
            if (mySensorsMessage == null)
                throw new PulsarException("E_PUL_IDC.004", "MySensorsMessageType could not be found for Value {0}", value);
            
            return mySensorsMessage;
        }

        public IEnumerable<MySensorsMessageSubType> GetAllMySensorsMessageSubTypesForTypeValue(int messageTypeValue)
        {
            var mySensorsMessageSubTypes =  new MySensorsMessageSubTypeRepository().Get().Where(s => s.MessageTypeValue == messageTypeValue);
            if (!mySensorsMessageSubTypes.Any())
                throw new PulsarException("E_PUL_IDC.005", "MySensorsMessageSubTypes could not be found for TypeValue {0}", messageTypeValue);
            
            return mySensorsMessageSubTypes;
        }

        public MySensorsMessageSubType GetMySensorsMessageSubTypeForValue(int messageTypeValue, int value)
        {
            var mySensorsMessageSubType = GetAllMySensorsMessageSubTypesForTypeValue(messageTypeValue).SingleOrDefault(s => s.Value == value);
            if (mySensorsMessageSubType == null)
                throw new PulsarException("E_PUL_IDC.009", "MySensorsMessageSubType for MessageTypeValue {0} and Value {1} could not be found in database", 
                    messageTypeValue, value);
            
            return mySensorsMessageSubType;
        }

        public IEnumerable<MySensorsMessage> GetAllMySensorsMessages()
        {
            var mySensorsMessages = new MySensorsMessageRepository().Get();
            if (!mySensorsMessages.Any())
                throw new PulsarException("E_PUL_IDC.016", "MySensorsMessages could not be found in database");
            
            return mySensorsMessages;
        }

        public MySensorsMessage AddMySensorsMessage(MySensorsMessage mySensorsMessage)
        {
            AddPulsarLog(typeof(HouseManagerDataSource).Namespace, typeof(HouseManagerDataSource).ToString(),
                "Pulsar.Infrastructure.DataCollector", "AddMySensorsMessage", DeviceType.Internal,
                "HouseManagerDataSource:AddMySensorsMessage", From.HouseManagerDataSource.GetLocation("Internal").Id,
                RomanceStandardTime.ToString() + " Deserialized message " + mySensorsMessage.OriginalMessage);

            return new MySensorsMessageRepository().Add(mySensorsMessage);
        }

        public MySensorsMessageType AddMySensorsMessageType(MySensorsMessageType mySensorsMessageType)
        {
            AddPulsarLog(typeof(HouseManagerDataSource).Namespace, typeof(HouseManagerDataSource).ToString(),
                "Pulsar.Infrastructure.DataCollector", "AddMySensorsMessageType", DeviceType.Internal,
                "HouseManagerDataSource:AddMySensorsMessageType", From.HouseManagerDataSource.GetLocation("Internal").Id,
                RomanceStandardTime.ToString() + " Added MySensorsMessageType Type " + mySensorsMessageType.Type);

            return new MySensorsMessageTypeRepository().Add(mySensorsMessageType);
        }

        public MySensorsMessageSubType AddMySensorsMessageSubType(MySensorsMessageSubType mySensorsMessageSubType)
        {
            AddPulsarLog(typeof(HouseManagerDataSource).Namespace, typeof(HouseManagerDataSource).ToString(),
                "Pulsar.Infrastructure.DataCollector", "AddMySensorsMessageSubType", DeviceType.Internal,
                "HouseManagerDataSource:AddMySensorsMessageSubType", From.HouseManagerDataSource.GetLocation("Internal").Id,
                RomanceStandardTime.ToString() + " Added MySensorsMessageSubType Type " + mySensorsMessageSubType.Type);

            return new MySensorsMessageSubTypeRepository().Add(mySensorsMessageSubType);
        }

        public IEnumerable<MySensorsMessageSubType> GetAllMySensorsMessageSubTypes()
        {
            var mySensorsSubTypes = new MySensorsMessageSubTypeRepository().Get();
            if (!mySensorsSubTypes.Any())
            {
                throw new PulsarException("E_PUL_IDC.017", "MySensorsSubTypes could not be found in database");
            }
            return mySensorsSubTypes;
        }

        public IEnumerable<Pulse> GetAllPulses()
        {
            var pulses = new PulseRepository().Get();
            if (!pulses.Any())
            {
                throw new PulsarException("E_PUL_IDC.018", "Pulses could not be found in database");
            }
            return pulses;
        }

        public Pulse AddPulse(Pulse pulse)
        {
            if (string.IsNullOrEmpty(pulse.Value)) return null;

            var device = pulse.Device ?? From.HouseManagerDataSource.GetDevice(pulse.DeviceId, NavigationPropertyState.Omit);

            AddPulsarLog(typeof(HouseManagerDataSource).Namespace, typeof(HouseManagerDataSource).ToString(),
                "Pulsar.Infrastructure.DataCollector", "AddPulse", DeviceType.Internal,
                "HouseManagerDataSource:AddPulse", device.LocationId,
                RomanceStandardTime.ToString() + " HouseManagerDataSource Added Pulse for DeviceId " + pulse.DeviceId + " with value " + pulse.Value);

            return new PulseRepository().Add(pulse);
        }

        public bool DeletePulse(int id)
        {
            var pulseRepository = new PulseRepository();
            if (pulseRepository.Get(id) == null) return true;

            try
            {
                pulseRepository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new PulsarException("E_PUL_IDC.023", "Pulse for id {0} could not be deleted from database with reason {1}", 
                    id, ex.Message);
            }

            return true;
        }

        public IEnumerable<Pulse> AddPulses(IEnumerable<Pulse> pulses)
        {
            var pulseList = pulses.ToList();
            foreach (var pulse in pulseList)
                AddPulse(pulse);
            return pulseList;
        }

        public Location AddLocation(Location location)
        {
            if (new LocationRepository().Get().SingleOrDefault(s => s.Name == location.Name) != null)
                throw new PulsarException("E_PUL_IDC.008", "Location with Name {0} already exists in database", location.Name);
            
            var addedLocation = new LocationRepository().Add(location);
            AddPulsarLog(typeof (HouseManagerDataSource).Namespace, typeof (HouseManagerDataSource).ToString(),
                "Pulsar.Infrastructure.DataCollector", "AddLocation", DeviceType.Internal,
                "HouseManagerDataSource:AddLocation", addedLocation.Id,
                RomanceStandardTime.ToString() + " HouseManagerDataSource Added Location with Name " + addedLocation.Name);

            return addedLocation;
        }

        public Location GetLocation(string name)
        {
            var location = new LocationRepository().Get().SingleOrDefault(s => s.Name == name);
            if (location == null)
                throw new PulsarException("E_PUL_IDC.007", "Location for Name {0} could not be found in database", name);
            
            return location;
        }

        public IQueryable<Location> GetAllLocations()
        {
            var locations = new LocationRepository().Get();
            if (!locations.Any())
                throw new PulsarException("E_PUL_IDC.019", "Locations could not be found in database");
            
            return locations;
        }

        public RuleLog AddRuleLog(RuleLog ruleLog)
        {
            AddPulsarLog(typeof(HouseManagerDataSource).Namespace, typeof(HouseManagerDataSource).ToString(),
               "Pulsar.Infrastructure.DataCollector", "AddRuleLog", DeviceType.Internal,
               "HouseManagerDataSource:AddRuleLog", From.HouseManagerDataSource.GetLocation("Internal").Id,
               RomanceStandardTime.ToString() + " HouseManagerDataSource Added RuleLog item for Rule " + ruleLog.Rule);

            return new RuleLogRepository().Add(ruleLog);
        }

        public RuleLog AddRuleLog(string rule, RuleAction ruleAction)
        {
            return AddRuleLog(new RuleLog
            {
                Rule = rule,
                RuleAction = ruleAction
            });
        }

        public RuleLog GetRuleLog(int id)
        {
            var ruleLog = new RuleLogRepository().Get(id);
            if (ruleLog == null)
                throw new PulsarException("E_PUL_IDC.020", "RuleLog for Id {0} could not be found in database", id);

            return ruleLog;
        }

        public PulsarLog AddPulsarLog(PulsarLog pulsarLog)
        {
            return new PulsarLogRepository().Add(pulsarLog);
        }

        /// <summary>
        /// Use this method to perform logging on datbase level
        /// </summary>
        /// <param name="@namespace">Project Namespace</param>
        /// <param name="@class">Class Name</param>
        /// <param name="project">Project Name</param>
        /// <param name="method">Method Name</param>
        /// <param name="type">Azure.WebJob/Rule/Sensor</param>
        /// <param name="message">Who:What</param>
        /// <param name="locationId">locationId</param>
        /// <param name="value">value</param>
        /// <returns></returns>
        public PulsarLog AddPulsarLog(string @namespace, string @class, string project, string method, DeviceType type, 
            string message, int locationId, string value = null)
        {
            return AddPulsarLog(new PulsarLog
            {
                NameSpace = @namespace,
                Class = @class,
                Project = project,
                Method = method,
                LocationId = locationId,
                DeviceType = type,
                Message = message,
                Value = value
            });
        }
    }
}
