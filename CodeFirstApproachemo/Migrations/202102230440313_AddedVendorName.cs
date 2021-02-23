namespace CodeFirstApproachemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedVendorName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "VendorName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "VendorName");
        }
    }
}
