namespace Blog.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAboutTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutId = c.Int(nullable: false, identity: true),
                        AboutTitle = c.String(maxLength: 200),
                        AboutContent = c.String(maxLength: 4000),
                        AboutStatus = c.Boolean(nullable: false),
                        PhotoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AboutId)
                .ForeignKey("dbo.Photos", t => t.PhotoId, cascadeDelete: true)
                .Index(t => t.PhotoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Abouts", "PhotoId", "dbo.Photos");
            DropIndex("dbo.Abouts", new[] { "PhotoId" });
            DropTable("dbo.Abouts");
        }
    }
}
