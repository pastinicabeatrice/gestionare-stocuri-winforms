using System.Data.Entity;

namespace Gestionare_Stocuri
{
    public class AppDbContext : DbContext
    {
        public DbSet<Material> Materiale { get; set; }
        public DbSet<Operatie> Operatii { get; set; }
        

        public AppDbContext() : base("name=AppDbContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
