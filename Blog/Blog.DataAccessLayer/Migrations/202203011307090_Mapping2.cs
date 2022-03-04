namespace Blog.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mapping2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Domains", "DomainName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Messages", "MessageSubject", c => c.String(maxLength: 200));
            AlterColumn("dbo.Messages", "MessageContent", c => c.String(maxLength: 4000));
            AlterColumn("dbo.Photos", "PhotoName", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Photos", "PhotoPath", c => c.String(maxLength: 250, unicode: false));
            AlterColumn("dbo.Photos", "PhotoTumbnail", c => c.String(maxLength: 250, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Photos", "PhotoTumbnail", c => c.String());
            AlterColumn("dbo.Photos", "PhotoPath", c => c.String());
            AlterColumn("dbo.Photos", "PhotoName", c => c.String());
            AlterColumn("dbo.Messages", "MessageContent", c => c.String());
            AlterColumn("dbo.Messages", "MessageSubject", c => c.String());
            AlterColumn("dbo.Domains", "DomainName", c => c.String());
        }
    }
}
