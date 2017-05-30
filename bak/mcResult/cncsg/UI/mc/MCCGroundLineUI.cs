using cn.csg.dpcp.common;
using Hvdc.MT.HvdcCommon;
using Hvdc.MT.mc.App;
using Hvdc.MT.mc.Def;
using Hvdc.MT.mc.Device;
using System;

namespace cn.csg.dpcp.ui.mc
{
    public partial class MCCGroundLineUI : MCBaseUI
    {
        public MCCGroundLineUI()
        {
            InitializeComponent();
            Name = Constants.MC_CGroundLine;
        }

        /// <summary>
        /// 界面数据重置
        /// </summary>
        protected override void RestUI()
        {
            base.RestUI();
            numZrMax.ResetText();
            numZrMin.ResetText();
            txtStationName.Clear();
        }
        private void MCCGroundLineUI_Load(object sender, EventArgs e)
        {
            InitForm(CmcVars.pmcHvdcGrid, CHvdcDefs.mcGridType, CmcDef.mc_GroundLine);
            FillComboxFromDevice(cboDeviceID);
        }

        protected override void DevToUI()
        {
            CmcDevGroundLine vo = Device as CmcDevGroundLine;
            cboDeviceID.SelectedItem = vo.DeviceID;
            txtDeviceName.Text = vo.DeviceName;
            txtDeviceType.Text = vo.DeviceType + "";
            txtStationName.Text = vo.StationNames[0];
            numZrMax.Value = (decimal)vo.ZrMax;
            numZrN.Value = (decimal)vo.ZrN;
            numZrMin.Value = (decimal)vo.ZrMin;
        }

        protected override void uiToDev()
        {
            CmcDevGroundLine vo = Device as CmcDevGroundLine;
            vo.DeviceName = txtDeviceName.Text;
            vo.DeviceType = vo.DeviceType;
            vo.StationNames[0] = txtStationName.Text;
            vo.ZrMax = (double)numZrMax.Value;
            vo.ZrMin = (double)numZrMin.Value;
            vo.ZrN = (double)numZrMax.Value;
        }

    }
}
