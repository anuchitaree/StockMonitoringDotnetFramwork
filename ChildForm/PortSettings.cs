using StockMonitoringDotnetFramwork.Data;
using StockMonitoringDotnetFramwork.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StockMonitoringDotnetFramwork.ChildForm
{
    public partial class PortSettings : UserControl
    {
        public PortSettings()
        {
            InitializeComponent();
        }

        int channel_number;
        public void SetData(int Channel)
        {
            channel_number = Channel;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var comport = new Comport()
            {
                ID = channel_number,
                PortName = CmbCom.SelectedItem.ToString(),
                Baudrate = CmbBaudRate.SelectedItem.ToString(),
                DataBits = CmbDatalength.SelectedItem.ToString(),
                Stopbit = CmbStopBit.SelectedItem.ToString(),
                Parity = CmbParity.SelectedItem.ToString(),
                Handshake= cmbHandshake.SelectedItem.ToString(),
                Direction = CmbDatDirection.SelectedItem.ToString(),
                Pattern1 = int.Parse(cmbDp1.SelectedItem.ToString()),
                Pattern2 = int.Parse(cmbDp2.SelectedItem.ToString()),
                Pattern3 = int.Parse(cmbDp3.SelectedItem.ToString()),
            };
            try
            {
                using (var db = new MyContext())
                {
                    var setting = db.Comports.Where(x => x.ID == channel_number).ToList().FirstOrDefault();
                    if (setting == null)
                    {
                        db.Comports.Add(comport);
                        db.SaveChanges();
                    }
                    else
                    {
                        setting.PortName = comport.PortName;
                        setting.Baudrate = comport.Baudrate;
                        setting.Stopbit = comport.Stopbit;
                        setting.Parity = comport.Parity;
                        setting.Direction = comport.Direction;
                        setting.DataBits = comport.DataBits;
                        setting.Stopbit = comport.Stopbit;
                        setting.Handshake = comport.Handshake;
                        setting.Pattern1 = comport.Pattern1;
                        setting.Pattern2 = comport.Pattern2;
                        setting.Pattern3 = comport.Pattern3;
                        db.SaveChanges();
                    }

                }
                MessageBox.Show("Save setting completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

                MessageBox.Show("Save setting error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void PortSettings_Load(object sender, EventArgs e)
        {
            COMPort();
            LoadSettingfile();
            lbname.Text = string.Format("Channel {0} Setup", channel_number);
        }

        private void COMPort()
        {
            for (int i = 1; i < 99; i++)
            {
                string str = string.Format("COM{0}", i);
                CmbCom.Items.Add(str);
            }
            CmbCom.SelectedIndex = 0;
            string[] baudrate = new string[] { "300", "600", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200", "230400", "460800", "921600" };
            string[] parity = new string[] { "None", "Even", "Odd" };
            string[] lenght = new string[] { "7", "8", "9" };
            string[] stopbit = new string[] { "1", "1.5", "2" };
            string[] direction = new string[] { "IN", "OUT" };
            string[] handshake = new string[] {"None", "XOnXOff", "RequestToSend", "RequestToSendXOnXOff" };
            CmbBaudRate.DataSource = baudrate;
            CmbParity.DataSource = parity;
            CmbDatalength.DataSource = lenght;
            CmbStopBit.DataSource = stopbit;
            cmbHandshake.DataSource = handshake;
            CmbDatDirection.DataSource = direction;
            cmbDp1.DataSource = Enumerable.Range(1, 10).ToList();
            cmbDp2.DataSource = Enumerable.Range(1, 10).ToList();
            cmbDp3.DataSource = Enumerable.Range(1, 10).ToList();



        }
        private void LoadSettingfile()
        {
            using (var db = new MyContext())
            {
                var setting = db.Comports.Where(x=>x.ID==channel_number).ToList().FirstOrDefault();
                if (setting != null)
                {
                    CmbCom.SelectedItem = setting.PortName;
                    CmbBaudRate.SelectedItem = setting.Baudrate;
                    CmbParity.SelectedItem = setting.Parity;
                    CmbDatalength.SelectedItem = setting.DataBits;
                    CmbStopBit.SelectedItem = setting.Stopbit;
                    CmbDatDirection.SelectedItem = setting.Direction;
                    cmbHandshake.SelectedItem = setting.Handshake;
                    cmbDp1.SelectedItem = setting.Pattern1;
                    cmbDp2.SelectedItem = setting.Pattern2;
                    cmbDp3.SelectedItem = setting.Pattern3;
                }
                else
                {
                    CmbCom.SelectedItem = -1;
                    CmbBaudRate.SelectedItem = -1;
                    CmbParity.SelectedItem = -1;
                    CmbDatalength.SelectedItem = -1;
                    CmbStopBit.SelectedItem = -1;
                    CmbDatDirection.SelectedItem = -1;
                    cmbDp1.SelectedItem = -1;
                    cmbDp2.SelectedItem = -1;
                    cmbDp3.SelectedItem = -1;
                }
            }


        }
    }
}
