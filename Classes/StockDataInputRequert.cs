using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMonitoringDotnetFramwork.Classes
{
    public class StockDataInputRequert
    {
        public string SectionCode { get; set; }
        public DateTime RegistDate { get; set; }
        public string PartNumber { get; set; }
        public int PiecePerKanban { get; set; }
        public int UserId { get; set; }
        public bool Status { get; set; }
    }
}
