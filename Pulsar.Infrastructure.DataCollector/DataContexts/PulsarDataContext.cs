using System.Data.Entity;
using System.Linq;
using Pulsar.Contracts.Portable.DataTypes;
using Pulsar.Contracts.Portable.DataTypes.MySensors;
using Pulsar.Infrastructure.DataCollector.DataTypes.Enums;
using Pulsar.Infrastructure.DataCollector.DbInitializers;

namespace Pulsar.Infrastructure.DataCollector.DataContexts
{
    /// <summary>
    /// To create this client, follow these guidelines
    /// 1. Make your context inherit DbContext
    /// 2. Create Initializer in Constructor of Context (Database.SetInitializer())
    /// 3. Override OnModelCreating of Context base Class
    /// 4. Provide connectionstring for base in Context Constructor
    /// 
    /// To enable Code First Migrations please use following commands in the Package Manager Console
    /// 1. Set Package Manager Console Default Project to Infrastructure.DataCollector
    /// 1.1 Make sure DataContext is using the correct conneciton string
    /// 2. Enable-Migrations -Force //optitional:-StartUpProjectName "Pulsar.Infrastructure.DataCollector"
    /// 3. Add-Migration "Initializer" -Force 
    /// 4. Update-Database -Force
    /// </summary>
    public class PulsarDataContext : DbContext
    {
        //TODO NICOLAS If the Build framework is implemented, add a config param to set the Environment and then check for it here
        public PulsarDataContext()
            : base("PulsarAzure")
        {
            //An Initializer is required for proper functioning of the DbContext, if not Context and database can get out if sync
            //Database.SetInitializer<PulsarDataContext>(null);
            //Database.SetInitializer(new CreateDatabaseIfNotExists<PulsarDataContext>());
            Database.SetInitializer(new CustomDatabaseInitializer(DbState.IsExisting));
            //System.Data.Entity.Database.SetInitializer(new CustomDatabaseInitializer());

            _configureDatabaseSettings();
        }

        public PulsarDataContext(string connectionString)
            : base(connectionString)
        {
            Database.SetInitializer(new CustomDatabaseInitializer(DbState.IsExisting));
            _configureDatabaseSettings();
        }

        //public override int SaveChanges()
        //{
        //    var addedEntities = this.ChangeTracker.Entries().Where(e => e.State == EntityState.Added).ToList();
        //    var modifiedEntities = this.ChangeTracker.Entries().Where(e => e.State == EntityState.Modified).ToList();

        //    return base.SaveChanges();
        //}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Model properties
            modelBuilder.Entity<Location>().HasKey(s => s.Id);
            modelBuilder.Entity<Pulse>().HasKey(s => s.Id);
            modelBuilder.Entity<RuleLog>().HasKey(s => s.Id);
            modelBuilder.Entity<PulsarLog>().HasKey(s => s.Id);

            modelBuilder.Entity<MySensorsMessage>().HasKey(s => s.Id);
            modelBuilder.Entity<MySensorsMessageType>().HasKey(s => s.Id);
            modelBuilder.Entity<MySensorsMessageSubType>().HasKey(s => s.Id);

            modelBuilder.Entity<ControllerValue>().HasKey(s => s.Id);

            modelBuilder.Entity<Device>().HasKey(s => s.Id);

            //Foreign key navigation properties
            //modelBuilder.Entity<TemperaturePulse>().HasRequired<Location>(e => e.Location).WithMany(e => e.TemperaturePulses).HasForeignKey(s => s.LocationId);
            //modelBuilder.Entity<HumidityPulse>().HasRequired<Location>(e => e.Location).WithMany(e => e.HumidityPulses).HasForeignKey(s => s.LocationId);

            //modelBuilder.Entity<TemperaturePulse>().HasRequired(s => s.Location).WithMany().HasForeignKey(x => x.LocationId).WillCascadeOnDelete(false);
            //modelBuilder.Entity<HumidityPulse>().HasRequired(s => s.Location).WithMany().HasForeignKey(x => x.LocationId).WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }

        private void _configureDatabaseSettings()
        {
            Configuration.LazyLoadingEnabled = false;
        }
    }
}
