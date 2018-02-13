namespace SoftwareTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validators : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Couriers", "minWeight", c => c.Single(nullable: false));
            AddColumn("dbo.Couriers", "maxWeight", c => c.Single(nullable: false));
            AddColumn("dbo.Couriers", "minSize", c => c.Single(nullable: false));
            AddColumn("dbo.Couriers", "maxSize", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Couriers", "maxSize");
            DropColumn("dbo.Couriers", "minSize");
            DropColumn("dbo.Couriers", "maxWeight");
            DropColumn("dbo.Couriers", "minWeight");
        }
    }
}
