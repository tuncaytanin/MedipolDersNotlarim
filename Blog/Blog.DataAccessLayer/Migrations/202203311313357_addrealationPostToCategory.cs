namespace Blog.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addrealationPostToCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "CategoriId", c => c.Int(nullable: true));
            CreateIndex("dbo.Posts", "CategoriId");
            AddForeignKey("dbo.Posts", "CategoriId", "dbo.Categories", "CategoryId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "CategoriId", "dbo.Categories");
            DropIndex("dbo.Posts", new[] { "CategoriId" });
            DropColumn("dbo.Posts", "CategoriId");
        }
    }
}
