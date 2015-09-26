namespace MyIdeal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Labels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Volume = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        Label_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Labels", t => t.Label_Id)
                .Index(t => t.Label_Id);
            
            CreateTable(
                "dbo.SaleProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        Discount = c.Int(nullable: false),
                        Label_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Labels", t => t.Label_Id)
                .Index(t => t.Label_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SaleProducts", "Label_Id", "dbo.Labels");
            DropForeignKey("dbo.Products", "Label_Id", "dbo.Labels");
            DropIndex("dbo.SaleProducts", new[] { "Label_Id" });
            DropIndex("dbo.Products", new[] { "Label_Id" });
            DropTable("dbo.SaleProducts");
            DropTable("dbo.Products");
            DropTable("dbo.Labels");
        }
    }
}
