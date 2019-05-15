namespace ReviewWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedListofcommentstoICollectionofcomments : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "SubjectId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comments", "SubjectId");
        }
    }
}
