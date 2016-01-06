using NUnit.Framework;
using Pulsar.Infrastructure.DataCollector.DataSources;

namespace Pulsar.Infrastructure.DataCollector.Test.Tests.DataSources
{
    [TestFixture]
    public class PimaticValueDataSourceTests
    {
        [Test]
        public void Given_GetLatest_dev_temp1_value_ValueIsReturned()
        {
            var value = new DeviceDataSource().GetTemperatureKitchen();
            Assert.IsNotNull(value);
        }
    }
}