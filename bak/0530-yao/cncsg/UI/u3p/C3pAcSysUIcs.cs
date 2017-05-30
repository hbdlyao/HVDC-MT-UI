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
    public partial class C3pAcSysUIcs : DpcpBaseForm
    {
        public C3pAcSysUIcs()
        {
            InitializeComponent();
            Name = Constants.C3pAcSysUIcs;
        }

        /// <summary>
        /// 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void C3pHlbXhjDiffUI_Load(object sender, EventArgs e)
        {
            InitForm(C3pVars.pGrid, CHvdcDefs.u3pGridType, C3pDefs.U3p_AcSys);
            FillComboxFromDevice(cboStation);
        }

        /// <summary>
        /// 应用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApply_Click(object sender, EventArgs e)
        {
            OnApply();
        }

        private void rowToDevice(DataGridViewRow vRow)
        {
            string deviceName = vRow.Cells["device"].Value.ToString();
            C3pDevAcSys vDev = deviceMap[deviceName] as C3pDevAcSys;
            vDev.Rs = double.Parse(vRow.Cells["rs"].Value.ToString());
            vDev.Ls = double.Parse(vRow.Cells["ls"].Value.ToString());
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
            OnDeviceChanged(cboStation);
        }

        protected override void OnClear()
        {
            dgvDevice.Rows.Clear();
        }

        protected override void DevToUI()
        {
            dgvDevice.Rows.Clear();

            C3pDevAcSys vDev= Device as C3pDevAcSys;

            txtRs.Text = vDev.Rs.ToString();
            txtLs.Text = vDev.Ls.ToString();

            foreach (RecAcSysXb vData in vDev.pXb)
            {
                dgvDevice.Rows.Add(new object[] { vData.hOrder, vData.hUrms, vData.hAngle });
            }
            
        }

        protected override void uiToDev()
        {
            C3pDevAcSys vDev = Device as C3pDevAcSys;
            vDev.Rs = double.Parse(txtRs.Text);
            vDev.Ls = double.Parse(txtLs.Text);

            int vN = dgvDevice.Rows.Count-1;
            vDev.pXb = new RecAcSysXb[vN];

            vDev.hCount = vN;

            string vStr;
            for (int i = 0; i < vN ; i++)
            {
                vStr=dgvDevice.Rows[i].Cells["hOrder"].Value.ToString();
                vDev.pXb[i].hOrder = int.Parse(vStr);

                vStr = dgvDevice.Rows[i].Cells["hUrms"].Value.ToString();
                vDev.pXb[i].hUrms = double.Parse(vStr);

                vStr = dgvDevice.Rows[i].Cells["hAngle"].Value.ToString();
                vDev.pXb[i].hAngle = double.Parse(vStr);

            }

        }

    }
}