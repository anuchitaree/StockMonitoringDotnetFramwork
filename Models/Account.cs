using System.ComponentModel.DataAnnotations;

namespace StockMonitoringDotnetFramwork.Models
{
    public class Account
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
