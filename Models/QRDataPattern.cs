using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMonitoringDotnetFramwork.Models
{
    public class QRDataPattern
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int TotalOfCharactor { get; set; }
        public int StartCharactor { get; set; }

        public int NumberOfCharactor { get; set; }

        public string Result { get; set; }

        public string ExampleText { get; set; }

        public int UqStart { get; set; }

        public string UqText { get; set; }

    }
}
