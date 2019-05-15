namespace ReviewWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedtostoringauthoruseridandsubjectuseridasstrings : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reviews", "AuthorUserId", c => c.String());
            AlterColumn("dbo.Reviews", "SubjectUserId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reviews", "SubjectUserId", c => c.Int(nullable: false));
            AlterColumn("dbo.Reviews", "AuthorUserId", c => c.Int(nullable: false));
        }
    }
}
