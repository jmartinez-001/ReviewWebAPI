namespace ReviewWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedtostoringauthoruseridandsubjectuserid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "AuthorUserId", c => c.Int(nullable: false));
            AddColumn("dbo.Reviews", "SubjectUserId", c => c.Int(nullable: false));
            DropColumn("dbo.Reviews", "ContractorId");
            DropColumn("dbo.Reviews", "ClientId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "ClientId", c => c.Int(nullable: false));
            AddColumn("dbo.Reviews", "ContractorId", c => c.Int(nullable: false));
            DropColumn("dbo.Reviews", "SubjectUserId");
            DropColumn("dbo.Reviews", "AuthorUserId");
        }
    }
}
