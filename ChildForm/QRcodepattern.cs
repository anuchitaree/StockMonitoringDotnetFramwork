using StockMonitoringDotnetFramwork.Data;
using StockMonitoringDotnetFramwork.Interfaces;
using StockMonitoringDotnetFramwork.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace StockMonitoringDotnetFramwork.ChildForm
{
    public partial class QRcodepattern : UserControl
    {

        int channel_number;
        public QRcodepattern()
        {
            InitializeComponent();

            StateHub.OnChanged += StateHub_OnChanged;
        }

        public void SetData(int Channel)
        {
            channel_number = Channel;
        }

        private void StateHub_OnChanged(string key, object value)
        {

            if (key == "raw_message")
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new Action(() => TbScan.Text = value.ToString()));
                }
                else
                {
                    TbScan.Text = TbScan.Text = value.ToString();
                }
            }
        }


        private void QRcodepattern_Load(object sender, EventArgs e)
        {
            ptno.Text = channel_number.ToString();
            try
            {


                using (var db = new MyContext())
                {
                    var ptn = db.QRDataPatterns.Where(x => x.ID == channel_number).FirstOrDefault();
                    if (ptn != null)
                    {
                        TbNumber.Text = ptn.NumberOfCharactor.ToString();
                        TbStart.Text = ptn.StartCharactor.ToString();
                        TbTotal.Text = ptn.TotalOfCharactor.ToString();
                        TbScan.Text = ptn.ExampleText;
                        TbResult.Text = ptn.Result;
                        textBox2.Text = ptn.UqStart.ToString();
                        textBox3.Text = ptn.UqText;
                    }
                    else
                    {
                        TbNumber.Text = null;
                        TbStart.Text = null;
                        TbTotal.Text = null;
                        TbScan.Text = null;
                        TbResult.Text = null;
                        textBox2.Text = null;
                        textBox3.Text = null;
                    }
                }
            }
            catch
            {

            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            var starttext = int.Parse(TbStart.Text);
            var nuberofcharactor = int.Parse(TbNumber.Text);

            TbResult.Text = TbScan.Text.Substring(starttext, nuberofcharactor);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var qr = new QRDataPattern()
                {
                    ID = channel_number,
                    TotalOfCharactor = Convert.ToInt32(TbTotal.Text),
                    StartCharactor = Convert.ToInt32(TbStart.Text),
                    NumberOfCharactor = Convert.ToInt32(TbNumber.Text),
                    ExampleText = TbScan.Text,
                    Result = TbResult.Text,
                    UqStart=int.Parse(textBox2.Text),
                    UqText = textBox3.Text
                };
                using (var db = new MyContext())
                {
                    var ptn = db.QRDataPatterns.Where(x => x.ID == qr.ID).FirstOrDefault();
                    if (ptn != null)
                    {
                        ptn.ExampleText = qr.ExampleText;
                        ptn.StartCharactor = qr.StartCharactor;
                        ptn.NumberOfCharactor = qr.NumberOfCharactor;
                        ptn.TotalOfCharactor = qr.TotalOfCharactor;
                        ptn.Result = qr.Result;
                        ptn.UqStart =qr.UqStart;
                        ptn.UqText = qr.UqText;
                        db.SaveChanges();
                    }
                    else
                    {
                        db.QRDataPatterns.Add(qr);
                        db.SaveChanges();
                    }
                }
                MessageBox.Show("Save data pattern completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Save data pattern error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TbScan_TextChanged(object sender, EventArgs e)
        {
            int pos = TbScan.SelectionStart;
            Tblen.Text = pos.ToString();
        }

        private void TbScan_KeyUp(object sender, KeyEventArgs e)
        {
            int pos = TbScan.SelectionStart;
            Tblen.Text = pos.ToString();
        }

        private void TbScan_MouseUp(object sender, MouseEventArgs e)
        {
            int pos = TbScan.SelectionStart;
            Tblen.Text = pos.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TbTotal.Text = TbScan.SelectionStart.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TbStart.Text = TbScan.SelectionStart.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int pos = TbScan.SelectionStart;
            textBox1.Text = pos.ToString();
            TbNumber.Text = (pos - int.Parse(TbStart.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = TbScan.SelectionStart.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int start = int.Parse(textBox2.Text);
            int pos = TbScan.SelectionStart;

            textBox3.Text = TbScan.Text.Substring(start, (pos - start)).ToString();
        }
    }
}
