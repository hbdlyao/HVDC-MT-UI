using cn.csg.dpcp.common;
using Hvdc.MT.HvdcCommon;
using Hvdc.MT.mc.App;
using Hvdc.MT.mc.Def;
using Hvdc.MT.mc.Device;
using System;

using cn.csg.dpcp.ui.mc;

namespace cn.csg.dpcp.ui.mc
{
    public partial class CmcUIAcFileter : CmcUIBase
    {
        public CmcUIAcFileter()
        {
            InitializeComponent();
            Name = Constants.MC_CAcFilter;
        }

        /// <summary>
        /// 界面数据重置
        /// </summary>
        protected override void RestUI()
        {
            base.RestUI();
            numAcfType.ResetText();
            numQacf.ResetText();
            numQacfN.ResetText();
            numZc.ResetText();
            numZr.ResetText();
            numZx.ResetText();
            numUac.ResetText();
            numUacN.ResetText();

        }


        private void MCAcFilterUI_Load(object sender, EventArgs e)
        {
            InitForm(CmcVars.pmcHvdcGrid, CHvdcDefs.mcGridType, CmcDef.mc_AcF);
            FillComboxFromDevice(cboDeviceID);
        }

        protected override void DevToUI()
        {
            CmcDevAcFilter vo = Device as CmcDevAcFilter;
            cboDeviceID.SelectedItem = vo.DeviceID;
            //numPacN.Value = (decimal)vo.PacN;
            //numQacN.Value = (decimal)vo.QacN;
            numUacN.Value = (decimal)vo.UacN;
            numQacfN.Value = (decimal)vo.QacfN;
            numZr.Value = (decimal)vo.Zr;
            //numQinMax.Value = (decimal)vo.QinMax;
            //numQoutMax.Value = (decimal)vo.QoutMax;
            //numUacExMin.Value = (decimal)vo.UacExMin;
            //numUacMax.Value = (decimal)vo.UacMax;
            //numUacMin.Value = (decimal)vo.UacMin;
        }

        protected override void uiToDev()
        {
            CmcDevAcFilter vo = Device as CmcDevAcFilter;
            //vo.AcfType = (int)numAcfType.Value;
            //vo.Qacf = (double)numQacf.Value;
            vo.QacfN = (double)numQacfN.Value;
            //vo.Zc = (double)numZc.Value;
            vo.Zr = (double)numZr.Value;
            //vo.Zx = (double)numZx.Value;
            //vo.Uac = (double)numUac.Value;
            vo.UacN = (double)numUacN.Value;
        }
    }
}
