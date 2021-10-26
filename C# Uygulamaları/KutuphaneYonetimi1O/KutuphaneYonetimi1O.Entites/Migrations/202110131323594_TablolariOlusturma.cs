namespace KutuphaneYonetimi1O.Entites.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablolariOlusturma : DbMigration
    {
        public override void Up()
        {
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
                        Yetki_YetkiId = c.Int(),
                    })
                .PrimaryKey(t => t.YetkiId)
                .ForeignKey("dbo.tblYetki", t => t.Yetki_YetkiId)
                .Index(t => t.Yetki_YetkiId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblKitapHareket", "UyeId", "dbo.tblUye");
            DropForeignKey("dbo.tblKitapHareket", "PersonelId", "dbo.tblPersonel");
            DropForeignKey("dbo.tblPersonel", "YetkiId", "dbo.tblYetki");
            DropForeignKey("dbo.tblYetki", "Yetki_YetkiId", "dbo.tblYetki");
            DropForeignKey("dbo.tblUyeBorc", "UyeId", "dbo.tblUye");
            DropForeignKey("dbo.tblUyeBorc", "PersonelId", "dbo.tblPersonel");
            DropForeignKey("dbo.tblUyeBorc", "KitapId", "dbo.tblKitap");
            DropForeignKey("dbo.tblKitapHareket", "KitapId", "dbo.tblKitap");
            DropIndex("dbo.tblYetki", new[] { "Yetki_YetkiId" });
            DropIndex("dbo.tblUyeBorc", new[] { "UyeId" });
            DropIndex("dbo.tblUyeBorc", new[] { "KitapId" });
            DropIndex("dbo.tblUyeBorc", new[] { "PersonelId" });
            DropIndex("dbo.tblPersonel", new[] { "YetkiId" });
            DropIndex("dbo.tblKitapHareket", new[] { "UyeId" });
            DropIndex("dbo.tblKitapHareket", new[] { "PersonelId" });
            DropIndex("dbo.tblKitapHareket", new[] { "KitapId" });
            DropTable("dbo.tblYetki");
            DropTable("dbo.tblUye");
            DropTable("dbo.tblUyeBorc");
            DropTable("dbo.tblPersonel");
            DropTable("dbo.tblKitapHareket");
        }
    }
}
