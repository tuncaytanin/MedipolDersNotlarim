namespace KutuphaneYonetimi1O.Entites.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateKAsa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblKasa", "VarsayilanKasa", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblKasa", "VarsayilanKasa");
        }
    }
}
