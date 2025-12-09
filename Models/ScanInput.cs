using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMonitoringDotnetFramwork.Models
{
    public class ScanInput
    {
        public string Id { get; set; }
        public string SectionCode { get; set; }
        public string RegistDate { get; set; }
        public string PartNumberId { get; set; }

        public int Piece { get; set; }
        public int UserId { get; set; }

        public int Status { get; set; }
    }
}
