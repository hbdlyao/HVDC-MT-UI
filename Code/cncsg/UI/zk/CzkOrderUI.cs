using cn.csg.dpcp.common;
using Hvdc.MT.xb.App;
using Hvdc.MT.xb.Solve;
using System;
using System.Windows.Forms;

namespace cn.csg.dpcp.ui.zk
{
    public partial class CzkOrderUI : CfmBaseFrom
    {
        protected CzkOrder pzkOrder;

        public CzkOrderUI()
        {
            InitializeComponent();
            Name = Constants.CzkOrderUI;
        }

        private void CzkOrderUI_Load(object sender, EventArgs e)
        {
            intNumControlButton(this);

            pzkOrder =  CxbVars.pzkOrder;

            RestUI();
            DevToUI();
        }

        protected void RestUI()
        {
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

        protected override void DevToUI()
        {
            num12Count.Value = pzkOrder.nValNum;

            // 直流线路电阻
            // 高阻
            chkDcHZr.Checked = "1".Equals(pzkOrder.Flag_Rd.Substring(0, 1));
            // 低阻
            chkRdL.Checked = "1".Equals(pzkOrder.Flag_Rd.Substring(1, 1));
            // 额定
            chkRdN.Checked = "1".Equals(pzkOrder.Flag_Rd.Substring(2, 1));

            // 运行模式
            // 单级金属
            chkSGround.Checked = "1".Equals(pzkOrder.Flag_Ground.Substring(0, 1));
            // 单级大地
            chkSMetal.Checked = "1".Equals(pzkOrder.Flag_Ground.Substring(1, 1));
            // 双极运行
            chkDRun.Checked = "1".Equals(pzkOrder.Flag_Ground.Substring(2, 1));

            // 12脉动中间是否接地
            chk12Count.Checked = pzkOrder.Is6Pulse == 1;

            numFreqStat.Value = (decimal) pzkOrder.FreqStart;
            numFreqDim.Value = (int)pzkOrder.FreqDim;
            numFreqStep.Value = (decimal)pzkOrder.FreqStep;
            
        }

        protected override void uiToDev()
        {
            pzkOrder.nValNum = (int)num12Count.Value;
           
            // 直流线路电阻
            pzkOrder.Flag_Rd = "";
            // 高阻
            pzkOrder.Flag_Rd += chkDcHZr.Checked ? "1" : "0";
            // 低阻
            pzkOrder.Flag_Rd += chkRdL.Checked ? "1" : "0";
            // 额定
            pzkOrder.Flag_Rd += chkRdN.Checked ? "1" : "0";

            // 运行模式
            pzkOrder.Flag_Ground = "";
            // 单级金属
            pzkOrder.Flag_Ground += chkSGround.Checked ? "1" : "0";
            // 单级大地
            pzkOrder.Flag_Ground += chkSMetal.Checked ? "1" : "0";
            // 双极运行
            pzkOrder.Flag_Ground += chkDRun.Checked ? "1" : "0";

            pzkOrder.FreqDim = (int)numFreqDim.Value;
            pzkOrder.FreqStart = (double)numFreqStat.Value;
            pzkOrder.FreqStep = (double)numFreqStep.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OnApply();

            CxbMvcs.zkOnSaveOrder();
        }
    }
}