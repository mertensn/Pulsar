namespace Pulsar.Infrastructure.DataCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RowCreated = c.DateTime(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pulses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RowCreated = c.DateTime(nullable: false),
                        Value = c.String(),
                        DeviceId = c.Int(nullable: false),
                        Location_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Devices", t => t.DeviceId, cascadeDelete: true)
                .ForeignKey("dbo.Locations", t => t.Location_Id)
                .Index(t => t.DeviceId)
                .Index(t => t.Location_Id);
            
            CreateTable(
                "dbo.Devices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RowCreated = c.DateTime(nullable: false),
                        Name = c.String(),
                        DeviceIdentifier = c.String(),
                        SensorId = c.String(),
                        DeviceType = c.Int(nullable: false),
                        Class = c.String(),
                        PulseType = c.Int(nullable: false),
                        DeviceHardware = c.Int(nullable: false),
                        LocationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: true)
                .Index(t => t.LocationId);
            
            CreateTable(
                "dbo.RuleLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RowCreated = c.DateTime(nullable: false),
                        Rule = c.String(),
                        RuleAction = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PulsarLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RowCreated = c.DateTime(nullable: false),
                        NameSpace = c.String(),
                        Project = c.String(),
                        Class = c.String(),
                        Method = c.String(),
                        DeviceType = c.Int(nullable: false),
                        Message = c.String(),
                        LocationId = c.Int(nullable: false),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: true)
                .Index(t => t.LocationId);
            
            CreateTable(
                "dbo.MySensorsMessages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RowCreated = c.DateTime(nullable: false),
                        OriginalMessage = c.String(),
                        NodeId = c.Int(nullable: false),
                        ChildSensorId = c.Int(nullable: false),
                        MySensorsMessageTypeId = c.Int(nullable: false),
                        Ack = c.Int(nullable: false),
                        MySensorsMessageSubTypeId = c.Int(nullable: false),
                        Payload = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MySensorsMessageSubTypes", t => t.MySensorsMessageSubTypeId, cascadeDelete: true)
                .ForeignKey("dbo.MySensorsMessageTypes", t => t.MySensorsMessageTypeId, cascadeDelete: true)
                .Index(t => t.MySensorsMessageTypeId)
                .Index(t => t.MySensorsMessageSubTypeId);
            
            CreateTable(
                "dbo.MySensorsMessageSubTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RowCreated = c.DateTime(nullable: false),
                        Value = c.Int(nullable: false),
                        Type = c.String(),
                        Comment = c.String(),
                        MessageTypeValue = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MySensorsMessageTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RowCreated = c.DateTime(nullable: false),
                        Value = c.Int(nullable: false),
                        Type = c.String(),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ControllerValues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RowCreated = c.DateTime(nullable: false),
                        Controller = c.String(),
                        ControllerComponent = c.String(),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MySensorsMessages", "MySensorsMessageTypeId", "dbo.MySensorsMessageTypes");
            DropForeignKey("dbo.MySensorsMessages", "MySensorsMessageSubTypeId", "dbo.MySensorsMessageSubTypes");
            DropForeignKey("dbo.PulsarLogs", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.Pulses", "Location_Id", "dbo.Locations");
            DropForeignKey("dbo.Pulses", "DeviceId", "dbo.Devices");
            DropForeignKey("dbo.Devices", "LocationId", "dbo.Locations");
            DropIndex("dbo.MySensorsMessages", new[] { "MySensorsMessageSubTypeId" });
            DropIndex("dbo.MySensorsMessages", new[] { "MySensorsMessageTypeId" });
            DropIndex("dbo.PulsarLogs", new[] { "LocationId" });
            DropIndex("dbo.Devices", new[] { "LocationId" });
            DropIndex("dbo.Pulses", new[] { "Location_Id" });
            DropIndex("dbo.Pulses", new[] { "DeviceId" });
            DropTable("dbo.ControllerValues");
            DropTable("dbo.MySensorsMessageTypes");
            DropTable("dbo.MySensorsMessageSubTypes");
            DropTable("dbo.MySensorsMessages");
            DropTable("dbo.PulsarLogs");
            DropTable("dbo.RuleLogs");
            DropTable("dbo.Devices");
            DropTable("dbo.Pulses");
            DropTable("dbo.Locations");
        }
    }
}
