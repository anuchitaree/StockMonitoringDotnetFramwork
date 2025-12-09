using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMonitoringDotnetFramwork.Models
{
    public class Comport
    {
        
        public int ID { get; set; }
        public string PortName { get; set; }
        public string Baudrate { get; set; }
        public string Parity { get; set; }
        public string DataBits { get; set; }
        public string Stopbit { get; set; }
        public string Direction { get; set; }


    }
}
