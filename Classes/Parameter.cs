using StockMonitoringDotnetFramwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace StockMonitoringDotnetFramwork.Classes
{
    public static class Parameter
    {
        public static string PortSetting = @"C:\Stock";
        public static string Buffer = @"C:\Stock\bin";
        public static string SectionCode = "4320";
        public static Account User = new Account() { Username = "1005774", Password = "111111" };
        public static Models.Pattern Patterns = new Pattern() { TotalLength = 28, Start = 10, Length = 9 };

        public static Dictionary<string, int> masterPieces = new Dictionary<string, int>();
        public static bool ErrorLoadFile = false;

        public static string Direction1 = string.Empty;
        public static string Direction2 = string.Empty;
        public static string Direction3 = string.Empty;
        public static string Direction4 = string.Empty;

        public static string Permition = string.Empty;

    }
}
