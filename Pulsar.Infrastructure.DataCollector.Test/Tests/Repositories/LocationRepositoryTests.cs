using System;
using System.Linq;
using NUnit.Framework;
using Pulsar.Contracts.Portable.DataTypes;
using Pulsar.Infrastructure.DataCollector.DbInitializers;
using Pulsar.Test;

namespace Pulsar.Infrastructure.DataCollector.Test.Tests.Repositories
{
    [TestFixture]
    public class LocationRepositoryTests : ScopedTestBase
    {
        private Location _location;
        [SetUp]
        public void SetUp()
        {
            _location = From.HouseManagerDataSource.AddLocation(new Location
            {
                Name = "InitLocation"
            });
        }

        [Test]
        public void Given_LocationAddedWithCorrectpInputValues_LocationIsAddedToDb()
        {
            var location = From.HouseManagerDataSource.AddLocation(new Location
            {
                Name = "TestLocation"
            });
            
            Assert.IsNotNull(location);
            Assert.IsNotNull(location.Id);
            Assert.IsNotNull(location.RowCreated);
            Assert.AreEqual(location.Name, "TestLocation");
        }

        [Test]
        public void Given_LocationCanBeFetchedFromDB()
        {
            var location = From.HouseManagerDataSource.GetLocation(_location.Name);
            Assert.IsNotNull(location);
            Assert.AreEqual(location.Name, "InitLocation");
        }

        [Test]
        public void AllLocationsCanBeFetchedFromDatabase()
        {
            var locations = From.HouseManagerDataSource.GetAllLocations();
            Assert.IsNotNull(locations);
            Assert.IsTrue(locations.Any());
        }
    }
}