namespace KutuphaneYonetimi2O.Entites.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class githubRepositoryDegisimiDatabaseCreate : DbMigration
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
                "dbo.tblKitapHareket",
                c => new
                    {
                        KitapHareketId = c.Int(nullable: false, identity: true),
                        KitapId = c.Int(nullable: false),
                        PersonelId = c.Int(nullable: false),
                        UyeId = c.Int(nullable: false),
                        AlmaTarihi = c.DateTime(nullable: false, storeType: "date"),
                        IadeTarihi = c.DateTime(nullable: false, storeType: "date"),
                        KullaniciIadeTarihi = c.DateTime(nullable: false, storeType: "date"),
                        KitapHareketDurumu = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.KitapHareketId)
                .ForeignKey("dbo.tblKitap", t => t.KitapId, cascadeDelete: true)
                .ForeignKey("dbo.tblPersonel", t => t.PersonelId, cascadeDelete: true)
                .ForeignKey("dbo.tblUye", t => t.UyeId, cascadeDelete: true)
                .Index(t => t.KitapId)
                .Index(t => t.PersonelId)
                .Index(t => t.UyeId);
            
            CreateTable(
                "dbo.tblPersonel",
                c => new
                    {
                        PersonelId = c.Int(nullable: false, identity: true),
                        PersonelAdi = c.String(maxLength: 100, unicode: false),
                        PersonelSoyadi = c.String(maxLength: 100, unicode: false),
                        PersonelEmail = c.String(maxLength: 100, unicode: false),
                        PersonelKAdi = c.String(maxLength: 30, unicode: false),
                        PersonelParola = c.String(maxLength: 30, unicode: false),
                        DogumTarihi = c.DateTime(nullable: false, storeType: "date"),
                        PersonelDurumu = c.Boolean(nullable: false),
                        YetkiId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PersonelId)
                .ForeignKey("dbo.tblYetki", t => t.YetkiId, cascadeDelete: true)
                .Index(t => t.YetkiId);
            
            CreateTable(
                "dbo.tblUyeBorc",
                c => new
                    {
                        UyeBorcId = c.Int(nullable: false, identity: true),
                        PersonelId = c.Int(nullable: false),
                        KitapId = c.Int(nullable: false),
                        UyeId = c.Int(nullable: false),
                        GunSayisi = c.Int(nullable: false),
                        BorcMiktari = c.Decimal(nullable: false, precision: 11, scale: 2),
                        KitapHareketId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UyeBorcId)
                .ForeignKey("dbo.tblKitap", t => t.KitapId, cascadeDelete: true)
                .ForeignKey("dbo.tblPersonel", t => t.PersonelId, cascadeDelete: true)
                .ForeignKey("dbo.tblUye", t => t.UyeId, cascadeDelete: true)
                .Index(t => t.PersonelId)
                .Index(t => t.KitapId)
                .Index(t => t.UyeId);
            
            CreateTable(
                "dbo.tblUye",
                c => new
                    {
                        UyeId = c.Int(nullable: false, identity: true),
                        UyeAdi = c.String(maxLength: 100, unicode: false),
                        UyeSoyadi = c.String(maxLength: 100, unicode: false),
                        UyeEmail = c.String(maxLength: 30, unicode: false),
                        DogumTarihi = c.DateTime(nullable: false, storeType: "date"),
                        Cinsiyet = c.String(),
                        Telefon = c.String(maxLength: 15, unicode: false),
                        UyeDurumu = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UyeId);
            
            CreateTable(
                "dbo.tblYetki",
                c => new
                    {
                        YetkiId = c.Int(nullable: false, identity: true),
                        YetkiAdi = c.String(maxLength: 100, unicode: false),
                        YetkiAciklama = c.String(maxLength: 500, unicode: false),
                        YetkiDurumu = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.YetkiId);
            
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
            DropForeignKey("dbo.tblKitapHareket", "UyeId", "dbo.tblUye");
            DropForeignKey("dbo.tblKitapHareket", "PersonelId", "dbo.tblPersonel");
            DropForeignKey("dbo.tblPersonel", "YetkiId", "dbo.tblYetki");
            DropForeignKey("dbo.tblUyeBorc", "UyeId", "dbo.tblUye");
            DropForeignKey("dbo.tblUyeBorc", "PersonelId", "dbo.tblPersonel");
            DropForeignKey("dbo.tblUyeBorc", "KitapId", "dbo.tblKitap");
            DropForeignKey("dbo.tblKitapHareket", "KitapId", "dbo.tblKitap");
            DropForeignKey("dbo.tblKitap", "KategoriId", "dbo.tblKategori");
            DropIndex("dbo.tblUyeBorc", new[] { "UyeId" });
            DropIndex("dbo.tblUyeBorc", new[] { "KitapId" });
            DropIndex("dbo.tblUyeBorc", new[] { "PersonelId" });
            DropIndex("dbo.tblPersonel", new[] { "YetkiId" });
            DropIndex("dbo.tblKitapHareket", new[] { "UyeId" });
            DropIndex("dbo.tblKitapHareket", new[] { "PersonelId" });
            DropIndex("dbo.tblKitapHareket", new[] { "KitapId" });
            DropIndex("dbo.tblKitap", new[] { "YayinEviId" });
            DropIndex("dbo.tblKitap", new[] { "YazarId" });
            DropIndex("dbo.tblKitap", new[] { "KategoriId" });
            DropTable("dbo.tblYazar");
            DropTable("dbo.tblYayinEvi");
            DropTable("dbo.tblYetki");
            DropTable("dbo.tblUye");
            DropTable("dbo.tblUyeBorc");
            DropTable("dbo.tblPersonel");
            DropTable("dbo.tblKitapHareket");
            DropTable("dbo.tblKitap");
            DropTable("dbo.tblKategori");
        }
    }
}
