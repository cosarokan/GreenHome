namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class denemedeneme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "CustomerID", c => c.Int());
            CreateIndex("dbo.Product", "CustomerID");
            AddForeignKey("dbo.Product", "CustomerID", "dbo.Customer", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "CustomerID", "dbo.Customer");
            DropIndex("dbo.Product", new[] { "CustomerID" });
            DropColumn("dbo.Product", "CustomerID");
        }
    }
}
