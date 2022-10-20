namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedCommentTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comment", "Text", c => c.String(maxLength: 50));
            DropTable("dbo.Comment1");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Comment1",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Text = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            DropColumn("dbo.Comment", "Text");
        }
    }
}
