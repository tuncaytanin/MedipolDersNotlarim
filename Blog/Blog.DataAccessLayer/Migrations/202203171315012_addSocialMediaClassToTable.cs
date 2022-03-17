namespace Blog.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSocialMediaClassToTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SocialMedias", "SocialMediaClass", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SocialMedias", "SocialMediaClass");
        }
    }
}
