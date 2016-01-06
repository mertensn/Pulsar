using System.Data.Entity;
using Pulsar.Infrastructure.DataCollector.DataContexts;
using Pulsar.Infrastructure.DataCollector.DataTypes.Enums;

namespace Pulsar.Infrastructure.DataCollector.DbInitializers
{
    /// <summary>
    /// The CustomDatabaseInitializer initializes the databse if it does not exist.
    /// It also fills the initial data required by the application. Comment out InitDatabaseData() if you do not want initial data to be filled.
    /// </summary>
    public class CustomDatabaseInitializer : CreateDatabaseIfNotExists<PulsarDataContext>
    {
        public CustomDatabaseInitializer(DbState dbState)
        {
            if (dbState == DbState.IsExisting)
                Database.SetInitializer(new CreateDatabaseIfNotExists<PulsarDataContext>());
            else
                InitializeDatabaseData();
        }

        //TODO Nicolas For this method use a new instance of the datacontext and test this
        // -> that will also not work as you are creating an endless loop here... you are calling the 
        // one who calls the CustomDatabaseInitializer! Possibly with a new constructor without databaseInitializer??
        // OR maybe with an object which determines the initializer in the PulsarDataContext class?
        private static void InitializeDatabaseData()
        {
            new ControllerValueInitializer().InitializeDefaultDatabaseValues();
            new LocationInitializer().InitializeDefaultDatabaseValues();
            new MySensorsMessageSubTypeInitializer().InitializeDefaultDatabaseValues();
            new MySensorsMessageTypeInitializer().InitializeDefaultDatabaseValues();
            new DeviceInitializer().InitializeDefaultDatabaseValues();
        }
    }
}