using NUnit.Framework;
using Pulsar.Contracts.Portable.DataTypes;
using Pulsar.Contracts.Portable.DataTypes.Enums;
using Pulsar.Test;

namespace Pulsar.Infrastructure.DataCollector.Test.Tests.Repositories
{
    [TestFixture]
    public class RuleLogRepositoryTests : ScopedTestBase
    {
        private RuleLog _ruleLog;

        [SetUp]
        public void SetUp()
        {
            _ruleLog = From.HouseManagerDataSource.AddRuleLog(new RuleLog
            {
                Rule = "TestRule",
                RuleAction = RuleAction.Test
            });
        }

        [Test]
        public void Given_RuleLogAddedToDatabase_IsReturnedWithCorrectParameters()
        {
            Assert.IsNotNull(_ruleLog);
            Assert.IsNotNull(_ruleLog.Id);
            Assert.IsNotNull(_ruleLog.RowCreated);
            Assert.AreEqual("TestRule", _ruleLog.Rule);
            Assert.AreEqual(RuleAction.Test, _ruleLog.RuleAction);
        }

        [Test]
        public void Given_GetRuleLog_IsReturnedWithCorrectParameters()
        {
            var ruleLog = From.HouseManagerDataSource.GetRuleLog(_ruleLog.Id);

            Assert.IsNotNull(ruleLog);
            Assert.IsNotNull(ruleLog.Id);
            Assert.IsNotNull(ruleLog.RowCreated);
            Assert.AreEqual("TestRule", ruleLog.Rule);
            Assert.AreEqual(RuleAction.Test, ruleLog.RuleAction);
        }

        [Test]
        [ExpectedPulsarException("E_PUL_IDC.020")]
        public void Given_GetRuleLog_ForNonExistingId_ThrowsException()
        {
            From.HouseManagerDataSource.GetRuleLog(-1);
        }
    }
}