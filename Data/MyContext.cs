using StockMonitoringDotnetFramwork.Models;
using System.Data.Entity;

namespace StockMonitoringDotnetFramwork.Data
{
    public class MyContext : DbContext
    {

        public MyContext() : base("MyConnection")
        {
            //Database.SetInitializer<MyContext>(new DropCreateDatabaseAlways<MyContext>());

            //Database.SetInitializer<MyContext>(new CreateDatabaseIfNotExists<MyContext>());

        }




        public DbSet<Comport> Comports { get; set; }
        public DbSet<QRDataPattern> QRDataPatterns { get; set; }






    }
}
