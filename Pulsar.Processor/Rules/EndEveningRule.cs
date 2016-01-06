using System;
using Framework.Date;
using Pulsar.Contracts.Portable.DataTypes.Enums;
using Pulsar.Gateways.Pimatic;
using Pulsar.Infrastructure.DataCollector;

namespace Pulsar.Processor.Rules
{
    internal static class EndEveningRule
    {
        /// <summary>
        /// Execute the Rule from the RuleProcessor
        /// </summary>
        internal static void Execute(DateTime dateTime)
        {
            //TODO NICOLAS Store RuleValues in a seperate table so they can be managed externally
            if (dateTime.Hour != 23 || dateTime.Minute != 00) return;
            _log(dateTime);

            PimSwitchGateway.TurnOffLampLiving();
        }

        private static void _log(DateTime dateTime)
        {
            From.HouseManagerDataSource.AddRuleLog("EndEveningRule", RuleAction.Execute);
            From.HouseManagerDataSource.AddPulsarLog(
                typeof (EndEveningRule).Namespace, typeof (EndEveningRule).ToString(), "Pulsar.Processor",
                "Execute", DeviceType.Rule, "EndEveningRule:Execute", From.HouseManagerDataSource.GetLocation("Home").Id,
                RomanceStandardTime.ConvertFromDateTime(dateTime) + " EndEveningRule ExecuteEndEveningRule");
        }
    }
}