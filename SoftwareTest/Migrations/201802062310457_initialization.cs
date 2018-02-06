namespace SoftwareTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialization : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Couriers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Parcels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        width = c.String(),
                        height = c.String(),
                        depth = c.String(),
                        weight = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Parcels");
            DropTable("dbo.Couriers");
        }
    }
}
