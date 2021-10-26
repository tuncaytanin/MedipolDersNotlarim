namespace KutuphaneYonetimi2O.Entites.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseOlustur : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoris",
                c => new
                    {
                        KategoriId = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(maxLength: 100),
                        Aciklama = c.String(maxLength: 500),
                        KategoriDurum = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.KategoriId);
            
            CreateTable(
                "dbo.Kitaps",
                c => new
                    {
                        KitapId = c.Int(nullable: false, identity: true),
                        KitapAdi = c.String(maxLength: 100),
                        KategoriId = c.Int(nullable: false),
                        YazarId = c.Int(nullable: false),
                        YayinEviId = c.Int(nullable: false),
                        Aciklama = c.String(maxLength: 4000),
                        BasimYili = c.String(maxLength: 4, fixedLength: true, unicode: false),
                        KitapDurumu = c.Boolean(nullable: false),
                        SayfaSayisi = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.KitapId)
                .ForeignKey("dbo.Kategoris", t => t.KategoriId, cascadeDelete: true)
                .ForeignKey("dbo.YayinEvis", t => t.YayinEviId, cascadeDelete: true)
                .ForeignKey("dbo.Yazars", t => t.YazarId, cascadeDelete: true)
                .Index(t => t.KategoriId)
                .Index(t => t.YazarId)
                .Index(t => t.YayinEviId);
            
            CreateTable(
                "dbo.KitapHarekets",
                c => new
                    {
                        KitapHareketId = c.Int(nullable: false, identity: true),
                        KitapId = c.Int(nullable: false),
                        UyeId = c.Int(nullable: false),
                        PersonelId = c.Int(nullable: false),
                        AlmaTarihi = c.DateTime(nullable: false, storeType: "date"),
                        IadeTarihi = c.DateTime(nullable: false, storeType: "date"),
                        KullaniciIadeTarihi = c.DateTime(nullable: false, storeType: "date"),
                        KitapHareketDurumu = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.KitapHareketId)
                .ForeignKey("dbo.Kitaps", t => t.KitapId, cascadeDelete: true)
                .ForeignKey("dbo.Personels", t => t.PersonelId, cascadeDelete: true)
                .ForeignKey("dbo.Uyes", t => t.UyeId, cascadeDelete: true)
                .Index(t => t.KitapId)
                .Index(t => t.UyeId)
                .Index(t => t.PersonelId);
            
            CreateTable(
                "dbo.Personels",
                c => new
                    {
                        PersonelId = c.Int(nullable: false, identity: true),
                        PersonelAdi = c.String(maxLength: 100),
                        PersonelSoyadi = c.String(maxLength: 100),
                        PersonelEmail = c.String(maxLength: 100),
                        PersonelKAdi = c.String(maxLength: 30),
                        PersonelParola = c.String(maxLength: 30),
                        DogumTarihi = c.DateTime(nullable: false, storeType: "date"),
                        YetkiId = c.Int(nullable: false),
                        PersonelDurumu = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PersonelId)
                .ForeignKey("dbo.Yetkis", t => t.YetkiId, cascadeDelete: true)
                .Index(t => t.YetkiId);
            
            CreateTable(
                "dbo.UyeBorcs",
                c => new
                    {
                        UyeBorcId = c.Int(nullable: false, identity: true),
                        PersonelId = c.Int(nullable: false),
                        KitapId = c.Int(nullable: false),
                        UyeId = c.Int(nullable: false),
                        GunSayisi = c.Int(nullable: false),
                        KitapHareketId = c.Int(nullable: false),
                        Miktar = c.Decimal(nullable: false, precision: 11, scale: 2),
                    })
                .PrimaryKey(t => t.UyeBorcId)
                .ForeignKey("dbo.Kitaps", t => t.KitapId, cascadeDelete: true)
                .ForeignKey("dbo.Personels", t => t.PersonelId, cascadeDelete: true)
                .ForeignKey("dbo.Uyes", t => t.UyeId, cascadeDelete: true)
                .Index(t => t.PersonelId)
                .Index(t => t.KitapId)
                .Index(t => t.UyeId);
            
            CreateTable(
                "dbo.Uyes",
                c => new
                    {
                        UyeId = c.Int(nullable: false, identity: true),
                        UyeAdi = c.String(maxLength: 100),
                        UyeSoyadi = c.String(maxLength: 100),
                        UyeEmail = c.String(maxLength: 100),
                        DogumTarihi = c.DateTime(nullable: false, storeType: "date"),
                        UyeCinsiyeti = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        UyeTelefon = c.String(maxLength: 15),
                        UyeDurumu = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UyeId);
            
            CreateTable(
                "dbo.Yetkis",
                c => new
                    {
                        YetkiId = c.Int(nullable: false, identity: true),
                        YetkiAdi = c.String(maxLength: 100),
                        Aciklama = c.String(maxLength: 500),
                        YetkiDurumu = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.YetkiId);
            
            CreateTable(
                "dbo.YayinEvis",
                c => new
                    {
                        YayinEviId = c.Int(nullable: false, identity: true),
                        YayinEviAdi = c.String(maxLength: 100),
                        Aciklama = c.String(maxLength: 500),
                        YayinEviDurum = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.YayinEviId);
            
            CreateTable(
                "dbo.Yazars",
                c => new
                    {
                        YazarId = c.Int(nullable: false, identity: true),
                        YazarAdi = c.String(maxLength: 100),
                        YazarSoyadi = c.String(maxLength: 100),
                        DogumTarihi = c.DateTime(nullable: false, storeType: "date"),
                        YazarDurum = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.YazarId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kitaps", "YazarId", "dbo.Yazars");
            DropForeignKey("dbo.Kitaps", "YayinEviId", "dbo.YayinEvis");
            DropForeignKey("dbo.KitapHarekets", "UyeId", "dbo.Uyes");
            DropForeignKey("dbo.KitapHarekets", "PersonelId", "dbo.Personels");
            DropForeignKey("dbo.Personels", "YetkiId", "dbo.Yetkis");
            DropForeignKey("dbo.UyeBorcs", "UyeId", "dbo.Uyes");
            DropForeignKey("dbo.UyeBorcs", "PersonelId", "dbo.Personels");
            DropForeignKey("dbo.UyeBorcs", "KitapId", "dbo.Kitaps");
            DropForeignKey("dbo.KitapHarekets", "KitapId", "dbo.Kitaps");
            DropForeignKey("dbo.Kitaps", "KategoriId", "dbo.Kategoris");
            DropIndex("dbo.UyeBorcs", new[] { "UyeId" });
            DropIndex("dbo.UyeBorcs", new[] { "KitapId" });
            DropIndex("dbo.UyeBorcs", new[] { "PersonelId" });
            DropIndex("dbo.Personels", new[] { "YetkiId" });
            DropIndex("dbo.KitapHarekets", new[] { "PersonelId" });
            DropIndex("dbo.KitapHarekets", new[] { "UyeId" });
            DropIndex("dbo.KitapHarekets", new[] { "KitapId" });
            DropIndex("dbo.Kitaps", new[] { "YayinEviId" });
            DropIndex("dbo.Kitaps", new[] { "YazarId" });
            DropIndex("dbo.Kitaps", new[] { "KategoriId" });
            DropTable("dbo.Yazars");
            DropTable("dbo.YayinEvis");
            DropTable("dbo.Yetkis");
            DropTable("dbo.Uyes");
            DropTable("dbo.UyeBorcs");
            DropTable("dbo.Personels");
            DropTable("dbo.KitapHarekets");
            DropTable("dbo.Kitaps");
            DropTable("dbo.Kategoris");
        }
    }
}
