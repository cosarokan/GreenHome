namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new_mig_ : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comment", "IsApproved", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comment", "IsApproved", c => c.Int(nullable: false));
        }
    }
}
