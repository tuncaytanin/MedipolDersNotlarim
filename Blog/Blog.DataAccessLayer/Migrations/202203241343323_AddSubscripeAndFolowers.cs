namespace Blog.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSubscripeAndFolowers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Folowers",
                c => new
                    {
                        FolowerId = c.Int(nullable: false, identity: true),
                        TakiEdenId = c.Int(nullable: false),
                        TakipEdilenId = c.Int(nullable: false),
                        TakipEden_UserId = c.Int(),
                        TakipEdilen_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.FolowerId)
                .ForeignKey("dbo.Users", t => t.TakipEden_UserId)
                .ForeignKey("dbo.Users", t => t.TakipEdilen_UserId)
                .Index(t => t.TakipEden_UserId)
                .Index(t => t.TakipEdilen_UserId);
            
            CreateTable(
                "dbo.Subscripes",
                c => new
                    {
                        SubscripeId = c.Int(nullable: false, identity: true),
                        Email = c.String(maxLength: 200),
                        IsValid = c.Boolean(nullable: false),
                        ActivationCode = c.String(maxLength: 64),
                    })
                .PrimaryKey(t => t.SubscripeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Folowers", "TakipEdilen_UserId", "dbo.Users");
            DropForeignKey("dbo.Folowers", "TakipEden_UserId", "dbo.Users");
            DropIndex("dbo.Folowers", new[] { "TakipEdilen_UserId" });
            DropIndex("dbo.Folowers", new[] { "TakipEden_UserId" });
            DropTable("dbo.Subscripes");
            DropTable("dbo.Folowers");
        }
    }
}
