using NUnit.Framework;
using Pulsar.Test;

namespace Pulsar.Gateways.Pimatic.Test.Tests
{
    [TestFixture]
    public class PimSwitchGatewayTests : ScopedTestBase
    {
        [Test]
        [Ignore("We do not want the house to go crazy if this test is executed")]
        public void Given_LampLivingIsOn_CheckLampStatusAfterTurnOn()
        {
            var initialStatus = PimSwitchGateway.LampLivingIsOn();
            if (!initialStatus)
                PimSwitchGateway.TurnOnLampLiving();

            var status = PimSwitchGateway.LampLivingIsOn();
            Assert.AreEqual(status.GetType(), typeof (bool));
            Assert.IsTrue(status);
            if (initialStatus)
            {
                PimSwitchGateway.TurnOnLampLiving();
            }
            else
            {
                PimSwitchGateway.TurnOffLampLiving();
            }
        }
    }
}
