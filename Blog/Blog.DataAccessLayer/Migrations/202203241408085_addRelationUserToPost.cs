namespace Blog.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRelationUserToPost : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Writer_UserId", c => c.Int());
            CreateIndex("dbo.Posts", "Writer_UserId");
            AddForeignKey("dbo.Posts", "Writer_UserId", "dbo.Users", "UserId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "Writer_UserId", "dbo.Users");
            DropIndex("dbo.Posts", new[] { "Writer_UserId" });
            DropColumn("dbo.Posts", "Writer_UserId");
        }
    }
}
