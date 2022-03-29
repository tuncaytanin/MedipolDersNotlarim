namespace Blog.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUserPhotoTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserPhotos",
                c => new
                    {
                        UserPhotoId = c.Int(nullable: false, identity: true),
                        UserPhotoName = c.String(),
                        UserPhotoPath = c.String(),
                        UserPhotoThumpnailPath = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserPhotoId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserPhotos", "UserId", "dbo.Users");
            DropIndex("dbo.UserPhotos", new[] { "UserId" });
            DropTable("dbo.UserPhotos");
        }
    }
}
