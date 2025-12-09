using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMonitoringDotnetFramwork.Models
{
    public class QRDataPattern
    {
        public int ID { get; set; }

        public int TotalOfCharactor { get; set; }
        public int StartCharactor { get; set; }

        public int NumberOfCharactor { get; set; }
        public string ExampleText { get; set; }

    }
}
