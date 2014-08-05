namespace Classifieds.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dates : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Listings", "Created", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Listings", "Updated", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Listings", "Updated", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Listings", "Created", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
    }
}
