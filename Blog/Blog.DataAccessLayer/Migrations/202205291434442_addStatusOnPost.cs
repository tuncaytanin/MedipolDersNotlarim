namespace Blog.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStatusOnPost : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "PostStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "PostStatus");
        }
    }
}
