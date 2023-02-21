using Country_EF_WinForms_App.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Country_EF_WinForms_App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var context = new CountryContext();
            context.Database.Migrate();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}