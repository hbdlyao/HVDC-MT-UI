using cn.csg.dpcp.common;
using Hvdc.MT.HvdcCommon;
using Hvdc.MT.mc.App;
using Hvdc.MT.mc.Def;
using Hvdc.MT.mc.Device;
using System;

namespace cn.csg.dpcp.ui.mc
{
    public partial class MCTransformerUI : MCBaseUI
    {
        public MCTransformerUI()
        {
            InitializeComponent();
            Name = Constants.MC_CTransformer;
        }
       
        protected override void RestUI()
        {
            base.RestUI();
            numAngleMax.ResetText();
            numAngleMin.ResetText();
            //numTapCtrlType.ResetText();
            numFixedURef.ResetText();
            numSN.ResetText();
            numTapMax.ResetText();
            numTapMin.ResetText();
            numUacN.ResetText();
            numUvMax.ResetText();
            numUkp.ResetText();
            numUrp.ResetText();
            numTapSetup.ResetText();
            numTapN.ResetText();
        }

        
        private void radFixedAngle_CheckedChanged(object sender, EventArgs e)
        {
            if (radFixedAngle.Checked)
            {
                numFixedURef.Enabled = false;
                numFixedURef.ResetText();

                numAngleMax.Enabled = true;
                numAngleMin.Enabled = true;
            }
        }

        private void radFixedUv_CheckedChanged(object sender, EventArgs e)
        {
            if (radFixedUv.Checked)
            {
                numAngleMax.Enabled = false;
                numAngleMax.ResetText();
                numAngleMin.Enabled = false;
                numAngleMin.ResetText();

                numFixedURef.Enabled = true;
            }
        }

        private void MCTransformer_Load(object sender, EventArgs e)
        {
            InitForm(CmcVars.pmcHvdcGrid, CHvdcDefs.mcGridType, CmcDef.mc_Xf2);
            FillComboxFromDevice(cboDeviceID);
        }

        protected override void DevToUI()
        {
            CmcDevXf2 vo = Device as CmcDevXf2;
            if (vo.TapCtrlType == 5)
            {
                radFixedAngle.Checked = true;
            }
            else if (vo.TapCtrlType == 2)
            {
                radFixedUv.Checked = true;
            }

            cboDeviceID.SelectedItem = vo.DeviceID;
            txtDeviceName.Text = vo.DeviceName;
            txtDeviceType.Text = vo.DeviceType + "";
            txtStationName.Text = vo.StationNames[0];
            numAngleMax.Value = (decimal)vo.AngleMax;
            numAngleMin.Value = (decimal)vo.AngleMin;
            //numTapCtrlType.Value = (decimal)vo.TapCtrlType;
            numFixedURef.Value = (decimal)vo.FixedURef;
            //numSN.Value = (decimal)vo.SN;
            numTapMax.Value = (decimal)vo.TapMax;
            numTapMin.Value = (decimal)vo.TapMin;
            numTapN.Value = (decimal)vo.TapN;
            numUacN.Value = (decimal)vo.UacN;
            numUvMax.Value = (decimal)vo.UvMax;
            numUkp.Value = (decimal)vo.Ukp;
            numUrp.Value = (decimal)vo.Urp;
            numTapSetup.Value = (decimal)vo.TapSetup;
        }

        protected override void uiToDev()
        {
            CmcDevXf2 vo = Device as CmcDevXf2;
            vo.DeviceName = txtDeviceName.Text;
            vo.DeviceType = int.Parse(txtDeviceType.Text);
            vo.StationNames[0] = txtStationName.Text;
            vo.AngleMax = (double)numAngleMax.Value;
            vo.AngleMin = (double)numAngleMin.Value;
            vo.FixedURef = (double)numFixedURef.Value;
            //vo.SN = (int)numSN.Value;
            //vo.TapMax = (double)numTapMax.Value;
            //vo.TapMin = (double)numTapMin.Value;
            //vo.TapN = (double)numTapN.Value;
            vo.UacN = (double)numUacN.Value;
            vo.UvMax = (double)numUvMax.Value;
            vo.Ukp = (double)numUkp.Value;
            vo.Urp = (double)numUrp.Value;
            vo.TapSetup = (double)numTapSetup.Value;
            vo.TapCtrlType = radFixedAngle.Checked ? 5 : 2;
        }
    }
}
