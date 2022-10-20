namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedEvaluationInProduct : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Product", "EvaluationID", "dbo.Evaluation");
            DropIndex("dbo.Product", new[] { "EvaluationID" });
            DropColumn("dbo.Product", "EvaluationID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Product", "EvaluationID", c => c.Int());
            CreateIndex("dbo.Product", "EvaluationID");
            AddForeignKey("dbo.Product", "EvaluationID", "dbo.Evaluation", "ID");
        }
    }
}
