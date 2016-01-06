using System;
using NUnit.Framework;
using Pulsar.Test;

namespace Pulsar.Processor.Test.Tests
{
    [TestFixture]
    public class RuleControllerTests : ScopedTestBase
    {
        [Test]
        public void Given_ExecuteStartEveningRule_CheckRuleExecutuinAndLog()
        {
            new RuleProcessor().ExecuteBeginEveningRule(DateTime.Now);
        }

        [Test]
        public void Given_ExecuteEndEveningRule_CheckRuleExecutuinAndLog()
        {
            new RuleProcessor().ExecuteEndEveningRule(DateTime.Now);
        }
    }
}
