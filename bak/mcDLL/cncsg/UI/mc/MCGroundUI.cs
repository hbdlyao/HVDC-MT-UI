using cn.csg.dpcp.common;
using cn.csg.dpcp.dal;
using cn.csg.dpcp.dal.mc;
using cn.csg.dpcp.model.dataset;
using cn.csg.dpcp.model.vo.mc;
using Hvdc.MT.HvdcCommon;
using Hvdc.MT.mc.App;
using Hvdc.MT.mc.Def;
using Hvdc.MT.mc.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Yao.BaseFrame.Device;

namespace cn.csg.dpcp.ui.mc
{
    public partial class MCGroundUI : MCBaseUI
    {
        public MCGroundUI()
        {
            InitializeComponent();
            Name = Constants.MC_CGround;
        }
       
        /// <summary>
        /// 界面数据重置
        /// </summary>
        protected override void RestUI()
        {
            base.RestUI();
            numZr.ResetText();
        }

        private void MCGroundUI_Load(object sender, EventArgs e)
        {
            InitForm(CmcVars.pmcHvdcGrid, CHvdcDefs.mcGridType, CmcDef.mc_Ground);
            FillComboxFromDevice(cboDeviceID);
        }

        protected override void DevToUI()
        {
            CmcDevGround vo = Device as CmcDevGround;
            cboDeviceID.SelectedItem = vo.DeviceID;
            txtDeviceName.Text = vo.DeviceName;
            txtDeviceType.Text = vo.DeviceType + "";
            txtStationName.Text = vo.StationNames[0];
            numZr.Value = (decimal)vo.Zr;
        }

        protected override void uiToDev()
        {
            CmcDevGround vo = Device as CmcDevGround;
            vo.DeviceName = txtDeviceName.Text;
            vo.DeviceType = int.Parse(txtDeviceType.Text);
            vo.StationNames[0] = txtStationName.Text;
            vo.Zr = (double)numZr.Value;
        }

    }
}
