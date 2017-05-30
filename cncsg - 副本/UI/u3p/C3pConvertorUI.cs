using cn.csg.dpcp.common;
using Hvdc.MT.HvdcCommon;
using Hvdc.MT.U3p.App;
using Hvdc.MT.U3p.Def;
using Hvdc.MT.U3p.Device;
using Hvdc.MT.xb.App;
using System;

using System.Windows.Forms;


namespace cn.csg.dpcp.ui.u3p
{
    /// <summary>
    /// 换流变熄弧角偏差
    /// </summary>
    public partial class C3pConvertorUI : CfmBaseFrom
    {
        public C3pConvertorUI()
        {
            InitializeComponent();
            Name = Constants.C3pConvertorUI;
        }

        /// <summary>
        /// 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void C3pHlbXhjDiffUI_Load(object sender, EventArgs e)
        {
            InitForm(C3pVars.pGrid, CHvdcDefs.u3pGridType, C3pDefs.U3p_Convertor);
            FillComboxFromStation(cboStation);
        }

        /// <summary>
        /// 应用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApply_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow vRow in dgvDevice.Rows)
            {
                rowToDevice(vRow);
            }
        }

        private void rowToDevice(DataGridViewRow vRow)
        {
            string deviceName = vRow.Cells["device"].Value.ToString();
            C3pDevConvertor vDev = deviceMap[deviceName] as C3pDevConvertor;
            vDev.dAngle[0] = double.Parse(vRow.Cells["value1"].Value.ToString());
            vDev.dAngle[1] = double.Parse(vRow.Cells["value2"].Value.ToString());
            vDev.dAngle[2] = double.Parse(vRow.Cells["value3"].Value.ToString());
            vDev.dAngle[3] = double.Parse(vRow.Cells["value4"].Value.ToString());
            vDev.dAngle[4] = double.Parse(vRow.Cells["value5"].Value.ToString());
            vDev.dAngle[5] = double.Parse(vRow.Cells["value6"].Value.ToString());
            vDev.dAngle[6] = double.Parse(vRow.Cells["autoDiff"].Value.ToString());
            vDev.dAngle[7] = double.Parse(vRow.Cells["diff"].Value.ToString());
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            OnSave();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnStationChanged(cboStation);
        }

        protected override void OnClear()
        {
            dgvDevice.Rows.Clear();
        }

        protected override void OnLoadStation()
        {
            AddToDevMap();
            foreach (C3pDevConvertor dev in DevTbl.Children())
            {
                dgvDevice.Rows.Add(new object[] { dev.DeviceName, dev.PosOrNeg,
                    dev.dAngle[0], dev.dAngle[1], dev.dAngle[2],  dev.dAngle[3], dev.dAngle[4], dev.dAngle[5], dev.Std_Angle, dev.Dis_dAngle });
                
            }

        }
    }
}
