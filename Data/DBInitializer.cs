using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMonitoringDotnetFramwork.Data
{
    public class DBInitializer : CreateDatabaseIfNotExists<MyContext>
    {

        protected override void Seed(MyContext context)
        {
            base.Seed(context);
        }
    }
}
