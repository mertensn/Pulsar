using System;
using Framework.Date;
using Pulsar.Contracts.Portable.DataTypes.Enums;
using Pulsar.Gateways.Pimatic;
using Pulsar.Gateways.PushBullet;
using Pulsar.Infrastructure.DataCollector;

namespace Pulsar.Processor.Rules
{
    internal static class StartEveningRule
    {
        /// <summary>
        /// Execute the Rule from the RuleProcessor
        /// </summary>
        internal static void Execute(DateTime dateTime)
        {
            //TODO NICOLAS Store RuleValues in a seperate table so they can be managed externally
            if (dateTime.Hour != 17 || dateTime.Minute != 30) return;
            _log(dateTime);

            new PbMessageGateway().PushNoteToWindowsPhone("Pulsar.Processor.Rules", "StartEveningRule:ExecuteRule");
            PimSwitchGateway.TurnOnLampLiving();
        }

        private static void _log(DateTime dateTime)
        {
            From.HouseManagerDataSource.AddRuleLog("StartEveningRule", RuleAction.Execute);
            From.HouseManagerDataSource.AddPulsarLog(
                typeof(StartEveningRule).Namespace, typeof(StartEveningRule).ToString(), "Pulsar.Processor",
                "Execute", DeviceType.Rule, "StartEveningRule:Execute", From.HouseManagerDataSource.GetLocation("Home").Id,
                RomanceStandardTime.ConvertFromDateTime(dateTime) + " StartEveningRule ExecuteStartEveningRule");
        }
    }
}