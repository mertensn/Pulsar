using NUnit.Framework;
using Pulsar.Client.Test.Fixtures;
using Pulsar.Client.Test.Spies;

namespace Pulsar.Client.Test.Tests
{
    [TestFixture]
    public class HouseManagerServiceClientFactoryTests
    {
        //Only one test here: The database tests are executed from within Pimatic.Infrastructure.DataCollector
        //We only want to test the HouseManagerServiceClientFactory here
        [Test]
        public void GivenValidInputMessage_PulseIsAddedToDatabase_TestedWithClientFactory()
        {
            var houseManagerClient = new HouseManagerServiceClientFactory().Produce();
            var pulse = houseManagerClient.AddPulse(new PulseFixture().Create());

            Assert.IsNotNull(HouseManagerServiceSpy.LastAddedPulse);
            Assert.AreEqual(HouseManagerServiceSpy.LastAddedPulse.Id, 3);
            Assert.AreEqual(HouseManagerServiceSpy.LastAddedPulse.DeviceId, 2);
            Assert.AreEqual(HouseManagerServiceSpy.LastAddedPulse.Value, "22");

            Assert.IsNotNull(pulse);
            Assert.AreEqual(pulse.Id, 3);
            Assert.AreEqual(pulse.DeviceId, 2);
            Assert.AreEqual(pulse.Value, "22");
        }
    }
}