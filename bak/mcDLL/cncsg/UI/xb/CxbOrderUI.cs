using cn.csg.dpcp.common;
using Hvdc.MT.HvdcCommon;
using Hvdc.MT.mc.App;
using Hvdc.MT.xb.App;
using Hvdc.MT.xb.Solve;
using System;
using System.Windows.Forms;

namespace cn.csg.dpcp.ui.xb
{
    public partial class CxbOrderUI : DpcpBaseForm
    {
        protected CxbOrder pOrder;

        public CxbOrderUI()
        {
            InitializeComponent();
            Name = Constants.XB_OrderUI;
        }

        private void CxbOrderUI_Load(object sender, EventArgs e)
        {
            intNumControlButton(this);

            pOrder = CxbVars.pxbOrder;

            RestUI();
            DevToUI();

            //CaseToUI();

        }

        protected void RestUI()
        {
            chkBAcUdNE.Checked = false;
            chkDcHZr.Checked = false;
            chkRdL.Checked = false;
            chkUd70.Checked = false;
            chkUd80.Checked = false;
            chkUdAll.Checked = false;
            chkDRun.Checked = false;
            chkUacMin.Checked = false;
            chkUacExtMin.Checked = false;
            chkUacMax.Checked = false;
            chkUacN.Checked = false;
            chkSGround.Checked = false;
            chkSMetal.Checked = false;
            numUd.ResetText();
            numPd.ResetText();
            numId.ResetText();
            numPdSize.ResetText();
            numPdStart.ResetText();
            numPdIncre.ResetText();
        }
        // 隐藏上下箭头按钮
        private void intNumControlButton(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c.Controls.Count > 0)
                {
                    intNumControlButton(c);
                }
                if (c is NumericUpDown)
                {
                    (c as NumericUpDown).Controls[0].Visible = false;
                }
            }
        }

        protected void CaseToUI()
        {
            CxbMvcs.LoadResultFromMcResult(CmcParams.dbfFile);

            //
            int vN = 0;
            lstCase_mcResult.Items.Clear();
            foreach (RecResultData vData in pOrder.mcData)
            {
                string vStr = vData.CaseID + "--" + vData.PdPer.ToString();
                lstCase_mcResult.Items.Add(vStr);

                vN = vN + 1;
            }
           


        }

        protected override void DevToUI()
        {
            chkUacMax.Checked = "1".Equals(pOrder.Flag_Uac.Substring(0, 1));
            // 额定
            chkUacN.Checked = "1".Equals(pOrder.Flag_Uac.Substring(1, 1));
            // 较低
            chkUacMin.Checked = "1".Equals(pOrder.Flag_Uac.Substring(2, 1));
            // 极低
            chkUacExtMin.Checked = "1".Equals(pOrder.Flag_Uac.Substring(3, 1));

            //  直流电压
            // 全压
            chkUdAll.Checked = "1".Equals(pOrder.Flag_Ud.Substring(0, 1));
            // 80%
            chkUd80.Checked = "1".Equals(pOrder.Flag_Ud.Substring(1, 1));
            // 70% 
            chkUd70.Checked = "1".Equals(pOrder.Flag_Ud.Substring(2, 1));

            // 直流线路电阻
            // 高阻
            chkDcHZr.Checked = "1".Equals(pOrder.Flag_Rd.Substring(0, 1));
            // 低阻
            chkRdL.Checked = "1".Equals(pOrder.Flag_Rd.Substring(1, 1));
            // 额定
            chkRdN.Checked = "1".Equals(pOrder.Flag_Rd.Substring(2, 1));

            // 运行模式
            // 单级金属
            chkSGround.Checked = "1".Equals(pOrder.Flag_Ground.Substring(0, 1));
            // 单级大地
            chkSMetal.Checked = "1".Equals(pOrder.Flag_Ground.Substring(1, 1));
            // 双极运行
            chkDRun.Checked = "1".Equals(pOrder.Flag_Ground.Substring(2, 1));

            // 12脉动中间是否接地
            chk12Count.Checked = pOrder.Is6Pulse == 1;

            /// 是否交叉
            chkIsUacSwap.Checked = pOrder.IsUacSwap == 1;

            // 是否单负荷
            if (pOrder.IsLoadSingle == 1)
            {
                radLoadSingle.Checked = true;
            }
            else
            {
                radLoadBatch.Checked = true;
            }

            // 计算方式
            if (pOrder.CalcType == 1)
            {
                radDz.Checked = true;
            }
            else
            {
                radXn.Checked = true;
            }

            // 单回结果方式
            if (pOrder.SingleReusltType == 1)
            {
                radM2M.Checked = true;
            }
            else
            {
                radM2S.Checked = true;
            }
            // 加权方式
            if (pOrder.Plus == 1)
            {
                radCplus.Checked = true;
            }
            else if (pOrder.Plus == 0)
            {
                radPplus.Checked = true;
            }
            else
            {
                radNOplus.Checked = true;
            }

            num12Count.Value = pOrder.nValNum;
            numUd.Value = (decimal)pOrder.UdSingle;
            numPd.Value = (decimal)pOrder.PdSingle;
            //numId.Value = (decimal)pOrder.DcId;
            numPdStart.Value = (decimal)pOrder.PdStartPer;
            numPdIncre.Value = (decimal)pOrder.PdIncrePer;
            numPdSize.Value = (decimal)pOrder.PdSize;
        }

        protected override void uiToDev()
        {
            // 交流电压
            pOrder.Flag_Uac = "";
            // 最大
            pOrder.Flag_Uac += chkUacMax.Checked ? "1" : "0";
            // 额定
            pOrder.Flag_Uac += chkUacN.Checked ? "1" : "0";
            // 较低
            pOrder.Flag_Uac += chkUacMin.Checked ? "1" : "0";
            // 极低
            pOrder.Flag_Uac += chkUacExtMin.Checked ? "1" : "0";

            //  直流电压
            pOrder.Flag_Ud = "";
            // 全压
            pOrder.Flag_Ud += chkUdAll.Checked ? "1" : "0";
            // 80%
            pOrder.Flag_Ud += chkUd80.Checked ? "1" : "0";
            // 70% 
            pOrder.Flag_Ud += chkUd70.Checked ? "1" : "0"; ;

            // 直流线路电阻
            pOrder.Flag_Rd = "";
            // 高阻
            pOrder.Flag_Rd += chkDcHZr.Checked ? "1" : "0";
            // 低阻
            pOrder.Flag_Rd += chkRdL.Checked ? "1" : "0";
            // 额定
            pOrder.Flag_Rd += chkRdN.Checked ? "1" : "0";

            // 运行模式
            pOrder.Flag_Ground = "";
            // 单级金属
            pOrder.Flag_Ground += chkSGround.Checked ? "1" : "0";
            // 单级大地
            pOrder.Flag_Ground += chkSMetal.Checked ? "1" : "0";
            // 双极运行
            pOrder.Flag_Ground += chkDRun.Checked ? "1" : "0";

            // 12脉动中间是否接地
            pOrder.Is6Pulse = chk12Count.Checked ? 1 : 0;

            // 是否交叉
            pOrder.IsUacSwap = chkIsUacSwap.Checked ? 1 : 0;

            // 是否单负荷
            pOrder.IsLoadSingle = radLoadSingle.Checked ? 1 : 0;

            // 加权方式
            pOrder.Plus = radNOplus.Checked ? 2 : radCplus.Checked ? 1 : 0;

            // 单回结果方式
            pOrder.SingleReusltType = radM2M.Checked ? 1 : 0;

            // 计算方式
            pOrder.CalcType = radDz.Checked ? 1 : 0;

            pOrder.IsLoadSingle = radLoadSingle.Checked ? 0 : 1;
            pOrder.nValNum = (int)num12Count.Value;
            pOrder.UdSingle = (double)numUd.Value;
            pOrder.PdSingle = (double)numPd.Value;
            //pOrder.DcId = (double)numId.Value;
            pOrder.PdStartPer = (double)numPdStart.Value;
            pOrder.PdIncrePer = (double)numPdIncre.Value;
            pOrder.PdSize = (int)numPdSize.Value;
        }

        private void configCheckBox(int choose, CheckBox box)
        {
            box.Checked = choose != 0;
        }

        private int getCheckBoxValue(CheckBox box)
        {
            return box.Checked ? 1 : 0;
        }

        // 勾选“是否不平衡”时“直流电压水平计算选择”内的全部勾选
        private void chkBAcUdNE_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBAcUdNE.Checked)
            {
                chkUdAll.Checked = true;
                chkUd80.Checked = true;
                chkUd70.Checked = true;
            }
        }

        private void radLoadSingle_CheckedChanged(object sender, EventArgs e)
        {
            numPdStart.ResetText();
            numPdIncre.ResetText();
            numPdSize.ResetText();
            numPdStart.Enabled = false;
            numPdIncre.Enabled = false;
            numPdSize.Enabled = false;
            numUd.Enabled = true;
            numPd.Enabled = true;
            numId.Enabled = true;
        }

        private void radLoadBatch_CheckedChanged(object sender, EventArgs e)
        {
            numUd.ResetText();
            numPd.ResetText();
            numId.ResetText();
            numPdStart.Enabled = true;
            numPdIncre.Enabled = true;
            numPdSize.Enabled = true;
            numUd.Enabled = false;
            numPd.Enabled = false;
            numId.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OnApply();

            CxbMvcs.xbOnSaveOrder();
        }

       
    }
}