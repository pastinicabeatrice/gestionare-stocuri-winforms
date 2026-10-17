using Gestionare_Stocuri;
using System.Data.Entity;

public class DbInitializer : DropCreateDatabaseIfModelChanges<AppDbContext>
{
    protected override void Seed(AppDbContext context)
    {
       
        base.Seed(context);
    }
}
