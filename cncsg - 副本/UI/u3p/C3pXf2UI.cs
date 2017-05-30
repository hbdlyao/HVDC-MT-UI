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
    /// 换流变换相电抗偏差s
    /// </summary>
    public partial class C3pXf2UI : CfmBaseFrom
    {
        public C3pXf2UI()
        {
            InitializeComponent();
            Name = Constants.C3pXf2UI;
        }

        /// <summary>
        /// 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void C3pHlbDxDiffUI_Load(object sender, EventArgs e)
        {
            InitForm(C3pVars.pGrid, CHvdcDefs.u3pGridType, C3pDefs.U3p_Xf2);
            FillComboxFromStation(cboStation);
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
        /// 应用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApply_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow vRow in dgvDevice.Rows)
            {
                RowToDevice(vRow);
            }
        }

        private void RowToDevice(DataGridViewRow vRow )
        {
            string deviceName = vRow.Cells["device"].Value.ToString();
            C3pDevXf2 vDev = deviceMap[deviceName] as C3pDevXf2;
            vDev.dLtA = double.Parse(vRow.Cells["aValue"].Value.ToString());
            vDev.dLtB = double.Parse(vRow.Cells["bValue"].Value.ToString());
            vDev.dLtC = double.Parse(vRow.Cells["cValue"].Value.ToString());
            vDev.Dis_dLt = double.Parse(vRow.Cells["autoDiff"].Value.ToString());
            vDev.Std_Lt = double.Parse(vRow.Cells["diff"].Value.ToString());
        }

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
            foreach (C3pDevXf2 dev in DevTbl.Children())
            {
                dgvDevice.Rows.Add(new object[] { dev.DeviceName, dev.PosOrNeg, dev.dLtA, dev.dLtB, dev.dLtC,dev.Dis_dLt, dev.Std_Lt });
            }

        }
    }
}
