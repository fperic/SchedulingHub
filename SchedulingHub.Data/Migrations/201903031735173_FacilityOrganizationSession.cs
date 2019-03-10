namespace SchedulingHub.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FacilityOrganizationSession : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Facilities",
                c => new
                    {
                        FacilityID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        OrganizationID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FacilityID)
                .ForeignKey("dbo.Organizations", t => t.OrganizationID, cascadeDelete: true)
                .Index(t => t.OrganizationID);
            
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        OrganizationID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedUserID = c.Int(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OrganizationID);
            
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        SessionID = c.Int(nullable: false, identity: true),
                        FacilityID = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        Location = c.String(),
                        StartDT = c.DateTime(nullable: false),
                        EndDT = c.DateTime(nullable: false),
                        Duration = c.Time(nullable: false, precision: 7),
                        Capacity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SessionID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Facilities", "OrganizationID", "dbo.Organizations");
            DropIndex("dbo.Facilities", new[] { "OrganizationID" });
            DropTable("dbo.Sessions");
            DropTable("dbo.Organizations");
            DropTable("dbo.Facilities");
        }
    }
}
