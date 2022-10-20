namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new_migdb : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Product", "IsApproved", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Product", "IsApproved", c => c.Int(nullable: false));
        }
    }
}
