using StockMonitoringDotnetFramwork.Interfaces;
using System;
using System.Windows.Forms;

namespace StockMonitoringDotnetFramwork.ChildForm
{
    public partial class InputInformation : UserControl
    {
        public InputInformation()
        {
            InitializeComponent();

            StateHub.OnChanged += StateHub_OnChanged;


        }

        private void StateHub_OnChanged(string key, object value)
        {


            if (key == "ch1_status")
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new Action(() => button1.BackColor = (System.Drawing.Color)value));
                }
                else
                {
                    button1.BackColor = (System.Drawing.Color)value;
                }
            }
            else if (key == "ch1_com")
            {
                // Update UI ต้อง invoke หากมาจาก thread อื่น
                if (InvokeRequired)
                {
                    BeginInvoke(new Action(() => textBox1.Text = value.ToString()));
                }
                else
                {
                    textBox1.Text = value.ToString();
                }
            }
            else if (key == "ch1_raw")
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new Action(() => richTextBox1.Text = value.ToString()));
                }
                else
                {
                    richTextBox1.Text = value.ToString();
                }
            }
            else if (key == "ch1_data")
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new Action(() => textBox2.Text = value.ToString()));
                }
                else
                {
                    textBox2.Text = value.ToString();
                }
            }
            else if (key == "ch2_status")
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new Action(() => button2.BackColor = (System.Drawing.Color)value));
                }
                else
                {
                    button2.BackColor = (System.Drawing.Color)value;
                }
            }
            else if (key == "ch2_com")
            {
                // Update UI ต้อง invoke หากมาจาก thread อื่น
                if (InvokeRequired)
                {
                    BeginInvoke(new Action(() => textBox3.Text = value.ToString()));
                }
                else
                {
                    textBox3.Text = value.ToString();
                }
            }
            else if (key == "ch2_raw")
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new Action(() => richTextBox2.Text = value.ToString()));
                }
                else
                {
                    richTextBox2.Text = value.ToString();
                }
            }
            else if (key == "ch2_data")
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new Action(() => textBox4.Text = value.ToString()));
                }
                else
                {
                    textBox4.Text = value.ToString();
                }
            }

            else if (key == "ch3_status")
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new Action(() => button3.BackColor = (System.Drawing.Color)value));
                }
                else
                {
                    button3.BackColor = (System.Drawing.Color)value;
                }
            }
            else if (key == "ch3_com")
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new Action(() => textBox5.Text = value.ToString()));
                }
                else
                {
                    textBox5.Text = value.ToString();
                }
            }
            else if (key == "ch3_raw")
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new Action(() => richTextBox3.Text = value.ToString()));
                }
                else
                {
                    richTextBox3.Text = value.ToString();
                }
            }
            else if (key == "ch3_data")
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new Action(() => textBox6.Text = value.ToString()));
                }
                else
                {
                    textBox6.Text = value.ToString();
                }
            }
            else if (key == "ch4_status")
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new Action(() => button4.BackColor = (System.Drawing.Color)value));
                }
                else
                {
                    button4.BackColor = (System.Drawing.Color)value;
                }
            }
            else if (key == "ch4_com")
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new Action(() => textBox7.Text = value.ToString()));
                }
                else
                {
                    textBox7.Text = value.ToString();
                }
            }
            else if (key == "ch4_raw")
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new Action(() => richTextBox4.Text = value.ToString()));
                }
                else
                {
                    richTextBox4.Text = value.ToString();
                }
            }
            else if (key == "ch4_data")
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new Action(() => textBox8.Text = value.ToString()));
                }
                else
                {
                    textBox8.Text = value.ToString();
                }
            }

        }




    }
}
