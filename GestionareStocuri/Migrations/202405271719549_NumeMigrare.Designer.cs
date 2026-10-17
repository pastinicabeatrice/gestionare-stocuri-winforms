namespace Gestionare_Stocuri.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.4.4")]
    public sealed partial class NumeMigrare : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(NumeMigrare));
        
        string IMigrationMetadata.Id
        {
            get { return "202405271719549_NumeMigrare"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
