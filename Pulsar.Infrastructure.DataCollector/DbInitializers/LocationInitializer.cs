using System.Collections.Generic;
using System.Linq;
using Pulsar.Contracts.Portable.DataTypes;

namespace Pulsar.Infrastructure.DataCollector.DbInitializers
{
    public class LocationInitializer
    {
        public void InitializeDefaultDatabaseValues()
        {
            var defaultLocations = new List<string> { "Azure", "Home", "Internal" };

            foreach (var location in defaultLocations.Select(location => new Location { Name = location }))
                From.HouseManagerDataSource.AddLocation(location);
        } 
    }
}