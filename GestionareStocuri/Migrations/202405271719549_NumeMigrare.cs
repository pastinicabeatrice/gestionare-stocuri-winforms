namespace Gestionare_Stocuri.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NumeMigrare : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Materials", "TipOperatie", c => c.Int(nullable: false));
            AddColumn("dbo.Materials", "Categorie", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Materials", "Categorie");
            DropColumn("dbo.Materials", "TipOperatie");
        }
    }
}
