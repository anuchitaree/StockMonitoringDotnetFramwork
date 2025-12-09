using StockMonitoringDotnetFramwork.Data;
using System;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace StockMonitoringDotnetFramwork
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {

                Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MyContext>());



                //Database.SetInitializer(new DropCreateDatabaseAlways<MyContext>());

                //Database.SetInitializer(new CreateDatabaseIfNotExists<MyContext>());

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
