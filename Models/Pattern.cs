using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMonitoringDotnetFramwork.Models
{
    public partial class Pattern
    {
        [Key]
        public string SectionCode { get; set; }
        public int TotalLength { get; set; }
        public int Start { get; set; }
        public int Length { get; set; }

        public string Example { get; set; }
    }
}
