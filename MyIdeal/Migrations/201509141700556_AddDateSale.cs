namespace MyIdeal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateSale : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SaleProducts", "DateTimeSale", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SaleProducts", "DateTimeSale");
        }
    }
}
