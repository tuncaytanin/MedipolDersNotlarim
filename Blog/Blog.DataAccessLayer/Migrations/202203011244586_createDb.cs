namespace Blog.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        CategoryStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        CommentTitle = c.String(),
                        CommentContent = c.String(),
                        PostId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        UserLastName = c.String(),
                        UserEmail = c.String(),
                        UserPassword = c.String(),
                        UserStatus = c.Boolean(nullable: false),
                        ForgetPassword = c.String(),
                        IsValidForgetPassword = c.Boolean(nullable: false),
                        DomainId = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Domains", t => t.DomainId, cascadeDelete: true)
                .Index(t => t.DomainId);
            
            CreateTable(
                "dbo.Domains",
                c => new
                    {
                        DomainId = c.Int(nullable: false, identity: true),
                        DomainName = c.String(),
                        DomainStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DomainId);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessageId = c.Int(nullable: false, identity: true),
                        MessageSubject = c.String(),
                        MessageContent = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        MessageSenderId = c.Int(nullable: false),
                        MessageReciverId = c.Int(nullable: false),
                        IsRead = c.Boolean(nullable: false),
                        MessageReciver_UserId = c.Int(),
                        MessageSender_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.MessageId)
                .ForeignKey("dbo.Users", t => t.MessageReciver_UserId)
                .ForeignKey("dbo.Users", t => t.MessageSender_UserId)
                .Index(t => t.MessageReciver_UserId)
                .Index(t => t.MessageSender_UserId);
            
            CreateTable(
                "dbo.Photos",
                c => new
                    {
                        PhotoId = c.Int(nullable: false, identity: true),
                        PhotoName = c.String(),
                        PhotoPath = c.String(),
                        PhotoTumbnail = c.String(),
                    })
                .PrimaryKey(t => t.PhotoId);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        PostTitle = c.String(),
                        PostContent = c.String(),
                        WriterId = c.Int(nullable: false),
                        PhotoId = c.Int(nullable: false),
                        CommentCount = c.Int(nullable: false),
                        LikeCount = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PostId)
                .ForeignKey("dbo.Photos", t => t.PhotoId, cascadeDelete: true)
                .Index(t => t.PhotoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "PhotoId", "dbo.Photos");
            DropForeignKey("dbo.Messages", "MessageSender_UserId", "dbo.Users");
            DropForeignKey("dbo.Messages", "MessageReciver_UserId", "dbo.Users");
            DropForeignKey("dbo.Comments", "UserId", "dbo.Users");
            DropForeignKey("dbo.Users", "DomainId", "dbo.Domains");
            DropIndex("dbo.Posts", new[] { "PhotoId" });
            DropIndex("dbo.Messages", new[] { "MessageSender_UserId" });
            DropIndex("dbo.Messages", new[] { "MessageReciver_UserId" });
            DropIndex("dbo.Users", new[] { "DomainId" });
            DropIndex("dbo.Comments", new[] { "UserId" });
            DropTable("dbo.Posts");
            DropTable("dbo.Photos");
            DropTable("dbo.Messages");
            DropTable("dbo.Domains");
            DropTable("dbo.Users");
            DropTable("dbo.Comments");
            DropTable("dbo.Categories");
        }
    }
}
