using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace Gestionare_Stocuri
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Database.SetInitializer(new DbInitializer());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMateriale());
        }
    }
}
