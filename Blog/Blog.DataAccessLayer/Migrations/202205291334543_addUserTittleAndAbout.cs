namespace Blog.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUserTittleAndAbout : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "UserTitel", c => c.String(maxLength: 100));
            AddColumn("dbo.Users", "UserAbout", c => c.String(maxLength: 4000));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "UserAbout");
            DropColumn("dbo.Users", "UserTitel");
        }
    }
}
