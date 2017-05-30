﻿using cn.csg.dpcp.model;
using cn.csg.dpcp.model.vo;
using cn.csg.dpcp.model.vo.mc;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Yao.BaseFrame.Device;
using Hvdc.MT.mc.DevTBL;
using Yao.BaseFrame.DevTBL;
using Hvdc.MT.mc.App;
using Hvdc.MT.mc.Def;

namespace cn.csg.dpcp.ui.mc
{
    public partial class MCBaseUI : DpcpBaseForm
    {
        public MCBaseUI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 将对象中的值保存到数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            OnSave();
        }

        private void cboDeviceID_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnDeviceChanged(cboDeviceID);

        }

        /// <summary>
        /// 界面数据重置
        /// </summary>
        protected virtual void RestUI()
        {
            txtStationName.Clear();
        }

        private void MCBaseUI_Load(object sender, EventArgs e)
        {
            //RestUI();
        }

        // 隐藏上下箭头按钮
        protected void initNumControlButton(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c.Controls.Count > 0)
                {
                    initNumControlButton(c);
                }
                if (c is NumericUpDown)
                {
                    (c as NumericUpDown).Controls[0].Visible = false;
                }
            }
        }

        /// <summary>
        /// 将界面的上的值保存到对象
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApply_Click(object sender, EventArgs e)
        {
            OnApply();
        }
    }
}
