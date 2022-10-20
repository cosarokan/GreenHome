namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedNewTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admin",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Comment",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        ApprovedAdminID = c.Int(nullable: false),
                        IsApproved = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Admin", t => t.ApprovedAdminID, cascadeDelete: true)
                .ForeignKey("dbo.Customer", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.CustomerID)
                .Index(t => t.ProductID)
                .Index(t => t.ApprovedAdminID);
            
            CreateTable(
                "dbo.Comment1",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Text = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comment", "ProductID", "dbo.Product");
            DropForeignKey("dbo.Comment", "CustomerID", "dbo.Customer");
            DropForeignKey("dbo.Comment", "ApprovedAdminID", "dbo.Admin");
            DropIndex("dbo.Comment", new[] { "ApprovedAdminID" });
            DropIndex("dbo.Comment", new[] { "ProductID" });
            DropIndex("dbo.Comment", new[] { "CustomerID" });
            DropTable("dbo.Comment1");
            DropTable("dbo.Comment");
            DropTable("dbo.Admin");
        }
    }
}
