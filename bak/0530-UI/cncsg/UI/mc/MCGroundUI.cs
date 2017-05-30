using cn.csg.dpcp.common;
using Hvdc.MT.HvdcCommon;
using Hvdc.MT.mc.App;
using Hvdc.MT.mc.Def;
using Hvdc.MT.mc.Device;
using System;

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
            numZr.Value = (decimal)vo.Zr;
        }

        protected override void uiToDev()
        {
            CmcDevGround vo = Device as CmcDevGround;
            vo.Zr = (double)numZr.Value;
        }

    }
}
