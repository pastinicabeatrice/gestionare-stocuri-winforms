namespace Gestionare_Stocuri.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nume = c.String(),
                        CodDeBare = c.String(),
                        Cantitate = c.Int(nullable: false),
                        Pret = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataExpirare = c.DateTime(nullable: false),
                        Caracteristici = c.String(),
                        Furnizor = c.String(),
                        LocatieStoc = c.String(),
                        Greutate = c.Double(nullable: false),
                        Lungime = c.Double(nullable: false),
                        Latime = c.Double(nullable: false),
                        Inaltime = c.Double(nullable: false),
                        DataAdaugareStoc = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Operaties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipOperatie = c.Int(nullable: false),
                        Cantitate = c.Int(nullable: false),
                        DataOperatie = c.DateTime(nullable: false),
                        Descriere = c.String(),
                        MaterialUtilizat_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Materials", t => t.MaterialUtilizat_Id)
                .Index(t => t.MaterialUtilizat_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Operaties", "MaterialUtilizat_Id", "dbo.Materials");
            DropIndex("dbo.Operaties", new[] { "MaterialUtilizat_Id" });
            DropTable("dbo.Operaties");
            DropTable("dbo.Materials");
        }
    }
}
