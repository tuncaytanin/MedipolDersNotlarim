namespace KutuphaneYonetimi1O.Entites.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addKasa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblKasa",
                c => new
                    {
                        KasaId = c.Int(nullable: false, identity: true),
                        KasaAdi = c.String(maxLength: 100, unicode: false),
                        KasaDurumu = c.Boolean(nullable: false),
                        KasaMiktari = c.Decimal(nullable: false, precision: 15, scale: 2),
                    })
                .PrimaryKey(t => t.KasaId);
            
            AddColumn("dbo.tblKitapHareket", "CezaUcreti", c => c.Decimal(nullable: false, precision: 11, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblKitapHareket", "CezaUcreti");
            DropTable("dbo.tblKasa");
        }
    }
}
