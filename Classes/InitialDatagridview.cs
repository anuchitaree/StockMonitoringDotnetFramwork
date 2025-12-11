using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMonitoringDotnetFramwork.Classes
{
    public static class InitialDatagridview
    {

        public static void Pattern_1(string[] col_head,int[] col_width, DataGridView dataGridView2)
        {
            dataGridView2.ColumnCount = col_head.Length;

            for (int i = 0; i < col_head.Length; i++) 
            {
                dataGridView2.Columns[i].Name = col_head[i];
                dataGridView2.Columns[i].Width = col_width[i];
                dataGridView2.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
                       

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

    }
}
