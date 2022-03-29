namespace Blog.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterUserPhoto : DbMigration
    {
        public override void Up()
        {
            
            AlterColumn("dbo.UserPhotos", "UserPhotoName", c => c.String(maxLength: 100));
            AlterColumn("dbo.UserPhotos", "UserPhotoPath", c => c.String(maxLength: 200));
            AlterColumn("dbo.UserPhotos", "UserPhotoThumpnailPath", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserPhotos", "UserPhotoThumpnailPath", c => c.String());
            AlterColumn("dbo.UserPhotos", "UserPhotoPath", c => c.String());
            AlterColumn("dbo.UserPhotos", "UserPhotoName", c => c.String());
            
        }
    }
}
