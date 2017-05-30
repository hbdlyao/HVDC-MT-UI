using cn.csg.dpcp.common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cn.csg.dpcp.ui
{
    public partial class NewDcLineUIcs : Form
    {
        // 返回新建工程结果，1=新建成功，-1=新建失败或者取消新建
        private int result = -1;
        
        public int Result
        {
            get { return result; }
        }

        public NewDcLineUIcs()
        {
            InitializeComponent();
        }

        public NewDcLineUIcs(string vName)
        {
            InitializeComponent();
            Name = vName;
        }

        public string[] Stations()
        {
            return new string[] { txtLineName.Text, txtStation1.Text, txtStation2.Text };
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                valivate();
                result = 1;
                Close();
            }
            catch (Exception ex)
            {
                result = -1;
                MessageBox.Show(ex.Message);
            }
        }

        private void valivate()
        {
            if (StringUtil.IsEmpty(txtStation1.Text))
            {
                throw new Exception("请输入线路名称");
            }
            if (StringUtil.IsEmpty(txtStation1.Text))
            {
                throw new Exception("请输入首端换流站");
            }
            if (StringUtil.IsEmpty(txtStation2.Text))
            {
                throw new Exception("请输入末端换流站");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            result = -1;
            Close();
        }
    }
}
