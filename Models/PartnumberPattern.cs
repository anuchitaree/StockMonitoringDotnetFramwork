using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMonitoringDotnetFramwork.Models
{
    public class PartnumberPattern
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public int Len { get; set; }
        public int StartText{ get; set; }
        public int NumberOfText { get; set; }

        [StringLength(255)]
        public String Example { get; set; }
    }
}
