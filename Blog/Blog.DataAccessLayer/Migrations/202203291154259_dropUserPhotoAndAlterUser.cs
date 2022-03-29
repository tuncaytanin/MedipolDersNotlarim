namespace Blog.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropUserPhotoAndAlterUser : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserPhotos", "UserId", "dbo.Users");
            DropIndex("dbo.UserPhotos", new[] { "UserId" });
            AddColumn("dbo.Users", "UserPhotoName", c => c.String(maxLength: 100));
            AddColumn("dbo.Users", "UserPhotoPath", c => c.String(maxLength: 200));
            AddColumn("dbo.Users", "UserPhotoThumpnailPath", c => c.String(maxLength: 200));
            AlterColumn("dbo.Users", "UserName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Users", "UserLastName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Users", "UserEmail", c => c.String(maxLength: 200));
            AlterColumn("dbo.Users", "UserPassword", c => c.String(maxLength: 30));
            DropTable("dbo.UserPhotos");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserPhotos",
                c => new
                    {
                        UserPhotoId = c.Int(nullable: false, identity: true),
                        UserPhotoName = c.String(maxLength: 100),
                        UserPhotoPath = c.String(maxLength: 200),
                        UserPhotoThumpnailPath = c.String(maxLength: 200),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserPhotoId);
            
            AlterColumn("dbo.Users", "UserPassword", c => c.String());
            AlterColumn("dbo.Users", "UserEmail", c => c.String());
            AlterColumn("dbo.Users", "UserLastName", c => c.String());
            AlterColumn("dbo.Users", "UserName", c => c.String());
            DropColumn("dbo.Users", "UserPhotoThumpnailPath");
            DropColumn("dbo.Users", "UserPhotoPath");
            DropColumn("dbo.Users", "UserPhotoName");
            CreateIndex("dbo.UserPhotos", "UserId");
            AddForeignKey("dbo.UserPhotos", "UserId", "dbo.Users", "UserId", cascadeDelete: true);
        }
    }
}
