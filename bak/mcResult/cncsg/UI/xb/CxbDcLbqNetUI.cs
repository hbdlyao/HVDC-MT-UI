using cn.csg.dpcp.common;
using Hvdc.MT.HvdcCommon;
using Hvdc.MT.U3p.Def;
using Hvdc.MT.xb.App;
using Hvdc.MT.xb.Def;
using Hvdc.MT.xb.Device;
using Hvdc.MT.xb.DevTBL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Yao.BaseFrame.Device;
using Yao.BaseFrame.DevTBL;

namespace cn.csg.dpcp.ui.xb
{
    public partial class CxbDcLbqNetUI : DpcpBaseForm
    {
        // 监视设备map
        private IDictionary<string, CxbDevMonitor> monitorMap = new Dictionary<string, CxbDevMonitor>();
        
        // 直流滤波器F1map
        private IDictionary<string, CxbDevDCF> dcfMap = new Dictionary<string, CxbDevDCF>();

        public CxbDcLbqNetUI()
        {
            InitializeComponent();
            Name = Constants.CxbDcLbqNetUI;
        }

        private string getSelectedStationName()
        {
            if (cboStation.SelectedText == null || string.Empty.Equals(cboStation.SelectedText))
            {
                return cboStation.Text;
            }
            return cboStation.SelectedText;
        }

        /// <summary>
        /// 初始化加载站点
        /// </summary>
        private void initStations()
        {
            IDictionary<string, CDevStation> stationMap = CxbVars.pxbHvdcGrid.Stations();
            foreach (var item in stationMap)
            {
                cboStation.Items.Add(item.Key);
            }
        }

        /// <summary>
        /// 表格样式，增加首列序号
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewStyle(DataGridView dgv, object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y, dgv.RowHeadersWidth - 4, e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dgv.RowHeadersDefaultCellStyle.Font, rectangle, dgvDkq.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 界面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CxbDcLbqNetUI_Load(object sender, EventArgs e)
        {
            InitForm(CxbVars.pxbHvdcGrid, CHvdcDefs.xbGridType, C3pDefs.U3p_Xf2);
            FillComboxFromStation(cboStation);
        }

        protected override void OnLoadStation()
        {
            dkqOnLoad();
            xfcOnLoad();
            dcfOnLoad();
            coupleCOnLoad();
            pulseCOnLoad();
            groundOnLoad();
            monitorOnLoad();
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            CxbMvcs.OnSave(CxbDef.xb_PbDKQ);
            CxbMvcs.OnSave(CxbDef.xb_DCF);
            CxbMvcs.OnSave(CxbDef.xb_CoupleC);
            CxbMvcs.OnSave(CxbDef.xb_PulseC);
            CxbMvcs.OnSave(CxbDef.xb_XfC);
            CxbMvcs.OnSave(CxbDef.xb_Ground);
            CxbMvcs.OnSave(CxbDef.xb_Monitor);
        }

        /// <summary>
        /// 应用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApply_Click(object sender, EventArgs e)
        {
            OnApply();
            MessageBox.Show("应用成功");
        }

        protected override void uiToDev()
        {
            dkqApply();
            xfcApply();
            dcfApply();
            couple_C_Apply();
            pulse_C_Apply();
            groundApply();
            sysApply();
            monitorApply();
        }

        /// <summary>
        /// 站点下拉框变动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dkqOnLoad();
            //xfcOnLoad();
            //coupleCOnLoad();
            //pulseCOnLoad();
            //groundOnLoad();
            //dcfOnLoad();
            //monitorOnLoad();

            OnStationChanged(cboStation);
        }

        /// <summary>
        /// 平波电抗器表格样式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDkq_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewStyle(dgvDkq, sender, e);
            dataGridViewStyle(dgvXfc, sender, e);
            dataGridViewStyle(dgvCouple_C, sender, e);
            dataGridViewStyle(dgvPulseC, sender, e);
            dataGridViewStyle(dgvGround, sender, e);
            dataGridViewStyle(dgvMonitor, sender, e);
        }

        /// <summary>
        /// 杂散电容电容应用
        /// </summary>
        private void xfcApply()
        {
            CDevTBL tbl = CxbVars.pxbHvdcGrid.DevTBLfromStation(getSelectedStationName(), CxbDef.xb_XfC);
            List<CDevBase> list = tbl.Children();
            list.Clear();
            for (int i = 0; i < dgvXfc.Rows.Count; i++)
            {
                
            }
        }

        /// <summary>
        /// 平波电抗器点击应用
        /// </summary>
        private void dkqApply()
        {
            CDevTBL tbl = CxbVars.pxbHvdcGrid.DevTBLfromStation(getSelectedStationName(), CxbDef.xb_PbDKQ);
            List<CDevBase> list = tbl.Children();
            list.Clear();
            for (int i = 0; i < dgvDkq.Rows.Count; i++)
            {
                CxbDevPbDkq vo = CxbDevTBL.xbNewDevice(CxbDef.xb_PbDKQ) as CxbDevPbDkq;
                vo.StationNames[0] = dgvDkq.Rows[i].Cells["station"].Value.ToString();
                vo.DeviceName = dgvDkq.Rows[i].Cells["device"].Value.ToString();

                object posOrNeg = dgvDkq.Rows[i].Cells["posOrNeg"].Value;
                if (!validatePosONeg(posOrNeg))
                {
                    MessageBox.Show("[平波电抗器]第[" + (i + 1) + "]行第[3]列必须是0或1的整数");
                    return;
                }
                vo.PosOrNeg = int.Parse(posOrNeg.ToString());

                object zc = dgvDkq.Rows[i].Cells["Z_C"].Value;
                if (zc == null)
                {
                    MessageBox.Show("请输入[平波电抗器]第[" + (i + 1) + "]行第[4]列");
                    return;
                }
                vo.Z_C = double.Parse(zc.ToString());
                list.Add(vo);
            }
        }

        /// <summary>
        ///  直流滤波器应用
        /// </summary>
        private void dcfApply()
        {
            CDevTBL tbl = CxbVars.pxbHvdcGrid.DevTBLfromStation(getSelectedStationName(), CxbDef.xb_DCF);
            List<CDevBase> list = tbl.Children();
        }

        /// <summary>
        /// 中性线接地极电容
        /// </summary>
        private void couple_C_Apply()
        {
            CDevTBL tbl = CxbVars.pxbHvdcGrid.DevTBLfromStation(getSelectedStationName(), CxbDef.xb_CoupleC);
            List<CDevBase> list = tbl.Children();
            list.Clear();
            for (int i = 0; i < dgvCouple_C.Rows.Count; i++)
            {
                CxbDevCouple_C vo = CxbDevTBL.xbNewDevice(CxbDef.xb_CoupleC) as CxbDevCouple_C;
                vo.StationNames[0] = dgvCouple_C.Rows[i].Cells["couple_Cstation"].Value.ToString();
                vo.DeviceName = dgvCouple_C.Rows[i].Cells["couple_CDevice"].Value.ToString();

                object posOrNeg = dgvCouple_C.Rows[i].Cells["couPle_CPosOrNeg"].Value;
                if (!validatePosONeg(posOrNeg))
                {
                    MessageBox.Show("[中性线接地极电容]第[" + (i + 1) + "]行第[3]列必须是0或1的整数");
                    return;
                }
                vo.PosOrNeg = int.Parse(posOrNeg.ToString());

                object zc = dgvCouple_C.Rows[i].Cells["couPle_C_ZC"].Value;
                if (zc == null)
                {
                    MessageBox.Show("请输入[中性线接地极电容]第[" + (i + 1) + "]行第[4]列");
                    return;
                }
                vo.Z_C = double.Parse(zc.ToString());
                list.Add(vo);
            }
        }

        /// <summary>
        /// 极对地电容
        /// </summary>
        private void pulse_C_Apply()
        {
            CDevTBL tbl = CxbVars.pxbHvdcGrid.DevTBLfromStation(getSelectedStationName(), CxbDef.xb_PulseC);
            List<CDevBase> list = tbl.Children();
            list.Clear();
            for (int i = 0; i < dgvPulseC.Rows.Count; i++)
            {
                CxbDevPulse_C vo = CxbDevTBL.xbNewDevice(CxbDef.xb_PulseC) as CxbDevPulse_C;
                vo.StationNames[0] = dgvPulseC.Rows[i].Cells["pluseCStation"].Value.ToString();
                vo.DeviceName = dgvPulseC.Rows[i].Cells["pluseCDevice"].Value.ToString();

                object posOrNeg = dgvPulseC.Rows[i].Cells["pulseCPosOrNeg"].Value;
                if (!validatePosONeg(posOrNeg))
                {
                    MessageBox.Show("[极对地电容]第[" + (i + 1) + "]行第[3]列必须是0或1的整数");
                    return;
                }
                vo.PosOrNeg = int.Parse(posOrNeg.ToString());

                object zc = dgvPulseC.Rows[i].Cells["pluseC_ZC"].Value;
                if (zc == null)
                {
                    MessageBox.Show("请输入[极对地电容]第[" + (i + 1) + "]行第[4]列必须是0或1的整数");
                    return;
                }
                vo.Z_C = double.Parse(zc.ToString());
                list.Add(vo);
            }
        }

        /// <summary>
        /// 接地极电阻
        /// </summary>
        private void groundApply()
        {
            CDevTBL tbl = CxbVars.pxbHvdcGrid.DevTBLfromStation(getSelectedStationName(), CxbDef.xb_Ground);
            List<CDevBase> list = tbl.Children();
            list.Clear();
            for (int i = 0; i < dgvGround.Rows.Count; i++)
            {
                CxbDevGround vo = CxbDevTBL.xbNewDevice(CxbDef.xb_Ground) as CxbDevGround;
                vo.StationNames[0] = dgvGround.Rows[i].Cells["groundStation"].Value.ToString();
                vo.DeviceName = dgvGround.Rows[i].Cells["groundDevice"].Value.ToString();

                object posOrNeg = dgvGround.Rows[i].Cells["groundPosOrNeg"].Value;
                if (!validatePosONeg(posOrNeg))
                {
                    MessageBox.Show("[接地极电阻]第[" + (i + 1) + "]行第[3]列必须是0或1的整数");
                    return;
                }
                vo.PosOrNeg = int.Parse(posOrNeg.ToString());

                object zr = dgvGround.Rows[i].Cells["groundZr"].Value;
                if (zr == null)
                {
                    MessageBox.Show("请输入[接地极电阻]第[" + (i + 1) + "]行第[4]列");
                    return;
                }
                vo.Zr = double.Parse(zr.ToString());
                list.Add(vo);
            }
        }

        /// <summary>
        /// 系统频率应用
        /// </summary>
        private void sysApply()
        {
            
        }

        /// <summary>
        /// 监视装置应用
        /// </summary>
        private void monitorApply()
        {
            CDevTBL tbl = CxbVars.pxbHvdcGrid.DevTBLfromStation(getSelectedStationName(), CxbDef.xb_Monitor);
            List<CDevBase> monitorList = tbl.Children();
            List<CxbDevBranch> branchList = new List<CxbDevBranch>();

            string parentDevice = null; // 列表中监视设备名称
            for (int i = 0; i < dgvMonitor.Rows.Count; i++)
            {
                parentDevice = dgvMonitor.Rows[i].Cells["parentDevice"].Value.ToString();
                CxbDevBranch vo = CxbDevTBL.xbNewDevice(CxbDef.xb_Branch) as CxbDevBranch;
                vo.StationNames[0] = dgvMonitor.Rows[i].Cells["monitorStation"].Value.ToString();
                vo.DeviceName = dgvMonitor.Rows[i].Cells["monitorDevice"].Value.ToString();

                object posOrNeg = dgvMonitor.Rows[i].Cells["monitorPosOrNeg"].Value;
                if (!validatePosONeg(posOrNeg))
                {
                    MessageBox.Show("[接地极监视装置电阻]第[" + (i + 1) + "]行第[3]列必须是0或1的整数");
                    return;
                }
                vo.PosOrNeg = int.Parse(posOrNeg.ToString());

                object zr = dgvMonitor.Rows[i].Cells["monitorZr"].Value;
                if (zr == null)
                {
                    MessageBox.Show("请输入[接地极监视装置电阻]第[" + (i + 1) + "]行第[4]列");
                    return;
                }
                vo.Zr = double.Parse(zr.ToString());

                object zl = dgvMonitor.Rows[i].Cells["monitorZl"].Value;
                if (zl == null)
                {
                    MessageBox.Show("请输入[接地极监视装置电感]第[" + (i + 1) + "]行第[5]列");
                    return;
                }
                vo.Z_L = double.Parse(zl.ToString());

                object zc = dgvMonitor.Rows[i].Cells["monitorZc"].Value;
                if (zc == null)
                {
                    MessageBox.Show("请输入[接地极监视装置电容]第[" + (i + 1) + "]行第[6]列");
                    return;
                }
                vo.Z_C = double.Parse(zc.ToString());

                branchList.Add(vo);
            }

            // 找到下拉框选中的monitor，更新它的branch集合
            CxbDevMonitor updateMonitor = null; 
            foreach (CxbDevMonitor monitor in monitorList)
            {
                if (monitor.DeviceName.Equals(parentDevice))
                {
                    updateMonitor = monitor;
                }
            }
            if (updateMonitor != null)
            {
                updateMonitor.Children().Clear();
                monitorMap[parentDevice].Children().Clear();
                foreach (CxbDevBranch branch in branchList)
                {
                    updateMonitor.Children().Add(branch);
                    monitorMap[parentDevice].Children().Add(branch);
                }
            }

        }

        /// <summary>
        /// 换流器杂散电容值加载
        /// </summary>
        private void xfcOnLoad()
        {
            dgvXfc.Rows.Clear();
            CDevTBL tbl = CxbVars.pxbHvdcGrid.DevTBLfromStation(getSelectedStationName(), CxbDef.xb_XfC);
            List<CDevBase> list = tbl.Children();
            foreach (CDevBase vo in list)
            {
                CxbDevXf_C xfc = vo as CxbDevXf_C;
                dgvXfc.Rows.Add(new object[] { xfc.StationNames[0], xfc.DeviceName, xfc.PosOrNeg, xfc.Z_C });
            }
        }

        /// <summary>
        /// 平波电抗器加载
        /// </summary>
        private void dkqOnLoad()
        {
            dgvDkq.Rows.Clear();
            CDevTBL tbl = CxbVars.pxbHvdcGrid.DevTBLfromStation(getSelectedStationName(), CxbDef.xb_PbDKQ);
            List<CDevBase> list = tbl.Children();
            foreach (CDevBase vo in list)
            {
                CxbDevPbDkq dkq = vo as CxbDevPbDkq;
                dgvDkq.Rows.Add(new object[] { dkq.StationNames[0], dkq.DeviceName, dkq.PosOrNeg, dkq.Z_C });
            }
        }

        /// <summary>
        /// 直流滤波器加载
        /// </summary>
        private void dcfOnLoad()
        {
            lstF1.Items.Clear();
            //CDevTBL tbl = CxbVars.pxbHvdcGrid.DevTBLfromStation(getSelectedStationName(), CxbDef.xb_DCF);

            CDevTBL tbl = DevStation.DeviceTBL(CxbDef.xb_DCF);

            List <CDevBase> list = tbl.Children();
            //list.Clear();
            foreach (CDevBase vo in list)
            {
                CxbDevDCF dcf = vo as CxbDevDCF;
                lstF1.Items.Add(dcf.DeviceName);
                //lstF2.Items.Add(dcf.DeviceName);
                dcfMap.Add(dcf.DeviceName, dcf);
                //dcfF2Map.Add(dcf.DeviceName, dcf);
            }
        }

        /// <summary>
        /// 中性线接地极电容加载
        /// </summary>
        private void coupleCOnLoad()
        {
            dgvCouple_C.Rows.Clear();
            CDevTBL tbl = CxbVars.pxbHvdcGrid.DevTBLfromStation(getSelectedStationName(), CxbDef.xb_CoupleC);
            List<CDevBase> list = tbl.Children();
            foreach (CDevBase vo in list)
            {
                CxbDevCouple_C c = vo as CxbDevCouple_C;
                dgvCouple_C.Rows.Add(new object[] { c.StationNames[0], c.DeviceName, c.PosOrNeg, c.Z_C });
            }
        }

        /// <summary>
        /// 极对地电容加载
        /// </summary>
        private void pulseCOnLoad()
        {
            dgvPulseC.Rows.Clear();
            CDevTBL tbl = CxbVars.pxbHvdcGrid.DevTBLfromStation(getSelectedStationName(), CxbDef.xb_PulseC);
            List<CDevBase> list = tbl.Children();
            foreach (CDevBase vo in list)
            {
                CxbDevPulse_C c = vo as CxbDevPulse_C;
                dgvPulseC.Rows.Add(new object[] { c.StationNames[0], c.DeviceName, c.PosOrNeg, c.Z_C });
            }
        }

        /// <summary>
        /// 极对地电容加载
        /// </summary>
        private void groundOnLoad()
        {
            dgvGround.Rows.Clear();
            CDevTBL tbl = CxbVars.pxbHvdcGrid.DevTBLfromStation(getSelectedStationName(), CxbDef.xb_Ground);
            List<CDevBase> list = tbl.Children();
            foreach (CDevBase vo in list)
            {
                CxbDevGround c = vo as CxbDevGround;
                dgvGround.Rows.Add(new object[] { c.StationNames[0], c.DeviceName, c.PosOrNeg, c.Zr });
            }
        }

        private void sysOnLoad()
        {
            chkIsInput.Checked = false;
            txtSys.Text.Remove(0);
        }

        /// <summary>
        /// 接地极监视装饰加载
        /// </summary>
        private void monitorOnLoad()
        {
            monitorMap.Clear();
            lstMonitor.Items.Clear();
            dgvMonitor.Rows.Clear();
            CDevTBL tbl = CxbVars.pxbHvdcGrid.DevTBLfromStation(getSelectedStationName(), CxbDef.xb_Monitor);
            List<CDevBase> list = tbl.Children();
            foreach (CDevBase vo in list)
            {
                lstMonitor.Items.Add(vo.DeviceName);
                monitorMap.Add(vo.DeviceName, vo as CxbDevMonitor);
            }
            if (lstMonitor.Items.Count > 0)
            {
                lstMonitor.SelectedIndex = 0;
            }

        }

        /// <summary>
        /// 验证正负极是否为0或1
        /// </summary>
        /// <param name="posOrNeg"></param>
        /// <returns></returns>
        private bool validatePosONeg(object posOrNeg)
        {
            if (posOrNeg == null || (int.Parse(posOrNeg.ToString()) != 1 && int.Parse(posOrNeg.ToString()) != 0))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 监视设备列表切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstMonitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvMonitor.Rows.Clear();
            string deviceName = lstMonitor.SelectedItem.ToString();
            CxbDevMonitor monitor = monitorMap[deviceName];
            List<CDevBase> voList = monitor.Children();
            foreach (CDevBase basevo in voList) {
                CxbDevBranch vo = basevo as CxbDevBranch;
                dgvMonitor.Rows.Add(new object[] { vo.StationNames[0], vo.DeviceName, vo.PosOrNeg, vo.Zr, vo.Z_L, vo.Z_C, monitor.DeviceName });
            }
        }

        // 直流滤波器选择
        private void lstF1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDCF.Rows.Clear();
            string deviceName = lstF1.SelectedItem.ToString();
            CxbDevDCF dcf = dcfMap[deviceName];
            List<CDevBase> voList = dcf.Children();
            foreach (CxbDevDCF_RLC rlc in voList)
            {
                dgvDCF.Rows.Add(new object[] {
                    rlc.DeviceName, rlc.PosOrNeg, rlc.MaxFreqDelta, rlc.MinFreqDelta, rlc.Zr, rlc.MaxRDelta, rlc.MinRDelta
                    , rlc.Zr, rlc.MaxRDelta, rlc.MinRDelta, rlc.Z_C, rlc.MaxCDelta, rlc.MinCDelta});
            }
            
            dgvDCF.ScrollBars = ScrollBars.Both;
            dgvDCF.Refresh();
        }
    }
}
