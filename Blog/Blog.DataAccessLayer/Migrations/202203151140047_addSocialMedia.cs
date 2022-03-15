namespace Blog.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSocialMedia : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SocialMedias",
                c => new
                    {
                        SocialMediaId = c.Int(nullable: false, identity: true),
                        SocialMediaName = c.String(maxLength: 30),
                        SocialMediaIconClass = c.String(maxLength: 30),
                        SocialMediaFolowerCount = c.String(maxLength: 10),
                        SocialMediaStatus = c.Boolean(nullable: false),
                        SocialMediaLink = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.SocialMediaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SocialMedias");
        }
    }
}
