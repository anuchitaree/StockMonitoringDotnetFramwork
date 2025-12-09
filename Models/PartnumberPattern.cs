using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMonitoringDotnetFramwork.Models
{
    public class PartnumberPattern
    {
        public int ID { get; set; }
        public int Len { get; set; }
        public int StartText{ get; set; }
        public int NumberOfText { get; set; }
        public String Example { get; set; }
    }
}
