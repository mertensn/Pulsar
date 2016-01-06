using NUnit.Framework;
using Pulsar.Infrastructure.DataCollector.DataContexts;

namespace Pulsar.Gateways.PushBullet.Test.Tests
{
    [TestFixture]
    public class PbDeviceGatewayTests
    {
        [Test]
        public void Given_GetDevices_DeviceListReturned()
        {
            if (ContextObjects.PulsarEnvironment == Environment.Local) return;
            var devices = new PbDeviceGateway().GetDevices();
            Assert.IsNotNull(devices);
        }
    }
}