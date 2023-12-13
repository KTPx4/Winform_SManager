using Essay.Pages.Dialog;

namespace Essay
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new frmMain()
            //{
            //    NameUser = "Px4k3",
            //    TypeUser = "Employee",
            //    linkAvt = "husky2.png"
            //});
            Application.Run(new frmMain());
           // Application.Run(new Test());
        }
    }
}