using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMonitoringDotnetFramwork.Classes
{
    public static class Keepfile
    {

        public async static void SerialSetting()
        {
            string root = Parameter.PortSetting;
            string PortSetting1 = string.Format("{0}\\PortSetting1.txt", root);
            string PortSetting2 = string.Format("{0}\\PortSetting2.txt", root);
            string PortSetting3 = string.Format("{0}\\PortSetting3.txt", root);
            string PortSetting4 = string.Format("{0}\\PortSetting4.txt", root);
            string pattern = string.Format("{0}\\pattern.txt", root);

            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            if (!Directory.Exists(Parameter.Buffer))
            {
                Directory.CreateDirectory(Parameter.Buffer);
            }
            if (!File.Exists(PortSetting1))
            {
                string str = "COM1,19200,None,8,One,IN";
                File.WriteAllText(PortSetting1, str);
            }
            if (!File.Exists(PortSetting2))
            {
                string str = "COM2,19200,None,8,One,IN";
                File.WriteAllText(PortSetting2, str);
            }
            if (!File.Exists(PortSetting3))
            {
                string str = "COM3,19200,None,8,One,IN";
                File.WriteAllText(PortSetting3, str);
            }
            if (!File.Exists(PortSetting4))
            {
                string str = "COM4,19200,None,8,One,IN";
                File.WriteAllText(PortSetting4, str);
            }
            if (!File.Exists(pattern))
            {
                string data = string.Format("28,10,15,DSC1002133TG123456-45670T123");
                File.WriteAllText(pattern, data);
            }


        }


        public async static void ReadSerialSetting(int port, SerialPort serialPort)
        {
            string root = Parameter.PortSetting;
            string PortSetting1 = string.Format("{0}\\PortSetting1.txt", root);
            string PortSetting2 = string.Format("{0}\\PortSetting2.txt", root);
            string PortSetting3 = string.Format("{0}\\PortSetting3.txt", root);
            string PortSetting4 = string.Format("{0}\\PortSetting4.txt", root);
            string PortSetting = string.Empty;
            switch (port)
            {
                case 1:
                    PortSetting = PortSetting1;
                    break;
                case 2:
                    PortSetting = PortSetting2;
                    break;
                case 3:
                    PortSetting = PortSetting3;
                    break;
                case 4:
                    PortSetting = PortSetting4;
                    break;
            }

            if (File.Exists(PortSetting))
            {
                string com = File.ReadAllText(PortSetting);
                string[] parts = com.Split(',');
                if (parts.Length == 6)
                {
                    string comport = parts[0];

                    string stopbit = parts[4];
                    string parity = parts[2];
                    string mode = parts[5];
                    serialPort.PortName = comport;
                    serialPort.BaudRate = Convert.ToInt32(parts[1]);
                    serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), parity);
                    serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopbit);
                    serialPort.DataBits = Convert.ToInt16(parts[3]);


                    switch (port)
                    {
                        case 1:
                            Parameter.Direction1 = mode;
                            break;
                        case 2:
                            Parameter.Direction2 = mode;
                            break;
                        case 3:
                            Parameter.Direction3 = mode;
                            break;
                        case 4:
                            Parameter.Direction4 = mode;
                            break;
                    }





                }


            }

        }
    }
}
