namespace StockMonitoringDotnetFramwork
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DgvShow = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cH1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cH2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cH3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cH4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ch5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ch6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputFilterSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pattern1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pattern2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pattern3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pattern4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pattern5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pattern6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pattern7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pattern8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pattern9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pattern10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToServerSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPortMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockMonitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockAccumulateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockNotificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.testComportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ch2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ch3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ch4ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ch5ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ch6ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvShow)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(572, 623);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(214, 10);
            this.dataGridView2.TabIndex = 6;
            // 
            // DgvShow
            // 
            this.DgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvShow.Location = new System.Drawing.Point(807, 623);
            this.DgvShow.Name = "DgvShow";
            this.DgvShow.Size = new System.Drawing.Size(159, 10);
            this.DgvShow.TabIndex = 7;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.utilityToolStripMenuItem,
            this.stockMonitoringToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1300, 24);
            this.menuStrip2.TabIndex = 13;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputSettingToolStripMenuItem,
            this.inputFilterSettingToolStripMenuItem,
            this.connectionToServerSettingToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.toolsToolStripMenuItem.Text = "Setting";
            // 
            // inputSettingToolStripMenuItem
            // 
            this.inputSettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cH1ToolStripMenuItem,
            this.cH2ToolStripMenuItem,
            this.cH3ToolStripMenuItem,
            this.cH4ToolStripMenuItem,
            this.ch5ToolStripMenuItem,
            this.ch6ToolStripMenuItem});
            this.inputSettingToolStripMenuItem.Name = "inputSettingToolStripMenuItem";
            this.inputSettingToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.inputSettingToolStripMenuItem.Text = "Serial port setting";
            // 
            // cH1ToolStripMenuItem
            // 
            this.cH1ToolStripMenuItem.Name = "cH1ToolStripMenuItem";
            this.cH1ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.cH1ToolStripMenuItem.Text = "Ch.1";
            this.cH1ToolStripMenuItem.Click += new System.EventHandler(this.cH1ToolStripMenuItem_Click);
            // 
            // cH2ToolStripMenuItem
            // 
            this.cH2ToolStripMenuItem.Name = "cH2ToolStripMenuItem";
            this.cH2ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.cH2ToolStripMenuItem.Text = "Ch.2";
            this.cH2ToolStripMenuItem.Click += new System.EventHandler(this.cH2ToolStripMenuItem_Click);
            // 
            // cH3ToolStripMenuItem
            // 
            this.cH3ToolStripMenuItem.Name = "cH3ToolStripMenuItem";
            this.cH3ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.cH3ToolStripMenuItem.Text = "Ch.3";
            this.cH3ToolStripMenuItem.Click += new System.EventHandler(this.cH3ToolStripMenuItem_Click);
            // 
            // cH4ToolStripMenuItem
            // 
            this.cH4ToolStripMenuItem.Name = "cH4ToolStripMenuItem";
            this.cH4ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.cH4ToolStripMenuItem.Text = "Ch.4";
            this.cH4ToolStripMenuItem.Click += new System.EventHandler(this.cH4ToolStripMenuItem_Click);
            // 
            // ch5ToolStripMenuItem
            // 
            this.ch5ToolStripMenuItem.Name = "ch5ToolStripMenuItem";
            this.ch5ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.ch5ToolStripMenuItem.Text = "Ch.5";
            this.ch5ToolStripMenuItem.Click += new System.EventHandler(this.ch5ToolStripMenuItem_Click);
            // 
            // ch6ToolStripMenuItem
            // 
            this.ch6ToolStripMenuItem.Name = "ch6ToolStripMenuItem";
            this.ch6ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.ch6ToolStripMenuItem.Text = "Ch.6";
            this.ch6ToolStripMenuItem.Click += new System.EventHandler(this.ch6ToolStripMenuItem_Click);
            // 
            // inputFilterSettingToolStripMenuItem
            // 
            this.inputFilterSettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pattern1ToolStripMenuItem,
            this.pattern2ToolStripMenuItem,
            this.pattern3ToolStripMenuItem,
            this.pattern4ToolStripMenuItem,
            this.pattern5ToolStripMenuItem,
            this.pattern6ToolStripMenuItem,
            this.pattern7ToolStripMenuItem,
            this.pattern8ToolStripMenuItem,
            this.pattern9ToolStripMenuItem,
            this.pattern10ToolStripMenuItem});
            this.inputFilterSettingToolStripMenuItem.Name = "inputFilterSettingToolStripMenuItem";
            this.inputFilterSettingToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.inputFilterSettingToolStripMenuItem.Text = "Input pattern setting";
            // 
            // pattern1ToolStripMenuItem
            // 
            this.pattern1ToolStripMenuItem.Name = "pattern1ToolStripMenuItem";
            this.pattern1ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.pattern1ToolStripMenuItem.Text = "Pattern 1";
            this.pattern1ToolStripMenuItem.Click += new System.EventHandler(this.pattern1ToolStripMenuItem_Click);
            // 
            // pattern2ToolStripMenuItem
            // 
            this.pattern2ToolStripMenuItem.Name = "pattern2ToolStripMenuItem";
            this.pattern2ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.pattern2ToolStripMenuItem.Text = "Pattern 2";
            this.pattern2ToolStripMenuItem.Click += new System.EventHandler(this.pattern2ToolStripMenuItem_Click);
            // 
            // pattern3ToolStripMenuItem
            // 
            this.pattern3ToolStripMenuItem.Name = "pattern3ToolStripMenuItem";
            this.pattern3ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.pattern3ToolStripMenuItem.Text = "Pattern 3";
            this.pattern3ToolStripMenuItem.Click += new System.EventHandler(this.pattern3ToolStripMenuItem_Click);
            // 
            // pattern4ToolStripMenuItem
            // 
            this.pattern4ToolStripMenuItem.Name = "pattern4ToolStripMenuItem";
            this.pattern4ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.pattern4ToolStripMenuItem.Text = "Pattern 4";
            this.pattern4ToolStripMenuItem.Click += new System.EventHandler(this.pattern4ToolStripMenuItem_Click);
            // 
            // pattern5ToolStripMenuItem
            // 
            this.pattern5ToolStripMenuItem.Name = "pattern5ToolStripMenuItem";
            this.pattern5ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.pattern5ToolStripMenuItem.Text = "Pattern 5";
            this.pattern5ToolStripMenuItem.Click += new System.EventHandler(this.pattern5ToolStripMenuItem_Click);
            // 
            // pattern6ToolStripMenuItem
            // 
            this.pattern6ToolStripMenuItem.Name = "pattern6ToolStripMenuItem";
            this.pattern6ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.pattern6ToolStripMenuItem.Text = "Pattern 6";
            this.pattern6ToolStripMenuItem.Click += new System.EventHandler(this.pattern6ToolStripMenuItem_Click);
            // 
            // pattern7ToolStripMenuItem
            // 
            this.pattern7ToolStripMenuItem.Name = "pattern7ToolStripMenuItem";
            this.pattern7ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.pattern7ToolStripMenuItem.Text = "Pattern 7";
            this.pattern7ToolStripMenuItem.Click += new System.EventHandler(this.pattern7ToolStripMenuItem_Click);
            // 
            // pattern8ToolStripMenuItem
            // 
            this.pattern8ToolStripMenuItem.Name = "pattern8ToolStripMenuItem";
            this.pattern8ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.pattern8ToolStripMenuItem.Text = "Pattern 8";
            this.pattern8ToolStripMenuItem.Click += new System.EventHandler(this.pattern8ToolStripMenuItem_Click);
            // 
            // pattern9ToolStripMenuItem
            // 
            this.pattern9ToolStripMenuItem.Name = "pattern9ToolStripMenuItem";
            this.pattern9ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.pattern9ToolStripMenuItem.Text = "Pattern 9";
            this.pattern9ToolStripMenuItem.Click += new System.EventHandler(this.pattern9ToolStripMenuItem_Click);
            // 
            // pattern10ToolStripMenuItem
            // 
            this.pattern10ToolStripMenuItem.Name = "pattern10ToolStripMenuItem";
            this.pattern10ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.pattern10ToolStripMenuItem.Text = "Pattern 10";
            this.pattern10ToolStripMenuItem.Click += new System.EventHandler(this.pattern10ToolStripMenuItem_Click);
            // 
            // connectionToServerSettingToolStripMenuItem
            // 
            this.connectionToServerSettingToolStripMenuItem.Name = "connectionToServerSettingToolStripMenuItem";
            this.connectionToServerSettingToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.connectionToServerSettingToolStripMenuItem.Text = "Connection to server setting";
            this.connectionToServerSettingToolStripMenuItem.Click += new System.EventHandler(this.connectionToServerSettingToolStripMenuItem_Click);
            // 
            // utilityToolStripMenuItem
            // 
            this.utilityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serialPortMonitorToolStripMenuItem,
            this.testComportToolStripMenuItem});
            this.utilityToolStripMenuItem.Name = "utilityToolStripMenuItem";
            this.utilityToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.utilityToolStripMenuItem.Text = "Utility";
            // 
            // serialPortMonitorToolStripMenuItem
            // 
            this.serialPortMonitorToolStripMenuItem.Name = "serialPortMonitorToolStripMenuItem";
            this.serialPortMonitorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serialPortMonitorToolStripMenuItem.Text = "Serial port monitor";
            this.serialPortMonitorToolStripMenuItem.Click += new System.EventHandler(this.serialPortMonitorToolStripMenuItem_Click);
            // 
            // stockMonitoringToolStripMenuItem
            // 
            this.stockMonitoringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockAccumulateToolStripMenuItem,
            this.stockTransactionToolStripMenuItem,
            this.stockChartToolStripMenuItem,
            this.stockNotificationToolStripMenuItem});
            this.stockMonitoringToolStripMenuItem.Name = "stockMonitoringToolStripMenuItem";
            this.stockMonitoringToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.stockMonitoringToolStripMenuItem.Text = "Stock monitoring";
            // 
            // stockAccumulateToolStripMenuItem
            // 
            this.stockAccumulateToolStripMenuItem.Name = "stockAccumulateToolStripMenuItem";
            this.stockAccumulateToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.stockAccumulateToolStripMenuItem.Text = "Stock accumulate";
            // 
            // stockTransactionToolStripMenuItem
            // 
            this.stockTransactionToolStripMenuItem.Name = "stockTransactionToolStripMenuItem";
            this.stockTransactionToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.stockTransactionToolStripMenuItem.Text = "Stock transaction";
            // 
            // stockChartToolStripMenuItem
            // 
            this.stockChartToolStripMenuItem.Name = "stockChartToolStripMenuItem";
            this.stockChartToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.stockChartToolStripMenuItem.Text = "Stock chart";
            // 
            // stockNotificationToolStripMenuItem
            // 
            this.stockNotificationToolStripMenuItem.Name = "stockNotificationToolStripMenuItem";
            this.stockNotificationToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.stockNotificationToolStripMenuItem.Text = "Stock notification";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.02375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.97625F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 54);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.988764F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.01124F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(964, 531);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(388, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 478);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 478);
            this.panel2.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 28);
            this.button4.TabIndex = 0;
            this.button4.Text = "CH4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 26);
            this.button2.TabIndex = 0;
            this.button2.Text = "CH2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(85, 80);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(247, 20);
            this.textBox6.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 22);
            this.button3.TabIndex = 0;
            this.button3.Text = "CH3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(85, 106);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(247, 20);
            this.textBox8.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(85, 45);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(247, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 7);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(247, 20);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "CH1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM";
            // 
            // testComportToolStripMenuItem
            // 
            this.testComportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chToolStripMenuItem,
            this.ch2ToolStripMenuItem1,
            this.ch3ToolStripMenuItem1,
            this.ch4ToolStripMenuItem1,
            this.ch5ToolStripMenuItem1,
            this.ch6ToolStripMenuItem1});
            this.testComportToolStripMenuItem.Name = "testComportToolStripMenuItem";
            this.testComportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testComportToolStripMenuItem.Text = "Test serial port";
            // 
            // chToolStripMenuItem
            // 
            this.chToolStripMenuItem.Name = "chToolStripMenuItem";
            this.chToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chToolStripMenuItem.Text = "Ch.1";
            // 
            // ch2ToolStripMenuItem1
            // 
            this.ch2ToolStripMenuItem1.Name = "ch2ToolStripMenuItem1";
            this.ch2ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ch2ToolStripMenuItem1.Text = "Ch.2";
            // 
            // ch3ToolStripMenuItem1
            // 
            this.ch3ToolStripMenuItem1.Name = "ch3ToolStripMenuItem1";
            this.ch3ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ch3ToolStripMenuItem1.Text = "Ch.3";
            // 
            // ch4ToolStripMenuItem1
            // 
            this.ch4ToolStripMenuItem1.Name = "ch4ToolStripMenuItem1";
            this.ch4ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ch4ToolStripMenuItem1.Text = "Ch.4";
            // 
            // ch5ToolStripMenuItem1
            // 
            this.ch5ToolStripMenuItem1.Name = "ch5ToolStripMenuItem1";
            this.ch5ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ch5ToolStripMenuItem1.Text = "Ch.5";
            // 
            // ch6ToolStripMenuItem1
            // 
            this.ch6ToolStripMenuItem1.Name = "ch6ToolStripMenuItem1";
            this.ch6ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ch6ToolStripMenuItem1.Text = "Ch.6";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 859);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.DgvShow);
            this.Controls.Add(this.dataGridView2);
            this.Name = "MainForm";
            this.Text = "Stock monitoring sample (free license)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvShow)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView DgvShow;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cH1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cH2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cH3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cH4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ch5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ch6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputFilterSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pattern1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pattern2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pattern3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pattern4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pattern5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pattern6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pattern7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pattern8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pattern9ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pattern10ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem utilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serialPortMonitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToServerSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockMonitoringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockAccumulateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockNotificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testComportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ch2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ch3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ch4ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ch5ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ch6ToolStripMenuItem1;
    }
}

