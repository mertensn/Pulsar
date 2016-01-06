using NUnit.Framework;
using Pulsar.Contracts.Portable.DataTypes;
using Pulsar.Contracts.Portable.DataTypes.Enums;
using Pulsar.Test;

namespace Pulsar.Infrastructure.DataCollector.Test.Tests.DataSources
{
    [TestFixture]
    public class HouseManagerDataSourceTests : ScopedTestBase
    {
        private RuleLog _ruleLog;

        [Test]
        public void Given_AddedRuleLog_AllReturnValuesArePresent()
        {
            var addedRuleLog = _addRuleLog();

            Assert.AreEqual(addedRuleLog.Id, _ruleLog.Id);
            Assert.AreEqual(addedRuleLog.Rule, _ruleLog.Rule);
            Assert.AreEqual(addedRuleLog.RuleAction, _ruleLog.RuleAction);
        }

        [Test]
        public void Given_GetRuleLog_RuleLogIsFetched()
        {
            _addRuleLog();
            var ruleLogFromDb = From.HouseManagerDataSource.GetRuleLog(_ruleLog.Id);

            Assert.AreEqual(_ruleLog.Id, ruleLogFromDb.Id);
            Assert.AreEqual(_ruleLog.Rule, ruleLogFromDb.Rule);
            Assert.AreEqual(_ruleLog.RuleAction, ruleLogFromDb.RuleAction);
        }

        private RuleLog _addRuleLog()
        {
            _ruleLog = From.HouseManagerDataSource.AddRuleLog("TestRule", RuleAction.Execute);
            Assert.IsNotNull(_ruleLog);
            return _ruleLog;
        }
    }
}