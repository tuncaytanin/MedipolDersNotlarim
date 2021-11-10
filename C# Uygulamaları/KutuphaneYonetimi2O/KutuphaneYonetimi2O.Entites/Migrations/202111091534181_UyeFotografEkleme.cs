namespace KutuphaneYonetimi2O.Entites.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UyeFotografEkleme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblUye", "Fotograf", c => c.String(maxLength: 250, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblUye", "Fotograf");
        }
    }
}
