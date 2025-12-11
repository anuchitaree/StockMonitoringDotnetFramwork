using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMonitoringDotnetFramwork.Models
{
    public class Comport
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string PortName { get; set; }
        [StringLength(50)]
        public string Baudrate { get; set; }
        [StringLength(50)]
        public string Parity { get; set; }

        [StringLength(50)]
        public string DataBits { get; set; }
        [StringLength(50)]
        public string Stopbit { get; set; }
        [StringLength(50)]
        public string Direction { get; set; }
        [StringLength(50)]
        public string Handshake { get; set; }


        public int Pattern1 { get; set; }
        public int Pattern2 { get; set; }
        public int Pattern3 { get; set; }

        public DateTime Lastedit { get; set; }
        public string Enable { get; set; }

    }
}
