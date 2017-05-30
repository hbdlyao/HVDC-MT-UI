using cn.csg.dpcp.common;
using Hvdc.MT.HvdcCommon;
using Hvdc.MT.mc.App;
using Hvdc.MT.mc.Def;
using Hvdc.MT.mc.Device;
using System;

namespace cn.csg.dpcp.ui.mc
{
    public partial class MCDcMetallLineUI : MCBaseUI
    {
        public MCDcMetallLineUI()
        {
            InitializeComponent();
            Name = Constants.MC_CDcMetalLine;
        }

        private void MCDcMetalLineUI_Load(object sender, EventArgs e)
        {
            InitForm(CmcVars.pmcHvdcGrid, CHvdcDefs.mcGridType, CmcDef.mc_MetalLine);
            FillComboxFromDevice(cboDeviceID);
        }

        protected override void DevToUI()
        {
            CmcDevMetalLine vo = Device as CmcDevMetalLine;
            cboDeviceID.SelectedItem = vo.DeviceID;
            txtDeviceName.Text = vo.DeviceName;
            txtDeviceType.Text = vo.DeviceType + "";
            txtStationName1.Text = vo.StationNames[0];
            txtStationName2.Text = vo.StationNames[1];
            numZrMax.Value = (decimal)vo.ZrMax;
            numZrMin.Value = (decimal)vo.ZrMin;
            numZrN.Value = (decimal)vo.ZrN;
        }

        protected override void uiToDev()
        {
            CmcDevMetalLine vo = Device as CmcDevMetalLine;
            vo.DeviceName = txtDeviceName.Text;
            vo.DeviceType = int.Parse(txtDeviceType.Text);
            vo.ZrMax = (double)numZrMax.Value;
            vo.ZrMin = (double)numZrMin.Value;
            vo.StationNames[0] = txtStationName1.Text;
            vo.StationNames[1] = txtStationName2.Text;
            vo.ZrN =(double)numZrMax.Value;
        }

    }
}
