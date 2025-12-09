using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMonitoringDotnetFramwork.Models
{
    public class StockListLog
    {
        public int Run { get; set; }
        public string SectionCode { get; set; }
        public DateTime Registdatetime { get; set; }
        public string PartNumber { get; set; }
        public int Balance { get; set; }
    }
}
