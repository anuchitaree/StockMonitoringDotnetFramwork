using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMonitoringDotnetFramwork.Models
{
    public class StockDataInput
    {
        public int Run { get; set; }
        public string SectionCode { get; set; }
        public DateTime RegistDateTime { get; set; }
        public string PartNumber { get; set; }
        public int PiecePerKanban { get; set; }
        public int UserId { get; set; }
        public bool Status { get; set; }
    }
}
