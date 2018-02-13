namespace SoftwareTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newmigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Parcels", "width", c => c.Int(nullable: false));
            AlterColumn("dbo.Parcels", "height", c => c.Int(nullable: false));
            AlterColumn("dbo.Parcels", "depth", c => c.Int(nullable: false));
            AlterColumn("dbo.Parcels", "weight", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Parcels", "weight", c => c.String());
            AlterColumn("dbo.Parcels", "depth", c => c.String());
            AlterColumn("dbo.Parcels", "height", c => c.String());
            AlterColumn("dbo.Parcels", "width", c => c.String());
        }
    }
}
