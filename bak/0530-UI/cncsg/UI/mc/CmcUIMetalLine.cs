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

        /// <summary>
        /// 直流线路
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddLine_Click(object sender, EventArgs e)
        {
            CDlgNewDCLine vLine = new CDlgNewDCLine();
            vLine.ShowDialog();
            if (vLine.Result == 1)
            {
                // 新增成功
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }
    }
}
