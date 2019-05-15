namespace ReviewWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedsubjectprop : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Comments", "SubjectId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comments", "SubjectId", c => c.Int(nullable: false));
        }
    }
}
