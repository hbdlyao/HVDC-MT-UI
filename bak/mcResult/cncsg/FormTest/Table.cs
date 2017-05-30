using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cn.csg.dpcp.test
{
    public partial class Table : Form
    {
        private Color color;
        public Table()
        {
            InitializeComponent();
            color = dataGridViewX1.ColumnHeadersDefaultCellStyle.BackColor;
        }

        private void dataGridViewX1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            
            DataGridViewX d = sender as DataGridViewX;
            d.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Black;
            d.Columns[e.ColumnIndex].DefaultCellStyle.BackColor = Color.White;
        }

        private void dataGridViewX1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X,
       e.RowBounds.Location.Y,
       dataGridViewX1.RowHeadersWidth - 4,
       e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dataGridViewX1.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dataGridViewX1.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void dataGridViewX1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridViewX1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            dataGridViewX1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(0, 64, 64);
        }


        private void dataGridViewX1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridViewX1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.SkyBlue;
        }

        private void dataGridViewX1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewX1.Rows[e.RowIndex].DefaultCellStyle.BackColor = color;
        }
    }
}
