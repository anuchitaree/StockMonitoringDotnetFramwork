using StockMonitoringDotnetFramwork.ChildForm;
using StockMonitoringDotnetFramwork.Classes;
using StockMonitoringDotnetFramwork.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMonitoringDotnetFramwork
{
    public partial class MainForm : Form
    {
        private static readonly SerialPort serialPort1 = new SerialPort();
        private static readonly SerialPort serialPort2 = new SerialPort();
        private static readonly SerialPort serialPort3 = new SerialPort();
        private static readonly SerialPort serialPort4 = new SerialPort();
        private static string ReadingText1;
        private static string ReadingText2;
        private static string ReadingText3;
        private static string ReadingText4;
        private static int Counter1;
        private static int Counter2;
        private static int Counter3;
        private static int Counter4;
        readonly CancellationTokenSource[] cts = new CancellationTokenSource[3];
        private readonly Dictionary<string, string> PiecePerKanbanDic = new Dictionary<string, string>();



        public MainForm()
        {
            InitializeComponent();

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
            LoginSimulate();
            IntialDataGridView(DgvShow);


            InputInformation uc = new InputInformation();
            uc.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(uc);


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

        private void LoginSimulate()
        {
            //var login = new AccountLogin();
            //Parameter.User = login.Login("6000774", "123456");
            //if (Parameter.User != null)
            //{
            //    Parameter.Permition = "on";
            //    Parameter.SectionCode = "4320";
            //    string path = string.Format("{0}\\startup.txt", Parameter.PortSetting);
            //    using (var db = new WGRContext())
            //    {
            //        var master = db.StockLists
            //            .Where(s => s.SectionCode == Parameter.SectionCode)
            //            .Select(s => new MasterPiece
            //            {
            //                PartNumberId = s.PartNumber,
            //                PiecePerKanban = Convert.ToInt32(s.PiecePerKanban)
            //            }).ToList();
            //        Parameter.masterPieces.Clear();
            //        foreach (var m in master)
            //        {
            //            Parameter.masterPieces.Add(m.PartNumberId, m.PiecePerKanban);
            //        }
            //        if (master.Count == 0)
            //        {
            //            string str = "No Master data, You input wrong the your SECTION-CODE \n";
            //            str += "althrough you log-in sucessed,the information will NOT send to DB \n";
            //            MessageBox.Show(str, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            Parameter.ErrorLoadFile = true;
            //        }
            //        else
            //        {
            //            Parameter.ErrorLoadFile = false;
            //        }
            //    }

            //}

        }


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
            Keepfile.SerialSetting();
            PortSettingDefault();
            string file1 = string.Format("{0}\\PortSetting1.txt", Parameter.PortSetting);
            string file2 = string.Format("{0}\\PortSetting2.txt", Parameter.PortSetting);
            string file3 = string.Format("{0}\\PortSetting3.txt", Parameter.PortSetting);
            string file4 = string.Format("{0}\\PortSetting4.txt", Parameter.PortSetting);
            LoadSettingAndOpenSerialPort(1, file1, serialPort1);
            LoadSettingAndOpenSerialPort(2, file2, serialPort2);
            LoadSettingAndOpenSerialPort(3, file3, serialPort3);
            LoadSettingAndOpenSerialPort(4, file4, serialPort4);
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
                string path = string.Format("{0}\\pattern.txt", Parameter.PortSetting);
                string data = File.ReadAllText(path);
                string[] parts = data.Split(',');
                if (parts.Length > 3)
                {
                    Parameter.Patterns.TotalLength = Convert.ToInt32(parts[0]);
                    Parameter.Patterns.Start = Convert.ToInt32(parts[1]);
                    Parameter.Patterns.Length = Convert.ToInt32(parts[2]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private void LoadSettingAndOpenSerialPort(int port, string destination, SerialPort serialPort)
        {
            try
            {
                string setting = File.ReadAllText(destination);

                string[] parts = setting.Split(',');
                if (parts.Length == 6)
                {
                    string comport = parts[0];
                    string BaudRate = parts[1];
                    string DataBits = parts[3];
                    string stopbit = parts[4];
                    string parity = parts[2];
                    string mode = parts[5];
                    serialPort.PortName = comport;
                    serialPort.BaudRate = Convert.ToInt32(BaudRate);
                    serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), parity);
                    serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopbit);
                    serialPort.DataBits = Convert.ToInt16(DataBits);

                    serialPort.Handshake = Handshake.None;
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
                                        //BtnPort1.BackColor = Color.FromArgb(0, 255, 0);
                                        timer1.Enabled = true;
                                        Parameter.Direction1 = mode;
                                        //LbSetting1.Text = string.Format("{0} : {1},{2},{3},{4},{5}", mode, comport, BaudRate, DataBits, stopbit, parity);
                                        break;
                                    case 2:
                                        serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler2);
                                        //BtnPort2.BackColor = Color.FromArgb(0, 255, 0);
                                        Parameter.Direction2 = mode;
                                        //LbSetting2.Text = string.Format("{0} : {1},{2},{3},{4},{5}", mode, comport, BaudRate, DataBits, stopbit, parity);
                                        timer2.Enabled = true;
                                        break;
                                    case 3:
                                        serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler3);
                                        //BtnPort3.BackColor = Color.FromArgb(0, 255, 0);
                                        //LbSetting3.Text = string.Format("{0} : {1},{2},{3},{4},{5}", mode, comport, BaudRate, DataBits, stopbit, parity);
                                        timer3.Enabled = true;
                                        Parameter.Direction3 = mode;
                                        break;
                                    case 4:
                                        serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler4);
                                        //BtnPort4.BackColor = Color.FromArgb(0, 255, 0);
                                        //LbSetting4.Text = string.Format("{0} : {1},{2},{3},{4},{5}", mode, comport, BaudRate, DataBits, stopbit, parity);
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
                throw;
            }

        }

        #endregion

        #region Data Receivece
        private static void DataReceivedHandler1(object sender, SerialDataReceivedEventArgs e)
        {

            SerialPort sp = (SerialPort)sender;
            //ReadingText1 = sp.ReadExisting().Trim('\r');
            try
            {
                ReadingText1 = sp.ReadExisting();
                if (!String.IsNullOrEmpty(ReadingText1))
                {
                    ReadingText1 = ReadingText1.Trim('\r');


                }
            }
            catch (Exception)
            {

                throw;
            }

            Counter1++;
            serialPort1.DiscardInBuffer();
            Console.WriteLine("Data Received Port 1:{0} : {1}", Counter1, ReadingText1);
        }

        private static void DataReceivedHandler2(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            //ReadingText2 = sp.ReadExisting().Trim('\r');
            try
            {
                ReadingText2 = sp.ReadExisting();
                if (!String.IsNullOrEmpty(ReadingText2))
                {
                    ReadingText2 = ReadingText2.Trim('\r');
                }
            }
            catch (Exception)
            {

                throw;
            }

            Counter2++;
            serialPort2.DiscardInBuffer();
            Console.WriteLine("Data Received Port 2:{0} : {1}", Counter2, ReadingText2);
        }

        private static void DataReceivedHandler3(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            //ReadingText3 = sp.ReadExisting().Trim('\r');
            try
            {
                ReadingText3 = sp.ReadExisting();
                if (!String.IsNullOrEmpty(ReadingText3))
                {
                    ReadingText3 = ReadingText3.Trim('\r');
                }
            }
            catch (Exception)
            {

                throw;
            }
            Counter3++;
            serialPort3.DiscardInBuffer();
            Console.WriteLine("Data Received Port 1:{0} : {1}", Counter3, ReadingText3);
        }

        private static void DataReceivedHandler4(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            //ReadingText4 = sp.ReadExisting().Trim('\r');
            try
            {
                ReadingText4 = sp.ReadExisting();
                if (!String.IsNullOrEmpty(ReadingText4))
                {
                    ReadingText4 = ReadingText4.Trim('\r');
                }
            }
            catch (Exception)
            {

                throw;
            }
            Counter4++;
            serialPort4.DiscardInBuffer();
            Console.WriteLine("Data Received Port 2:{0} : {1}", Counter4, ReadingText4);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (ReadingText1 != null)
            {
                //TbRaw1.Text = ReadingText1;

            }

            if (Parameter.User != null && ReadingText1 != null && ReadingText1 != "")
            {
                if (Parameter.Permition == "on" && ReadingText1.Length == Parameter.Patterns.TotalLength)
                {
                    ReadingText1 = ReadingText1.Substring(Parameter.Patterns.Start, Parameter.Patterns.Length);
                    AsyncInsertTable1(ReadingText1);
                }
                //Message1.Text = String.Format("Count: {0} ,P/N : {1}", Counter1, ReadingText1);
                ReadingText1 = null;
            }
            timer1.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            if (ReadingText2 != null)
            {
                //TbRaw2.Text = ReadingText2;

            }

            if (Parameter.User != null && ReadingText2 != null && ReadingText2 != "")
            {
                if (Parameter.Permition == "on" && ReadingText2.Length == Parameter.Patterns.TotalLength)
                {
                    ReadingText2 = ReadingText2.Substring(Parameter.Patterns.Start, Parameter.Patterns.Length);
                    AsyncInsertTable2(ReadingText2);
                }
                //Message2.Text = String.Format("Count: {0} ,P/N : {1}", Counter2, ReadingText2);
                ReadingText2 = null;
            }
            timer2.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Enabled = false;

            if (ReadingText3 != null)
                //TbRaw3.Text = ReadingText3;

            if (Parameter.User != null && ReadingText3 != null && ReadingText3 != "")
            {
                if (Parameter.Permition == "on" && ReadingText3.Length == Parameter.Patterns.TotalLength)
                {
                    ReadingText3 = ReadingText3.Substring(Parameter.Patterns.Start, Parameter.Patterns.Length);
                    AsyncInsertTable3(ReadingText3);
                }
                //Message3.Text = String.Format("Count: {0} ,P/N : {1}", Counter3, ReadingText3);
                ReadingText3 = null;
            }
            timer3.Enabled = true;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Enabled = false;

            if (ReadingText4 != null)
                //TbRaw4.Text = ReadingText4;

            if (Parameter.User != null && ReadingText4 != null && ReadingText4 != "")
            {
                if (Parameter.Permition == "on" && ReadingText4.Length == Parameter.Patterns.TotalLength)
                {
                    ReadingText4 = ReadingText4.Substring(Parameter.Patterns.Start, Parameter.Patterns.Length);
                    AsyncInsertTable4(ReadingText4);
                }
                //Message4.Text = String.Format("Count: {0} ,P/N : {1}", Counter4, ReadingText4);
                ReadingText4 = null;
            }
            timer4.Enabled = true;
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

                //using (var db = new WGRContext())
                //{
                //    foreach (var st in section)
                //    {
                //        var PartQty = record
                //            .Where(z => z.SectionCode == st.Sectioncode)
                //            .GroupBy(s => s.PartNumber)
                //            .Select(s => new
                //            {
                //                PartNumber = s.Key,
                //                Qty = s.Sum(a => a.PiecePerKanban)
                //            }).ToList();


                //        var stocklist = db.StockLists.Where(s => s.SectionCode == st.Sectioncode)
                //            .Select(s => new StockListOnly
                //            {
                //                PartNumber = s.PartNumber,
                //                Balance = Convert.ToInt32(s.Balance),
                //                PiecePerKanban = Convert.ToInt32(s.PiecePerKanban),
                //                HHLimit = Convert.ToInt32(s.Hhlimit),
                //                HLimit = Convert.ToInt32(s.Hlimit),
                //                LLimit = Convert.ToInt32(s.Llimit),
                //                LLLimt = Convert.ToInt32(s.Lllimt),
                //                ActivePn = s.ActivePn

                //            }).ToList();




                //        foreach (var l in PartQty)
                //        {
                //            StockListOnly sl = stocklist.Where(p => p.PartNumber == l.PartNumber).FirstOrDefault();
                //            if (sl != null)
                //            {
                //                var sm = new StockList();
                //                sm.SectionCode = st.Sectioncode;
                //                sm.PartNumber = l.PartNumber;
                //                sm.Balance = l.Qty + Convert.ToInt32(sl.Balance);
                //                sm.Balance = sm.Balance < 0 ? 0 : sm.Balance;
                //                sm.PiecePerKanban = sl.PiecePerKanban;
                //                sm.Hhlimit = sl.HHLimit;
                //                sm.Hlimit = sl.HLimit;
                //                sm.Llimit = sl.LLimit;
                //                sm.Lllimt = sl.LLLimt;
                //                sm.ActivePn = sl.ActivePn;
                //                db.Update(sm);
                //                db.SaveChanges();


                //                var listlog = new StockListLog
                //                {
                //                    SectionCode = sm.SectionCode,
                //                    Registdatetime = DateTime.Now,
                //                    PartNumber = sm.PartNumber,
                //                    Balance = sm.Balance
                //                };
                //                db.StockListLogs.Add(listlog);
                //                db.SaveChanges();


                //                //db.StockListLogs.Add(new StockListLog
                //                //{

                //                //    SectionCode = sm.SectionCode,
                //                //    Registdatetime = DateTime.Now,
                //                //    PartNumber = sm.PartNumber,
                //                //    Balance = sm.Balance

                //                //});
                //                //  db.SaveChanges();





                //            }
                //        }


                //    }


                //}





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



                    //    //db.StockDataInputs.Add(new StockDataInput
                    //    //{
                    //    //    SectionCode = predata.SectionCode,
                    //    //    RegistDate = predata.RegistDate,
                    //    //    PartNumber = predata.PartNumber,
                    //    //    PiecePerKanban = predata.PiecePerKanban,
                    //    //    UserId = predata.UserId,
                    //    //    Status = false
                    //    //});



                }
                //using (var db1 = new WGRContext())
                //{
                //    db1.StockDataInputs.AddRange(stockdatainput);
                //    db1.SaveChanges();
                //}


                foreach (string file in result)
                {
                    File.Delete(file);
                }



                //if (richTextBox1.InvokeRequired)
                //{
                //    richTextBox1.Invoke(new Action(() =>
                //    {
                //        richTextBox1.Text = string.Empty;
                //    }));
                //}

            }
            catch (Exception e)
            {
                //if (richTextBox1.InvokeRequired)
                //{
                //    richTextBox1.Invoke(new Action(() =>
                //    {
                //        richTextBox1.Text = e.Message;
                //    }));
                //}
                //throw;

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
        private async void BtnTest2_Click(object sender, EventArgs e)
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
    }
}
