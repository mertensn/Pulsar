using System.Linq;
using NUnit.Framework;
using Pulsar.Infrastructure.DataCollector.DataContexts;
using Pulsar.Test;

namespace Pulsar.Gateways.Pimatic.Test.Tests
{
    [TestFixture]
    public class PimSensorGatewayTests : ScopedTestBase
    {
        [Test]
        public void InstanceCanBecreated()
        {
            var gateway = new PimSensorGateway();
            Assert.IsNotNull(gateway);
        }

        [Test]
        public void Given_WhenInstanceIsCreated_VariablesAreFilled()
        {
            var gateway = new PimSensorGateway();
            Assert.IsNotNull(gateway);
            Assert.IsNotNull(gateway.Variables);
            Assert.IsTrue(gateway.Variables.variables.Any());
        }
    }
}