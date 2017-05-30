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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubForm1 form1 = new SubForm1();
            //form1.MdiParent = this;
            //form1.Show();

            form1.TopLevel = false;
            form1.Dock = DockStyle.Fill;
            this.pnl.Controls.Clear();
            this.pnl.Controls.Add(form1);
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SubForm2 form2 = new SubForm2();
            //form2.MdiParent = this;
            //form2.Show();
            form2.TopLevel = false;
            form2.Dock = DockStyle.Fill;
            this.pnl.Controls.Clear();
            this.pnl.Controls.Add(form2);
            form2.Show();
        }
    }
}
