using Syncfusion.Licensing;

namespace DietApp.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense("@32332e302e30CQUr3vpTCB6bNTEs0GU7k6utDL0Im1SV4BkC/llT2aE=");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new KarsilamaEkrani());
        }
    }
}