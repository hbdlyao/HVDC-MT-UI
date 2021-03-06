﻿using cn.csg.dpcp.common;
using Hvdc.MT.mc.App;
using Hvdc.MT.mc.DevTBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yao.BaseFrame.DevTBL;

namespace cn.csg.dpcp.ui
{
    public partial class CDlgNewDCLine : Form
    {
        // 返回新建工程结果，1=新建成功，-1=新建失败或者取消新建
        private int result = -1;
        
        public int Result
        {
            get { return result; }
        }

        public CDlgNewDCLine()
        {
            InitializeComponent();
        }

        public CDlgNewDCLine(string vName)
        {
            InitializeComponent();
            Name = vName;
        }

        public string[] Stations()
        {
            return new string[] { txtLineName.Text, cboStation1.Text, cboStation2.Text };
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                validate();
                result = 1;
                Close();
            }
            catch (Exception ex)
            {
                result = -1;
                MessageBox.Show(ex.Message);
            }
        }

        private void validate()
        {
            if (StringUtil.IsEmpty(txtLineName.Text))
            {
                throw new Exception("请输入线路名称");
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            result = -1;
            Close();
        }

        private void CDlgNewDCLine_Load(object sender, EventArgs e)
        {
            //
            foreach (KeyValuePair<string,CDevStation> vPair in CmcVars.pmcHvdcGrid.Stations())
            {
                cboStation1.Items.Add(vPair.Key);
                cboStation2.Items.Add(vPair.Key);
            }

            if (cboStation1.Items.Count > 0)
            {
                cboStation1.SelectedIndex = 0;
                cboStation2.SelectedIndex = 0;
            }



        }
    }
}
