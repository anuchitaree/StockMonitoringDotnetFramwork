using StockMonitoringDotnetFramwork.ChildForm;
using StockMonitoringDotnetFramwork.Classes;
using StockMonitoringDotnetFramwork.Data;
using StockMonitoringDotnetFramwork.Interfaces;
using StockMonitoringDotnetFramwork.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StockMonitoringDotnetFramwork
{
    public partial class MainForm : Form
    {

        private InputInformation _inputInformation;


        private static readonly SerialPort serialPort1 = new SerialPort();
        private static readonly SerialPort serialPort2 = new SerialPort();
        private static readonly SerialPort serialPort3 = new SerialPort();
        private static readonly SerialPort serialPort4 = new SerialPort();

        private static int Counter1;
        private static int Counter2;
        private static int Counter3;
        private static int Counter4;
        readonly CancellationTokenSource[] cts = new CancellationTokenSource[3];
        private readonly Dictionary<string, string> PiecePerKanbanDic = new Dictionary<string, string>();

        private static StringBuilder buffer1 = new StringBuilder();
        private static StringBuilder buffer2 = new StringBuilder();
        private static StringBuilder buffer3 = new StringBuilder();
        private static StringBuilder buffer4 = new StringBuilder();
        private static StringBuilder buffer5 = new StringBuilder();
        private static StringBuilder buffer6 = new StringBuilder();

        private static MainForm Instance;




        public MainForm()
        {
            InitializeComponent();
            Instance = this;

            StateHub.OnChanged += StateHub_OnChanged;

            _inputInformation = new InputInformation();

            //_inputInformation.Dock = DockStyle.Fill;
            //this.Controls.Add(_inputInformation);

            //InputInformation uc = new InputInformation();
            //uc.Dock = DockStyle.Fill;
            //panel3.Controls.Clear();
            //panel3.Controls.Add(_inputInformation);
        }

        private void StateHub_OnChanged(string key, object value)
        {
            if (key == "Postsetting")
            {
                if ((int)value == 1)
                {
                    SerialPortSetting.Close(serialPort1);
                    Reset_status((int)value);
                    

                    LoadSettingAndOpenSerialPort(1, serialPort1);
                }
            }
        }
        private void Reset_status(int ch)
        {
           switch (ch)
            {
                case 1:
                    button1.BackColor = Color.FromArgb(225, 225, 225);
                    StateHub.Raise("ch1_status", Color.FromArgb(255, 255, 255));
                    StateHub.Raise("ch1_com", "");

                    break;
                default:
                    break;
            }
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //this.Visible = false;
        //    var frm = new AccountUserControl();
        //    frm.Visible = true;
        //    frm.Dock = DockStyle.Fill;
        //    this.Controls.Add(frm);
        //    //frm.Show();
        //}

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitialSetup();

            IntialDataGridView(DgvShow);





            //StateHub.Raise("ch1_com", textBox1.Text);
            //StateHub.Raise("ch1_raw", richTextBox1.Text);
            //StateHub.Raise("ch1_data", textBox2.Text);

            //StateHub.Raise("Message", richTextBox1.Text);

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Thread1Start();
            Thread2Start();
            Thread3Start();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Thread1Stop();
            Thread2Stop();
            Thread3Stop();
            SerialPortSetting.Close(serialPort1);
            SerialPortSetting.Close(serialPort2);
            SerialPortSetting.Close(serialPort3);
            SerialPortSetting.Close(serialPort4);
        }



        //}




        #region THREAD POOL 
        private void Thread1Start()
        {
            if (cts[0] != null)
                return;
            cts[0] = new CancellationTokenSource();
            ThreadPool.QueueUserWorkItem(new WaitCallback(Thread1), cts[0].Token);
        }
        private void Thread1Stop()
        {
            if (cts[0] == null)
                return;
            cts[0].Cancel();
            Thread.Sleep(250);
            cts[0].Dispose();
            cts[0] = null;
        }
        void Thread1(object obj)
        {
            CancellationToken token = (CancellationToken)obj;
            Thread.Sleep(1000);
            while (!token.IsCancellationRequested)
            {
                //if (Parameter.User != null)

                //    TakeStorageDataToSQL();

                Thread.Sleep(10000); // 10 sec
            }
        }



        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////
        /// </summary>
        private void Thread2Start()
        {
            if (cts[1] != null)
                return;
            cts[1] = new CancellationTokenSource();
            ThreadPool.QueueUserWorkItem(new WaitCallback(Thread2), cts[1].Token);
        }
        private void Thread2Stop()
        {
            if (cts[1] == null)
                return;
            cts[1].Cancel();
            Thread.Sleep(250);
            cts[1].Dispose();
            cts[1] = null;
        }
        void Thread2(object obj)
        {
            CancellationToken token = (CancellationToken)obj;
            Thread.Sleep(2000);
            while (!token.IsCancellationRequested)
            {
                ShowStockBalance();
                Thread.Sleep(10000);
            }
        }


        /// <summary>
        /// ///////////////////////////////////////////////////////////////
        /// </summary>
        private void Thread3Start()
        {
            if (cts[2] != null)
                return;
            cts[2] = new CancellationTokenSource();
            ThreadPool.QueueUserWorkItem(new WaitCallback(Thread3), cts[2].Token);
        }
        private void Thread3Stop()
        {
            if (cts[2] == null)
                return;
            cts[2].Cancel();
            Thread.Sleep(250);
            cts[2].Dispose();
            cts[2] = null;
        }
        void Thread3(object obj)
        {
            CancellationToken token = (CancellationToken)obj;
            Thread.Sleep(1000);
            while (!token.IsCancellationRequested)
            {
                if (Parameter.User != null)
                {
                    //BtnStatus.Invoke(new Action(() =>
                    //{
                    //    if (Parameter.ErrorLoadFile == false)
                    //    {
                    //        BtnStatus.BackColor = Color.FromArgb(170, 255, 170);
                    //        BtnStatus.Text = "Ready";
                    //    }
                    //    else
                    //    {
                    //        BtnStatus.BackColor = Color.Red;
                    //        BtnStatus.Text = "No Master";
                    //    }

                    //}));
                    //LbUser.Invoke(new Action(() =>
                    //{
                    //    if (Parameter.User != null)
                    //        LbUser.Text = string.Format("User : {0}", Parameter.User.Username);
                    //}));
                    //PnlSub.Invoke(new Action(() =>
                    //{
                    //    PnlSub.Visible = false;
                    //}));



                }
                else
                {
                    //BtnStatus.Invoke(new Action(() =>
                    //{
                    //    BtnStatus.BackColor = Color.Red;
                    //    BtnStatus.Text = "Not ready";
                    //}));
                    //LbUser.Invoke(new Action(() =>
                    //{
                    //    LbUser.Text = string.Format("User:");
                    //}));

                    //PnlSub.Invoke(new Action(() =>
                    //{
                    //    PnlSub.Visible = true;
                    //}));


                }
                Thread.Sleep(1000);
            }
        }


        #endregion Thread



        #region Initial setup
        private void InitialSetup()
        {

            PortSettingDefault();

            LoadSettingAndOpenSerialPort(1, serialPort1);

            Loadpattern();

        }

        private void PortSettingDefault()
        {
            //BtnPort1.BackColor = Color.FromArgb(225, 225, 225);
            //BtnPort2.BackColor = Color.FromArgb(225, 225, 225);
            //BtnPort3.BackColor = Color.FromArgb(225, 225, 225);
            //BtnPort4.BackColor = Color.FromArgb(225, 225, 225);
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
        }

        private void Loadpattern()
        {
            try
            {
                using (var db = new MyContext())
                {
                    var pattern = db.QRDataPatterns.Where(x => x.ID == 1).FirstOrDefault();
                    if (pattern != null)
                    {
                        Parameter.Patterns.TotalLength = pattern.TotalOfCharactor;
                        Parameter.Patterns.Start = pattern.StartCharactor;
                        Parameter.Patterns.Length = pattern.NumberOfCharactor;
                        return;
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private void LoadSettingAndOpenSerialPort(int port, SerialPort serialPort)
        {
            try
            {
                Comport comp = new Comport();
                using (var db = new MyContext())
                {
                    try
                    {
                        comp = db.Comports.Where(x => x.ID == port).FirstOrDefault();
                    }
                    catch (Exception ex)
                    {

                        string msg = ex.Message;
                    }

                }



                if (comp != null)
                {
                    string comport = comp.PortName;
                    string BaudRate = comp.Baudrate;
                    string DataBits = comp.DataBits;
                    string stopbit = comp.Stopbit;
                    string parity = comp.Parity;
                    string mode = comp.Direction;
                    string handshake = comp.Handshake;

                    serialPort.PortName = comp.PortName;
                    serialPort.BaudRate = Convert.ToInt32(comp.Baudrate);
                    serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), comp.Parity);
                    serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comp.Stopbit);
                    serialPort.DataBits = Convert.ToInt16(comp.DataBits);

                    //serialPort.Encoding = System.Text.Encoding.UTF8;
                    serialPort.Encoding = Encoding.ASCII; // Thai
                    serialPort.DtrEnable = true;
                    serialPort.RtsEnable = true;

                    //serialPort.Handshake = Handshake.None;
                    serialPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), comp.Handshake);

                    int maxRetries = 3;
                    const int sleepTimeInMs = 500;
                    while (maxRetries > 0)
                    {
                        try
                        {
                            serialPort.Open();
                            if (serialPort.IsOpen)
                            {
                                serialPort.DiscardInBuffer();
                                switch (port)
                                {
                                    case 1:
                                        serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler1);
                                        button1.BackColor = Color.FromArgb(0, 255, 0);
                                        StateHub.Raise("ch1_status", Color.FromArgb(0, 255, 0));
                                        timer1.Enabled = true;
                                        Parameter.Direction1 = mode;
                                        var setting1 = string.Format("{0} : {1},{2},{3},{4},{5},handshake:{6}", mode, comport, BaudRate, DataBits, stopbit, parity, handshake);
                                        StateHub.Raise("ch1_com", setting1);

                                        break;
                                    case 2:
                                        serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler2);
                                        button1.BackColor = Color.FromArgb(0, 255, 0);
                                        Parameter.Direction2 = mode;
                                        var setting2 = string.Format("{0} : {1},{2},{3},{4},{5},handshake:{6}", mode, comport, BaudRate, DataBits, stopbit, parity, handshake);
                                        StateHub.Raise("ch2_com", setting2);
                                        timer2.Enabled = true;
                                        break;
                                    case 3:
                                        serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler3);
                                        button1.BackColor = Color.FromArgb(0, 255, 0);
                                        var setting3 = string.Format("{0} : {1},{2},{3},{4},{5},handshake:{6}", mode, comport, BaudRate, DataBits, stopbit, parity, handshake);
                                        StateHub.Raise("ch3_com", setting3);
                                        timer3.Enabled = true;
                                        Parameter.Direction3 = mode;
                                        break;
                                    case 4:
                                        serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler4);
                                        button1.BackColor = Color.FromArgb(0, 255, 0);
                                        var setting4 = string.Format("{0} : {1},{2},{3},{4},{5},handshake:{6}", mode, comport, BaudRate, DataBits, stopbit, parity, handshake);
                                        StateHub.Raise("ch4_com", setting4);
                                        timer4.Enabled = true;
                                        Parameter.Direction4 = mode;
                                        break;
                                }

                                break;
                            }
                        }
                        catch (UnauthorizedAccessException)
                        {
                            maxRetries--;
                            Thread.Sleep(sleepTimeInMs);
                        }
                        catch (Exception exception)
                        {
                            maxRetries--;
                            Console.WriteLine(exception.Message);
                        }
                    }

                    if (maxRetries != 3)
                    {
                        Console.WriteLine("maxRetries:{0}", maxRetries);
                    }
                }
            }
            catch (Exception)
            {
                //throw;
            }

        }

        #endregion

        #region Data Receivece

        //public Action MyAction = () => { };


        private static void DataReceivedHandler1(object sender, SerialDataReceivedEventArgs e)
        {


            var ReadingText = serialPort1.ReadExisting();   // อ่านเฉพาะที่มีอยู่ตอนนั้น
            buffer1.Append(ReadingText);

            string result = buffer1.ToString();

            if (buffer1.ToString().EndsWith("\r")) // && buffer1.Length >= Parameter.Patterns.Length) // || buffer.ToString().EndsWith("\r\n")) 
            {
                string result_clean = buffer1.ToString().Trim();

                buffer1.Clear();

                StateHub.Raise("Portsetting_ch1", result);
                StateHub.Raise("ch1_raw", result);
                StateHub.Raise("raw_message", result);

                string text_part = result_clean.Substring(Parameter.Patterns.Start, Parameter.Patterns.Length);

                if (Instance.textBox2.InvokeRequired)
                {
                    Instance.textBox2.Invoke(new Action(() =>
                    {
                        Instance.textBox2.Text = text_part;
                    }));
                }
                StateHub.Raise("ch1_data", text_part);

                Counter1++;
                serialPort1.DiscardInBuffer();
                Console.WriteLine("Data Received Port 1:{0} : {1}", Counter1, result);
            }


        }

        private static void DataReceivedHandler2(object sender, SerialDataReceivedEventArgs e)
        {
            var ReadingText = serialPort2.ReadExisting();   // อ่านเฉพาะที่มีอยู่ตอนนั้น
            buffer1.Append(ReadingText);

            string result = buffer2.ToString();

            if (buffer2.ToString().EndsWith("\r") && buffer2.Length >= Parameter.Patterns.Length) // || buffer.ToString().EndsWith("\r\n")) 
            {
                string result_clean = buffer2.ToString().Trim();

                buffer2.Clear();

                //if (Instance.richTextBox2.InvokeRequired)
                //{
                //    Instance.richTextBox2.Invoke(new Action(() =>
                //    {
                //        Instance.richTextBox2.Text = result_clean;
                //    }));
                //}

                string text_part = result_clean.Substring(Parameter.Patterns.Start, Parameter.Patterns.Length);

                if (Instance.textBox4.InvokeRequired)
                {
                    Instance.textBox4.Invoke(new Action(() =>
                    {
                        Instance.textBox4.Text = text_part;
                    }));
                }

                Counter2++;
                serialPort2.DiscardInBuffer();
                Console.WriteLine("Data Received Port 1:{0} : {1}", Counter2, result);
            }
        }

        private static void DataReceivedHandler3(object sender, SerialDataReceivedEventArgs e)
        {
            var ReadingText = serialPort3.ReadExisting();   // อ่านเฉพาะที่มีอยู่ตอนนั้น
            buffer3.Append(ReadingText);

            string result = buffer3.ToString();

            if (buffer3.ToString().EndsWith("\r") && buffer3.Length >= Parameter.Patterns.Length) // || buffer.ToString().EndsWith("\r\n")) 
            {
                string result_clean = buffer3.ToString().Trim();

                buffer3.Clear();

                //if (Instance.richTextBox3.InvokeRequired)
                //{
                //    Instance.richTextBox3.Invoke(new Action(() =>
                //    {
                //        Instance.richTextBox3.Text = result_clean;
                //    }));
                //}

                string text_part = result_clean.Substring(Parameter.Patterns.Start, Parameter.Patterns.Length);

                if (Instance.textBox6.InvokeRequired)
                {
                    Instance.textBox6.Invoke(new Action(() =>
                    {
                        Instance.textBox6.Text = text_part;
                    }));
                }

                Counter3++;
                serialPort3.DiscardInBuffer();
                Console.WriteLine("Data Received Port 1:{0} : {1}", Counter3, result);
            }
        }

        private static void DataReceivedHandler4(object sender, SerialDataReceivedEventArgs e)
        {
            var ReadingText = serialPort4.ReadExisting();   // อ่านเฉพาะที่มีอยู่ตอนนั้น
            buffer4.Append(ReadingText);

            string result = buffer4.ToString();

            if (buffer4.ToString().EndsWith("\r") && buffer4.Length >= Parameter.Patterns.Length) // || buffer.ToString().EndsWith("\r\n")) 
            {
                string result_clean = buffer4.ToString().Trim();

                buffer4.Clear();

                //if (Instance.richTextBox4.InvokeRequired)
                //{
                //    Instance.richTextBox4.Invoke(new Action(() =>
                //    {
                //        Instance.richTextBox4.Text = result_clean;
                //    }));
                //}

                string text_part = result_clean.Substring(Parameter.Patterns.Start, Parameter.Patterns.Length);

                if (Instance.textBox8.InvokeRequired)
                {
                    Instance.textBox8.Invoke(new Action(() =>
                    {
                        Instance.textBox8.Text = text_part;
                    }));
                }

                Counter4++;
                serialPort4.DiscardInBuffer();
                Console.WriteLine("Data Received Port 1:{0} : {1}", Counter4, result);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Enabled = false;

            //if (result1 != null)
            //{
            //    richTextBox1.Text = result1;

            //}

            //if (result1 != null && result1 != "")
            //{
            //    if (ReadingText1.Length == Parameter.Patterns.TotalLength)
            //    {
            //        ReadingText1 = ReadingText1.Substring(Parameter.Patterns.Start, Parameter.Patterns.Length);

            //        //AsyncInsertTable1(ReadingText1);
            //    }
            //    //Message1.Text = String.Format("Count: {0} ,P/N : {1}", Counter1, ReadingText1);
            //    result1 = null;
            //}
            //timer1.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //timer2.Enabled = false;
            //if (ReadingText2 != null)
            //{
            //    richTextBox2.Text = ReadingText2;

            //}

            //if (Parameter.User != null && ReadingText2 != null && ReadingText2 != "")
            //{
            //    if (Parameter.Permition == "on" && ReadingText2.Length == Parameter.Patterns.TotalLength)
            //    {
            //        ReadingText2 = ReadingText2.Substring(Parameter.Patterns.Start, Parameter.Patterns.Length);
            //        AsyncInsertTable2(ReadingText2);
            //    }
            //    //Message2.Text = String.Format("Count: {0} ,P/N : {1}", Counter2, ReadingText2);
            //    ReadingText2 = null;
            //}
            //timer2.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //    timer3.Enabled = false;

            //    if (ReadingText3 != null)
            //        richTextBox3.Text = ReadingText3;

            //    if (Parameter.User != null && ReadingText3 != null && ReadingText3 != "")
            //    {
            //        if (Parameter.Permition == "on" && ReadingText3.Length == Parameter.Patterns.TotalLength)
            //        {
            //            ReadingText3 = ReadingText3.Substring(Parameter.Patterns.Start, Parameter.Patterns.Length);
            //            AsyncInsertTable3(ReadingText3);
            //        }
            //        //Message3.Text = String.Format("Count: {0} ,P/N : {1}", Counter3, ReadingText3);
            //        ReadingText3 = null;
            //    }
            //    timer3.Enabled = true;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            //timer4.Enabled = false;

            //if (ReadingText4 != null)
            //    richTextBox4.Text = ReadingText4;

            //if (Parameter.User != null && ReadingText4 != null && ReadingText4 != "")
            //{
            //    if (Parameter.Permition == "on" && ReadingText4.Length == Parameter.Patterns.TotalLength)
            //    {
            //        ReadingText4 = ReadingText4.Substring(Parameter.Patterns.Start, Parameter.Patterns.Length);
            //        AsyncInsertTable4(ReadingText4);
            //    }
            //    //Message4.Text = String.Format("Count: {0} ,P/N : {1}", Counter4, ReadingText4);
            //    ReadingText4 = null;
            //}
            //timer4.Enabled = true;
        }


        private void AsyncInsertTable1(string readtxt)
        {
            try
            {
                CultureInfo ci = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture = ci;
                Thread.CurrentThread.CurrentUICulture = ci;
                int piece = 1;
                if (Parameter.Direction1 == "OUT")
                    piece *= (-1);
                if (Parameter.masterPieces.ContainsKey(readtxt))
                {
                    int masterpiece = (Parameter.masterPieces.FirstOrDefault(p => p.Key == readtxt).Value) * piece;
                    string filename = string.Format("{0}\\{1}.txt", Parameter.Buffer, Guid.NewGuid().ToString());
                    string data = string.Format("{0},{1},{2},{3},{4}", Parameter.SectionCode, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), readtxt, masterpiece, Parameter.User.Username);
                    File.WriteAllText(filename, data);
                }
            }
            catch (Exception)
            {

                throw;
            }


        }
        private void AsyncInsertTable2(string readtxt)
        {
            try
            {
                CultureInfo ci = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture = ci;
                Thread.CurrentThread.CurrentUICulture = ci;
                int piece = 1;
                if (Parameter.Direction2 == "OUT")
                    piece *= (-1);
                if (Parameter.masterPieces.ContainsKey(readtxt))
                {
                    int masterpiece = (Parameter.masterPieces.FirstOrDefault(p => p.Key == readtxt).Value) * piece;
                    string filename = string.Format("{0}\\{1}.txt", Parameter.Buffer, Guid.NewGuid().ToString());
                    string data = string.Format("{0},{1},{2},{3},{4}", Parameter.SectionCode, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), readtxt, masterpiece, Parameter.User.Username);
                    File.WriteAllText(filename, data);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void AsyncInsertTable3(string readtxt)
        {
            try
            {
                CultureInfo ci = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture = ci;
                Thread.CurrentThread.CurrentUICulture = ci;
                int piece = 1;
                if (Parameter.Direction3 == "OUT")
                    piece *= (-1);
                if (Parameter.masterPieces.ContainsKey(readtxt))
                {
                    int masterpiece = (Parameter.masterPieces.FirstOrDefault(p => p.Key == readtxt).Value) * piece;
                    string filename = string.Format("{0}\\{1}.txt", Parameter.Buffer, Guid.NewGuid().ToString());
                    string data = string.Format("{0},{1},{2},{3},{4}", Parameter.SectionCode, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), readtxt, masterpiece, Parameter.User.Username);
                    File.WriteAllText(filename, data);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void AsyncInsertTable4(string readtxt)
        {
            try
            {
                CultureInfo ci = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture = ci;
                Thread.CurrentThread.CurrentUICulture = ci;
                int piece = 1;
                if (Parameter.Direction4 == "OUT")
                    piece *= (-1);
                if (Parameter.masterPieces.ContainsKey(readtxt))
                {
                    int masterpiece = (Parameter.masterPieces.FirstOrDefault(p => p.Key == readtxt).Value) * piece;
                    string filename = string.Format("{0}\\{1}.txt", Parameter.Buffer, Guid.NewGuid().ToString());
                    string data = string.Format("{0},{1},{2},{3},{4}", Parameter.SectionCode, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), readtxt, masterpiece, Parameter.User.Username);
                    File.WriteAllText(filename, data);
                }
            }
            catch (Exception)
            {

                throw;
            }


        }
        #endregion

        #region Save Data TO SQL Server

        private async void TakeStorageDataToSQL()
        {
            // StorageDataToSQL();
            await Task.Run(() => StorageDataToSQL());
            await Task.Run(() => ReadBinFolderToDataGridView());
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    StorageDataToSQL();
        //}
        private void StorageDataToSQL() // Task 1
        {
            try
            {
                CultureInfo ci = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture = ci;
                Thread.CurrentThread.CurrentUICulture = ci;

                string path = Parameter.Buffer + "\\";
                string[] result = Directory.GetFiles(path);
                if (result.Length == 0)
                    return;

                List<StockDataInputRequert> record = new List<StockDataInputRequert>();
                foreach (string file in result)
                {
                    string[] parts = File.ReadAllText(file).Split(',');
                    if (parts.Length == 5)
                    {
                        var input = new StockDataInputRequert();
                        input.SectionCode = parts[0];
                        input.RegistDate = Convert.ToDateTime(parts[1]);
                        input.PartNumber = parts[2];
                        input.PiecePerKanban = Convert.ToInt32(parts[3]);
                        input.UserId = Convert.ToInt32(parts[4]);
                        input.Status = false;
                        record.Add(input);
                    }

                }

                var section = record.GroupBy(s => s.SectionCode).Select
                    (s => new SectionCode
                    {
                        Sectioncode = s.Key
                    });




                var stockdatainput = new List<StockDataInput>();
                foreach (var predata in record)
                {
                    var buff = new StockDataInput();
                    buff.SectionCode = predata.SectionCode;
                    buff.RegistDateTime = DateTime.Now; //predata.RegistDate;
                    buff.PartNumber = predata.PartNumber;
                    buff.PiecePerKanban = predata.PiecePerKanban;
                    buff.UserId = predata.UserId;
                    buff.Status = false;

                    stockdatainput.Add(buff);


                }


                foreach (string file in result)
                {
                    File.Delete(file);
                }


            }
            catch
            {

            }

        }

        private void ReadBinFolderToDataGridView() // Task 2
        {
            try
            {

                CultureInfo ci = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture = ci;
                Thread.CurrentThread.CurrentUICulture = ci;

                string path = Parameter.Buffer + "\\";
                string[] result = Directory.GetFiles(path);

                var EStockDataInputRequert = new List<StockDataInputRequert>();
                foreach (string file in result)
                {
                    var predata = new StockDataInputRequert();
                    string[] parts = File.ReadAllText(file).Split(',');
                    predata.SectionCode = parts[0];
                    predata.RegistDate = Convert.ToDateTime(parts[1]);
                    predata.PartNumber = parts[2];
                    predata.PiecePerKanban = Convert.ToInt32(parts[3]);
                    predata.UserId = Convert.ToInt32(parts[4]);

                    EStockDataInputRequert.Add(predata);
                }
                ;

                if (dataGridView2.InvokeRequired)
                {
                    dataGridView2.Invoke(new Action(() =>
                    {
                        dataGridView2.AutoGenerateColumns = true;
                        dataGridView2.DataSource = EStockDataInputRequert;
                    }));
                }
                else
                {
                    dataGridView2.AutoGenerateColumns = true;
                    dataGridView2.DataSource = EStockDataInputRequert;
                }
            }
            catch (Exception e)
            {
                string msg = "\n Some log file has a problem \n Please delete file in c:\\stock\\bin ";
                MessageBox.Show(e.Message + msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion


        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            SerialPortSetting.Close(serialPort1);
            SerialPortSetting.Close(serialPort2);
            SerialPortSetting.Close(serialPort3);
            SerialPortSetting.Close(serialPort4);

            //LbSetting1.Text = LbSetting2.Text = LbSetting3.Text = LbSetting4.Text = string.Empty;
            //Message1.Text = Message2.Text = Message3.Text = Message4.Text = string.Empty;
            InitialSetup();
        }





        private void InvokeShowStockBalance(Action b)
        {
            try
            {
                this.BeginInvoke(new MethodInvoker(b));
            }
            catch { }
        }

        private void ShowStockBalance()
        {
            InvokeShowStockBalance(() =>
            {
                //using (var db = new WGRContext())
                //{
                //    var result = (from s in db.StockLists
                //                  where s.ActivePn == true
                //                  select new StockBalance
                //                  {
                //                      PartNumber = s.PartNumber,
                //                      Balance = s.Balance.ToString()
                //                  }).ToList();




                //    DgvShow.Rows.Clear();
                //    int i = 1;
                //    foreach (StockBalance s in result)
                //    {
                //        DgvShow.Rows.Add(i, s.PartNumber, s.Balance);
                //        i++;
                //    }

                //}
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowStockBalance1();
        }


        private void ShowStockBalance1()
        {

            //using (var db = new WGRContext())
            //{
            //    var result = (from s in db.StockLists
            //                  where s.ActivePn == true
            //                  select new StockBalance
            //                  {
            //                      PartNumber = s.PartNumber,
            //                      Balance = s.Balance.ToString()
            //                  }).ToList();


            //    //DgvShow.AutoGenerateColumns = true;
            //    //DgvShow.DataSource = result;

            //    DgvShow.Rows.Clear();
            //    int i = 1;
            //    foreach (StockBalance s in result)
            //    {
            //        DgvShow.Rows.Add(i, s.PartNumber, s.Balance);
            //        i++;
            //    }

            //}

        }









        private void button1_Click_1(object sender, EventArgs e)
        {
            ShowStockBalance();
        }

        private void CRUDClosed_Closed(object sender, EventArgs e)
        {
            Console.WriteLine();
            this.Visible = true;
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            try
            {
                CultureInfo ci = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture = ci;
                Thread.CurrentThread.CurrentUICulture = ci;
                string readtxt = "TG100000-1000";
                Parameter.SectionCode = "4320";

                int piece = 1;
                //if (Parameter.masterPieces.ContainsKey(readtxt))
                //{
                int masterpiece = (Parameter.masterPieces.FirstOrDefault(p => p.Key == readtxt).Value) * piece;
                string filename = string.Format("{0}\\{1}.txt", Parameter.Buffer, Guid.NewGuid().ToString());
                string data = string.Format("{0},{1},{2},{3},{4}", Parameter.SectionCode, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), readtxt, masterpiece, Parameter.User.Username);
                File.WriteAllText(filename, data);
                //}
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void BtnTest2_Click(object sender, EventArgs e)
        {
            try
            {
                CultureInfo ci = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture = ci;
                Thread.CurrentThread.CurrentUICulture = ci;
                string readtxt = "TG100000-1000";
                Parameter.SectionCode = "4320";

                int piece = -1;
                //if (Parameter.masterPieces.ContainsKey(readtxt))
                //{
                int masterpiece = (Parameter.masterPieces.FirstOrDefault(p => p.Key == readtxt).Value) * piece;
                string filename = string.Format("{0}\\{1}.txt", Parameter.Buffer, Guid.NewGuid().ToString());
                string data = string.Format("{0},{1},{2},{3},{4}", Parameter.SectionCode, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), readtxt, masterpiece, Parameter.User.Username);
                File.WriteAllText(filename, data);
                //}
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void StockBalanceHistoryClosed_Closed(object sender, EventArgs e)
        {
            Console.WriteLine();
            this.Visible = true;
        }


        private void IntialDataGridView(DataGridView dataGridView2)
        {
            dataGridView2.ColumnCount = 3;
            dataGridView2.Columns[0].Name = "No";
            dataGridView2.Columns[0].Width = 40;
            dataGridView2.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView2.Columns[1].Name = "PartNumber";
            dataGridView2.Columns[1].Width = 150;
            dataGridView2.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView2.Columns[2].Name = "Balance";
            dataGridView2.Columns[2].Width = 100;
            dataGridView2.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            dataGridView2.RowHeadersWidth = 4;
            dataGridView2.DefaultCellStyle.Font = new Font("Tahoma", 9);
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9);
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(153, 204, 215);
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
        }

        #region MEMU




        private void cH1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PortSettings uc = new PortSettings();
            uc.Dock = DockStyle.Fill;
            uc.SetData(1);
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void cH2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PortSettings uc = new PortSettings();
            uc.Dock = DockStyle.Fill;
            uc.SetData(2);
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void cH3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PortSettings uc = new PortSettings();
            uc.Dock = DockStyle.Fill;
            uc.SetData(3);
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void cH4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PortSettings uc = new PortSettings();
            uc.Dock = DockStyle.Fill;
            uc.SetData(4);
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void ch5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PortSettings uc = new PortSettings();
            uc.Dock = DockStyle.Fill;
            uc.SetData(5);
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void ch6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PortSettings uc = new PortSettings();
            uc.Dock = DockStyle.Fill;
            uc.SetData(6);
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void pattern1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QRcodepattern uc = new QRcodepattern();
            uc.Dock = DockStyle.Fill;
            uc.SetData(1);
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void pattern2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QRcodepattern uc = new QRcodepattern();
            uc.Dock = DockStyle.Fill;
            uc.SetData(2);
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void pattern3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QRcodepattern uc = new QRcodepattern();
            uc.Dock = DockStyle.Fill;
            uc.SetData(3);
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void pattern4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QRcodepattern uc = new QRcodepattern();
            uc.Dock = DockStyle.Fill;
            uc.SetData(4);
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void pattern5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QRcodepattern uc = new QRcodepattern();
            uc.Dock = DockStyle.Fill;
            uc.SetData(5);
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void pattern6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QRcodepattern uc = new QRcodepattern();
            uc.Dock = DockStyle.Fill;
            uc.SetData(6);
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void pattern7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QRcodepattern uc = new QRcodepattern();
            uc.Dock = DockStyle.Fill;
            uc.SetData(7);
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void pattern8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QRcodepattern uc = new QRcodepattern();
            uc.Dock = DockStyle.Fill;
            uc.SetData(8);
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void pattern9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QRcodepattern uc = new QRcodepattern();
            uc.Dock = DockStyle.Fill;
            uc.SetData(9);
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void pattern10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QRcodepattern uc = new QRcodepattern();
            uc.Dock = DockStyle.Fill;
            uc.SetData(10);
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }
        #endregion

        private void serialPortMonitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _inputInformation.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(_inputInformation);
        }

        private void connectionToServerSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectStockServer uc = new ConnectStockServer();
            uc.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }
    }
}
