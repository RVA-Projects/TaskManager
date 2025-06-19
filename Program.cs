using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using static TaskManager.MainForm;

namespace TaskManager
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



            try
            {
                CultureInfo englishCulture = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture = englishCulture;
                Thread.CurrentThread.CurrentUICulture = englishCulture;

                ApplicationConfiguration.Initialize();
                DbManager.Initialize();
                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Startup error: " + ex.Message);
            }
        }
    }
}