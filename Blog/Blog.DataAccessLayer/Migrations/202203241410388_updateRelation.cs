namespace Blog.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateRelation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "Writer_UserId", "dbo.Users");
            DropIndex("dbo.Posts", new[] { "Writer_UserId" });
            DropColumn("dbo.Posts", "WriterId");
            RenameColumn(table: "dbo.Posts", name: "Writer_UserId", newName: "WriterId");
            AlterColumn("dbo.Posts", "PostTitle", c => c.String(maxLength: 200));
            AlterColumn("dbo.Posts", "PostContent", c => c.String(maxLength: 4000));
            AlterColumn("dbo.Posts", "WriterId", c => c.Int(nullable: true));
            CreateIndex("dbo.Posts", "WriterId");
            AddForeignKey("dbo.Posts", "WriterId", "dbo.Users", "UserId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "WriterId", "dbo.Users");
            DropIndex("dbo.Posts", new[] { "WriterId" });
            AlterColumn("dbo.Posts", "WriterId", c => c.Int());
            AlterColumn("dbo.Posts", "PostContent", c => c.String());
            AlterColumn("dbo.Posts", "PostTitle", c => c.String());
            RenameColumn(table: "dbo.Posts", name: "WriterId", newName: "Writer_UserId");
            AddColumn("dbo.Posts", "WriterId", c => c.Int(nullable: false));
            CreateIndex("dbo.Posts", "Writer_UserId");
            AddForeignKey("dbo.Posts", "Writer_UserId", "dbo.Users", "UserId");
        }
    }
}
