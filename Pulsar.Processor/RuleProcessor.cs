using System;
using Framework.Date;
using Pulsar.Processor.Rules;

namespace Pulsar.Processor
{
    /// <summary>
    /// The RuleProcessor is used to execute Rules.
    /// When a rule is executed it creates a RuleLog and a PulsarLog in the database.
    /// </summary>
    public class RuleProcessor
    {
        public void ExecuteAllRules()
        {
            var dateTime = RomanceStandardTime.Now;
            ExecuteBeginEveningRule(dateTime);
            ExecuteEndEveningRule(dateTime);
        }

        public void ExecuteBeginEveningRule(DateTime dateTime)
        {
            StartEveningRule.Execute(dateTime);
        }

        public void ExecuteEndEveningRule(DateTime dateTime)
        {
            EndEveningRule.Execute(dateTime);
        }
    }
}
