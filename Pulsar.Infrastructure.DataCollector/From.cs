using Pulsar.Infrastructure.DataCollector.DataSources;

namespace Pulsar.Infrastructure.DataCollector
{
    public static class From
    {
        private static HouseManagerDataSource _houseManagerDataSource;
        private static DeviceDataSource _deviceDataSource;

        public static HouseManagerDataSource HouseManagerDataSource
        {
            get { return _houseManagerDataSource ?? (_houseManagerDataSource = new HouseManagerDataSource()); }
        }

        public static DeviceDataSource DeviceDataSource
        {
            get { return _deviceDataSource ?? (_deviceDataSource = new DeviceDataSource()); }
        }
    }
}
