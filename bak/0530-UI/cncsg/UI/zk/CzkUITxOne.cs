using Hvdc.MT.xb.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cn.csg.dpcp.ui.zk
{
    public partial class CzkUITxOne : CfmBaseFrom
    {
        protected CxbDevDCF_RLC DevDCF_RLC;

        public CzkUITxOne()
        {
            InitializeComponent();
        }

        public CzkUITxOne(CxbDevDCF_RLC vDev)
        {
            InitializeComponent();
            DevDCF_RLC = vDev;
            MessageBox.Show(DevDCF_RLC.DeviceName);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
