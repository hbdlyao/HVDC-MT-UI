using cn.csg.dpcp.common;
using Hvdc.MT.HvdcCommon;
using Hvdc.MT.mc.App;
using Hvdc.MT.mc.Def;
using Hvdc.MT.mc.Device;
using System;

namespace cn.csg.dpcp.ui.mc
{
    public partial class CmcUIMetalLine : CmcUIBase
    {
        public CmcUIMetalLine()
        {
            InitializeComponent();
            Name = Constants.MC_CDcMetalLine;
        }

        private void MCDcMetalLineUI_Load(object sender, EventArgs e)
        {
            foreach (var item in CmcVars.pmcHvdcGrid.Stations())
            {
                cboStation1.Items.Add(item.Key);
                cboStation2.Items.Add(item.Key);
            }
            InitForm(CmcVars.pmcHvdcGrid, CHvdcDefs.mcGridType, CmcDef.mc_MetalLine);
            FillComboxFromDevice(cboDeviceID);
        }

        protected override void DevToUI()
        {
            CmcDevMetalLine vo = Device as CmcDevMetalLine;
            cboDeviceID.SelectedItem = vo.DeviceID;
            cboStation1.SelectedItem = vo.StationNames[0];
            cboStation2.SelectedItem = vo.StationNames[1];
            numZrMax.Value = (decimal)vo.ZrMax;
            numZrMin.Value = (decimal)vo.ZrMin;
            numZrN.Value = (decimal)vo.ZrN;
        }

        protected override void uiToDev()
        {
            CmcDevMetalLine vo = Device as CmcDevMetalLine;
            vo.ZrMax = (double)numZrMax.Value;
            vo.ZrMin = (double)numZrMin.Value;
            vo.StationNames[0] = cboStation1.SelectedItem.ToString();
            vo.StationNames[1] = cboStation2.SelectedItem.ToString();
            vo.ZrN =(double)numZrMax.Value;
        }

  
        private void btnAddLine_Click(object sender, EventArgs e)
        {
            CDlgNewDCLine vLine = new CDlgNewDCLine();
            vLine.ShowDialog();
            if (vLine.Result == 1)
            {
                string[] vNames = vLine.Stations();
                //
                OnAddNew(vNames);

                EnableControl();

            }
        }

        protected override void OnAddNew(string[] vNames)
        {

            Device = DevTbl.NewDevice(deviceType, vNames[0]);

            Device.StationNames[0] = vNames[1];
            Device.StationNames[1] = vNames[2];

            DevGrid.DeviceAdd(tblType, Device);

            cboDeviceID.Items.Insert(0, vNames[0]);
            deviceMap.Add(Device.DeviceName, Device);

            cboDeviceID.SelectedIndex = 0;

        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            OnRemove();

            EnableControl();

        }

        protected override void OnRemove()
        {
            DevGrid.DeviceRemove(tblType, Device);

            cboDeviceID.Items.Remove(Device.DeviceName);
            deviceMap.Remove(Device.DeviceName);

            cboDeviceID.SelectedIndex = 0;
        }


    }
}
