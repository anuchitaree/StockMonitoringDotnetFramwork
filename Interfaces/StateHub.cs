using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMonitoringDotnetFramwork.Interfaces
{
    public  static class StateHub
    {
        public static event Action<string, object> OnChanged;

        public static void Raise(string key, object value)
        {
            OnChanged?.Invoke(key, value);
        }


    }
}
