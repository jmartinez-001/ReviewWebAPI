namespace ReviewWebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        UserId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AuthorId = c.Int(nullable: false),
                        Content = c.String(),
                        Date = c.DateTime(nullable: false),
                        Comment_Id = c.Int(),
                        Review_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.Comments", t => t.Comment_Id)
                .ForeignKey("dbo.Reviews", t => t.Review_Id)
                .Index(t => t.AuthorId)
                .Index(t => t.Comment_Id)
                .Index(t => t.Review_Id);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AuthorId = c.Int(nullable: false),
                        ContractorId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                        JobType = c.String(),
                        Title = c.String(),
                        Content = c.String(),
                        Date = c.DateTime(nullable: false),
                        Rating = c.Int(nullable: false),
                        Budget = c.String(),
                        Helpful = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .Index(t => t.AuthorId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Reviews", new[] { "AuthorId" });
            DropIndex("dbo.Comments", new[] { "Review_Id" });
            DropIndex("dbo.Comments", new[] { "Comment_Id" });
            DropIndex("dbo.Comments", new[] { "AuthorId" });
            DropForeignKey("dbo.Reviews", "AuthorId", "dbo.Authors");
            DropForeignKey("dbo.Comments", "Review_Id", "dbo.Reviews");
            DropForeignKey("dbo.Comments", "Comment_Id", "dbo.Comments");
            DropForeignKey("dbo.Comments", "AuthorId", "dbo.Authors");
            DropTable("dbo.Reviews");
            DropTable("dbo.Comments");
            DropTable("dbo.Authors");
        }
    }
}
