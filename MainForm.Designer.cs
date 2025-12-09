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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvShow)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(730, 564);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(75, 15);
            this.dataGridView2.TabIndex = 6;
            // 
            // DgvShow
            // 
            this.DgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvShow.Location = new System.Drawing.Point(822, 564);
            this.DgvShow.Name = "DgvShow";
            this.DgvShow.Size = new System.Drawing.Size(73, 15);
            this.DgvShow.TabIndex = 7;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(950, 24);
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
            this.inputFilterSettingToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
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
            this.inputSettingToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.inputSettingToolStripMenuItem.Text = "Input setting";
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
            this.inputFilterSettingToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.inputFilterSettingToolStripMenuItem.Text = "Input pattern";
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.50604F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.49396F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.988764F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.01124F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(911, 531);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(454, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 478);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 478);
            this.panel2.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
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
    }
}

