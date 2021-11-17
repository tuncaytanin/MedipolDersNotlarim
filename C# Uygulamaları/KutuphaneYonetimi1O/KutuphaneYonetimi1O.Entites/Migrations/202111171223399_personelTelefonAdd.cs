namespace KutuphaneYonetimi1O.Entites.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class personelTelefonAdd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblPersonel", "Telefon", c => c.String(maxLength: 15, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblPersonel", "Telefon");
        }
    }
}
