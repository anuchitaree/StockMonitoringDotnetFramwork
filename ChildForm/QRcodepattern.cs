using StockMonitoringDotnetFramwork.Data;
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

        }

        public void SetData(int Channel)
        {
            channel_number = Channel;
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
                    }
                    else
                    {
                        TbNumber.Text = null;
                        TbStart.Text = null;
                        TbTotal.Text = null;
                        TbScan.Text = null;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {

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
                    ExampleText = TbScan.Text
                };
                using (var db = new MyContext())
                {
                    var ptn = db.QRDataPatterns.Where(x => x.ID == qr.ID).FirstOrDefault();
                    if (ptn != null)
                    {
                        ptn.ExampleText = qr.ExampleText;
                        ptn.StartCharactor = Convert.ToInt32(qr.StartCharactor);
                        ptn.NumberOfCharactor = Convert.ToInt32(qr.NumberOfCharactor);
                        ptn.TotalOfCharactor = Convert.ToInt32(qr.TotalOfCharactor);
                        db.SaveChanges();
                    }
                    else
                    {
                        db.QRDataPatterns.Add(qr);
                        db.SaveChanges();
                    }
                }
                MessageBox.Show("Save data pattern completed","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Save data pattern error","Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
