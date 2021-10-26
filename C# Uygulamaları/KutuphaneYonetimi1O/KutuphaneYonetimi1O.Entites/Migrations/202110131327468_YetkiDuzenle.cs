namespace KutuphaneYonetimi1O.Entites.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YetkiDuzenle : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblYetki", "Yetki_YetkiId", "dbo.tblYetki");
            DropIndex("dbo.tblYetki", new[] { "Yetki_YetkiId" });
            DropColumn("dbo.tblYetki", "Yetki_YetkiId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblYetki", "Yetki_YetkiId", c => c.Int());
            CreateIndex("dbo.tblYetki", "Yetki_YetkiId");
            AddForeignKey("dbo.tblYetki", "Yetki_YetkiId", "dbo.tblYetki", "YetkiId");
        }
    }
}
