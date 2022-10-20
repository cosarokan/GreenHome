namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class denemeEva : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "EvaluationID", c => c.Int());
            CreateIndex("dbo.Product", "EvaluationID");
            AddForeignKey("dbo.Product", "EvaluationID", "dbo.Evaluation", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "EvaluationID", "dbo.Evaluation");
            DropIndex("dbo.Product", new[] { "EvaluationID" });
            DropColumn("dbo.Product", "EvaluationID");
        }
    }
}
