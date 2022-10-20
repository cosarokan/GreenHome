namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new_mig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "ApprovedAdminID", c => c.Int());
            AddColumn("dbo.Product", "IsApproved", c => c.Int(nullable: false));
            CreateIndex("dbo.Product", "ApprovedAdminID");
            AddForeignKey("dbo.Product", "ApprovedAdminID", "dbo.Admin", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "ApprovedAdminID", "dbo.Admin");
            DropIndex("dbo.Product", new[] { "ApprovedAdminID" });
            DropColumn("dbo.Product", "IsApproved");
            DropColumn("dbo.Product", "ApprovedAdminID");
        }
    }
}
