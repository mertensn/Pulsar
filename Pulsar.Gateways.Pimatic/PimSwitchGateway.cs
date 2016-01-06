using System;
using System.Linq;
using Framework.Date;
using Pimatic.NET.Contracts.Interfaces;
using Pimatic.NET.ServiceClient.Factories;
using Pulsar.Contracts.Portable.DataTypes;
using Pulsar.Contracts.Portable.DataTypes.Enums;
using Pulsar.Infrastructure.DataCollector;

namespace Pulsar.Gateways.Pimatic
{
    /// <summary>
    /// The SwitchGateway can perform Switch actions. It can read out and change switch states by using the PimaticFactories.
    /// When an write action is triggered on a switch, a Pulse is created in the database.
    /// </summary>
    public static class PimSwitchGateway
    {
        private static readonly IPimaticVariableFactory PimaticVariableFactory = new PimaticVariableFactory();
        private static readonly IPimaticDeviceFactory PimaticDeviceFactory = new PimaticDeviceFactory();

        public static bool LampLivingIsOn()
        {
            _log("LampLivingIsOn");

            var lampLiving = PimaticVariableFactory.GetVariables().variables.SingleOrDefault(s => s.name == "dev_switch1.state");
            return lampLiving != null && Convert.ToBoolean(lampLiving.value);
        }

        public static Pulse TurnOnLampLiving()
        {
            PimaticDeviceFactory.TurnOnDevice("dev_switch1");
            _log("TurnOnLampLiving");
            var device = From.HouseManagerDataSource.GetDevice("dev_switch1", null, NavigationPropertyState.Omit);
            return From.HouseManagerDataSource.AddPulse(_createPulse("On", device));
        }

        public static Pulse TurnOffLampLiving()
        {
            PimaticDeviceFactory.TurnOffDevice("dev_switch1");
            _log("TurnOffLampLiving");
            var device = From.HouseManagerDataSource.GetDevice("dev_switch1", null, NavigationPropertyState.Omit);
            return From.HouseManagerDataSource.AddPulse(_createPulse("Off", device));
        }

        public static Pulse TurnOnDev_MySwitch1()
        {
            PimaticDeviceFactory.TurnOnDevice("dev_myswitch1");
            _log("TurnOnDev_MySwitch1");
            var device = From.HouseManagerDataSource.GetDevice("dev_myswitch1", null, NavigationPropertyState.Omit);
            return From.HouseManagerDataSource.AddPulse(_createPulse("On", device));
        }

        public static Pulse TurnOffDev_MySwitch1()
        {
            PimaticDeviceFactory.TurnOffDevice("dev_myswitch1");
            _log("TurnOffDev_MySwitch1");
            var device = From.HouseManagerDataSource.GetDevice("dev_myswitch1", null, NavigationPropertyState.Omit);
            return From.HouseManagerDataSource.AddPulse(_createPulse("Off", device));
        }

        private static void _log(string method)
        {
            From.HouseManagerDataSource.AddPulsarLog(
                typeof(PimSwitchGateway).Namespace, typeof(PimSwitchGateway).ToString(), "Pulsar.Gateways.Pimatic",
                method, DeviceType.Switch, typeof(PimSwitchGateway) + ":" + method, From.HouseManagerDataSource.GetLocation("Home").Id,
                RomanceStandardTime.ToString() + " PimSwitchGateway " + method);
        }

        private static Pulse _createPulse(string value, Device device)
        {
            return new Pulse
            {
                DeviceId = device.Id,
                Value = value
            };
        }
    }
}
