using cn.csg.dpcp.common;
using Hvdc.MT.HvdcCommon;
using Hvdc.MT.mc.App;
using Hvdc.MT.mc.Def;
using Hvdc.MT.mc.Device;
using System;

namespace cn.csg.dpcp.ui.mc
{
    /// <summary>
    /// 主回路交流系统
    /// </summary>
    public partial class CmcUIAcSystem : CmcUIBase
    {
        public CmcUIAcSystem()
        {
            InitializeComponent();
            Name = Constants.MC_CAcSystem;
        }

        /// <summary>
        /// 界面数据重置
        /// </summary>
        protected override void RestUI()
        {
            base.RestUI();
            numPacN.ResetText();
            numQacN.ResetText();
            numUacN.ResetText();
            numQinMax.ResetText();
            numQoutMax.ResetText();
            numUacExMin.ResetText();
            numUacMax.ResetText();
            numUacMin.ResetText();
        }

        private void MCCAcSystemUI_Load(object sender, EventArgs e)
        {
            InitForm(CmcVars.pmcHvdcGrid, CHvdcDefs.mcGridType, CmcDef.mc_AcSys);
            FillComboxFromDevice(cboDeviceID);
        }

        protected override void DevToUI()
        {
            CmcDevAcSys vo = Device as CmcDevAcSys;

            cboDeviceID.SelectedItem = vo.DeviceID;
            //numPacN.Value = (decimal)vo.PacN;
            //numQacN.Value = (decimal)vo.QacN;
            numUacN.Value = (decimal)vo.UacN;
            numQinMax.Value = (decimal)vo.QinMax;
            numQoutMax.Value = (decimal)vo.QoutMax;
            numUacExMin.Value = (decimal)vo.UacExMin;
            numUacMax.Value = (decimal)vo.UacMax;
            numUacMin.Value = (decimal)vo.UacMin;
        }

        protected override void uiToDev()
        {
            CmcDevAcSys vo = Device as CmcDevAcSys;
            //vo.PacN = (double)numPacN.Value;
            //vo.QacN = (double)numQacN.Value;
            vo.UacN = (double)numUacN.Value;
            vo.QinMax = (double)numQinMax.Value;
            vo.QoutMax = (double)numQoutMax.Value;
            vo.UacExMin = (double)numUacExMin.Value;
            vo.UacMax = (double)numUacMax.Value;
            vo.UacMin = (double)numUacMin.Value;
        }

    }
}
