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
    public partial class Drawing : Form
    {
        public Drawing()
        {
            InitializeComponent();
            this.txtTest.Text = (Convert.ToInt32(true) * -1).ToString();
            //Convert.ToBoolean
        }

        private void Drawing_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.SkyBlue);
           Rectangle r = new Rectangle(new Point(10,10), new Size(100,50));
            g.DrawEllipse(p, r);
        }
    }
}
