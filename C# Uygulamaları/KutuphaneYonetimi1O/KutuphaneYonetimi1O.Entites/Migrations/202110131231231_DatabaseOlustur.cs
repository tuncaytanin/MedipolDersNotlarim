namespace KutuphaneYonetimi1O.Entites.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseOlustur : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblKategori",
                c => new
                    {
                        KategoriId = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(maxLength: 100, unicode: false),
                        KategoriDurumu = c.Boolean(nullable: false),
                        KategoriAciklama = c.String(maxLength: 500, unicode: false),
                    })
                .PrimaryKey(t => t.KategoriId);
            
            CreateTable(
                "dbo.tblKitap",
                c => new
                    {
                        KitapId = c.Int(nullable: false, identity: true),
                        KitapAdi = c.String(maxLength: 100, unicode: false),
                        KitapAciklama = c.String(),
                        BasimYili = c.String(maxLength: 4, fixedLength: true, unicode: false),
                        SayfaSayisi = c.Short(nullable: false),
                        KitapDurumu = c.Boolean(nullable: false),
                        KategoriId = c.Int(nullable: false),
                        YazarId = c.Int(nullable: false),
                        YayinEviId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KitapId)
                .ForeignKey("dbo.tblKategori", t => t.KategoriId, cascadeDelete: true)
                .ForeignKey("dbo.tblYayinEvi", t => t.YayinEviId, cascadeDelete: true)
                .ForeignKey("dbo.tblYazar", t => t.YazarId, cascadeDelete: true)
                .Index(t => t.KategoriId)
                .Index(t => t.YazarId)
                .Index(t => t.YayinEviId);
            
            CreateTable(
                "dbo.tblYayinEvi",
                c => new
                    {
                        YayinEviId = c.Int(nullable: false, identity: true),
                        YayinEviAdi = c.String(maxLength: 100, unicode: false),
                        YayinEviDurumu = c.Boolean(nullable: false),
                        YayinEviAciklama = c.String(maxLength: 500, unicode: false),
                    })
                .PrimaryKey(t => t.YayinEviId);
            
            CreateTable(
                "dbo.tblYazar",
                c => new
                    {
                        YazarId = c.Int(nullable: false, identity: true),
                        YazarAdi = c.String(maxLength: 100, unicode: false),
                        YazarSoyadi = c.String(maxLength: 100, unicode: false),
                        DogumTarihi = c.String(),
                        YazarDurumu = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.YazarId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblKitap", "YazarId", "dbo.tblYazar");
            DropForeignKey("dbo.tblKitap", "YayinEviId", "dbo.tblYayinEvi");
            DropForeignKey("dbo.tblKitap", "KategoriId", "dbo.tblKategori");
            DropIndex("dbo.tblKitap", new[] { "YayinEviId" });
            DropIndex("dbo.tblKitap", new[] { "YazarId" });
            DropIndex("dbo.tblKitap", new[] { "KategoriId" });
            DropTable("dbo.tblYazar");
            DropTable("dbo.tblYayinEvi");
            DropTable("dbo.tblKitap");
            DropTable("dbo.tblKategori");
        }
    }
}
