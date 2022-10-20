namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brand",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        CreatedDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        TopCategoryID = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(maxLength: 50),
                        Password = c.String(maxLength: 50),
                        CreatedDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Evaluation",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ContentEvaluation = c.String(maxLength: 50),
                        CreatedDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Favorite",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customer", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.CustomerID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Picture = c.String(maxLength: 50),
                        BarcodeNumber = c.String(maxLength: 15),
                        Content = c.String(maxLength: 100),
                        CategoryID = c.Int(nullable: false),
                        ProducerID = c.Int(nullable: false),
                        BrandID = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Brand", t => t.BrandID, cascadeDelete: true)
                .ForeignKey("dbo.Category", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.Producer", t => t.ProducerID, cascadeDelete: true)
                .Index(t => t.CategoryID)
                .Index(t => t.ProducerID)
                .Index(t => t.BrandID);
            
            CreateTable(
                "dbo.Producer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        CreatedDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ProductEvaluation",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        CustomerID = c.Int(nullable: false),
                        EvaluationID = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customer", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Evaluation", t => t.EvaluationID, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID)
                .Index(t => t.CustomerID)
                .Index(t => t.EvaluationID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductEvaluation", "ProductID", "dbo.Product");
            DropForeignKey("dbo.ProductEvaluation", "EvaluationID", "dbo.Evaluation");
            DropForeignKey("dbo.ProductEvaluation", "CustomerID", "dbo.Customer");
            DropForeignKey("dbo.Favorite", "ProductID", "dbo.Product");
            DropForeignKey("dbo.Product", "ProducerID", "dbo.Producer");
            DropForeignKey("dbo.Product", "CategoryID", "dbo.Category");
            DropForeignKey("dbo.Product", "BrandID", "dbo.Brand");
            DropForeignKey("dbo.Favorite", "CustomerID", "dbo.Customer");
            DropIndex("dbo.ProductEvaluation", new[] { "EvaluationID" });
            DropIndex("dbo.ProductEvaluation", new[] { "CustomerID" });
            DropIndex("dbo.ProductEvaluation", new[] { "ProductID" });
            DropIndex("dbo.Product", new[] { "BrandID" });
            DropIndex("dbo.Product", new[] { "ProducerID" });
            DropIndex("dbo.Product", new[] { "CategoryID" });
            DropIndex("dbo.Favorite", new[] { "ProductID" });
            DropIndex("dbo.Favorite", new[] { "CustomerID" });
            DropTable("dbo.ProductEvaluation");
            DropTable("dbo.Producer");
            DropTable("dbo.Product");
            DropTable("dbo.Favorite");
            DropTable("dbo.Evaluation");
            DropTable("dbo.Customer");
            DropTable("dbo.Category");
            DropTable("dbo.Brand");
        }
    }
}
