namespace KutuphaneYonetimi1O.Entites.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFotografUye : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblUye", "Fotograf", c => c.String(maxLength: 200, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblUye", "Fotograf");
        }
    }
}
