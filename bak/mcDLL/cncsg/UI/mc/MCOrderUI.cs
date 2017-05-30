using cn.csg.dpcp.common;
using Hvdc.MT.mc.App;
using Hvdc.MT.mc.Solve;
using System;
using System.Text;
using System.Windows.Forms;

namespace cn.csg.dpcp.ui.mc
{
    public partial class MCOrderUI : DpcpBaseForm
    {
        protected CmcOrder pOrder;

        public MCOrderUI()
        {
            InitializeComponent();
            Name = Constants.MC_Order;                        
        }

        
        private void MCOrderUI_Load(object sender, EventArgs e)
        {
            intNumControlButton(this);

            pOrder = CmcVars.pOrder;

            DevToUI();
        }

        protected override void DevToUI()
        {
            chkRAcUdMax.Checked = "1".Equals(pOrder.Flag_Uac.Substring(0, 1));
            // 额定
            chkRAcUdN.Checked = "1".Equals(pOrder.Flag_Uac.Substring(1, 1));
            // 较低
            chkRAcUdLow.Checked = "1".Equals(pOrder.Flag_Uac.Substring(2, 1));
            // 极低
            chkRAcUdLowest.Checked = "1".Equals(pOrder.Flag_Uac.Substring(3, 1));

            //  直流电压
            // 全压
            chkDcUdAll.Checked = "1".Equals(pOrder.Flag_Ud.Substring(0, 1));
            // 80%
            chkDcUd80.Checked = "1".Equals(pOrder.Flag_Ud.Substring(1, 1));
            // 70% 
            chkDcUd70.Checked = "1".Equals(pOrder.Flag_Ud.Substring(2, 1));

            // 直流线路电阻
            // 高阻
            chkDcHZr.Checked = "1".Equals(pOrder.Flag_Rd.Substring(0, 1));
            // 低阻
            chkDcLZr.Checked = "1".Equals(pOrder.Flag_Rd.Substring(1, 1));
            // 额定
            chkDcNZr.Checked = "1".Equals(pOrder.Flag_Rd.Substring(2, 1));

            // 运行模式
            // 单级金属
            chkSGround.Checked = "1".Equals(pOrder.Flag_Ground.Substring(0, 1));
            // 单级大地
            chkSMetal.Checked = "1".Equals(pOrder.Flag_Ground.Substring(1, 1));
            // 双极运行
            chkDRun.Checked = "1".Equals(pOrder.Flag_Ground.Substring(2, 1));
            // 双极并联
            chkDLin.Checked = "1".Equals(pOrder.Flag_Ground.Substring(3, 1));

            // 12脉动中间是否接地
            chk12Count.Checked = pOrder.Is6Pulse == 1;

            /// 是否交叉
            chkIsUacSwap.Checked = pOrder.IsUacSwap == 1;

            // 是否单负荷
            if (pOrder.IsLoadSingle == 0)
            {
                radioSingle.Checked = true;
            }
            else
            {
                radioMult.Checked = true;
            }

            // 是否极线对地
            if (pOrder.IsUdToGround == 1)
            {
                radGroundLine.Checked = true;
            }
            else
            {
                radMidLine.Checked = true;
            }

            num12Count.Value = pOrder.nValNum;
            numUd.Value = (decimal)pOrder.UdSingle;
            numPd.Value = (decimal)pOrder.PdSingle;
            //numId.Value = (decimal)pOrder.DcId;
            numBdStart.Value = (decimal)pOrder.PdStartPer;
            numBdIncre.Value = (decimal)pOrder.PdIncrePer;
            numBdSize.Value = (decimal)pOrder.PdSize;

        }

        protected override void uiToDev()
        {
            // 交流电压
            pOrder.Flag_Uac = "";
            // 最大
            pOrder.Flag_Uac += chkRAcUdMax.Checked ? "1" : "0";
            // 额定
            pOrder.Flag_Uac += chkRAcUdN.Checked ? "1" : "0";
            // 较低
            pOrder.Flag_Uac += chkRAcUdLow.Checked ? "1" : "0";
            // 极低
            pOrder.Flag_Uac += chkRAcUdLowest.Checked ? "1" : "0";

            //  直流电压
            pOrder.Flag_Ud = "";
            // 全压
            pOrder.Flag_Ud += chkDcUdAll.Checked ? "1" : "0";
            // 80%
            pOrder.Flag_Ud += chkDcUd80.Checked ? "1" : "0";
            // 70% 
            pOrder.Flag_Ud += chkDcUd70.Checked ? "1" : "0"; ;

            // 直流线路电阻
            pOrder.Flag_Rd = "";
            // 高阻
            pOrder.Flag_Rd += chkDcHZr.Checked ? "1" : "0";
            // 低阻
            pOrder.Flag_Rd += chkDcLZr.Checked ? "1" : "0";
            // 额定
            pOrder.Flag_Rd += chkDcNZr.Checked ? "1" : "0";

            // 运行模式
            pOrder.Flag_Ground = "";
            // 单级金属
            pOrder.Flag_Ground += chkSGround.Checked ? "1" : "0";
            // 单级大地
            pOrder.Flag_Ground += chkSMetal.Checked ? "1" : "0";
            // 双极运行
            pOrder.Flag_Ground += chkDRun.Checked ? "1" : "0";
            // 双极并联
            pOrder.Flag_Ground += chkDLin.Checked ? "1" : "0";

            // 12脉动中间是否接地
            pOrder.Is6Pulse = chk12Count.Checked ? 1 : 0;

            // 是否交叉
            pOrder.IsUacSwap = chkIsUacSwap.Checked ? 1 : 0;

            // 是否单负荷
            pOrder.IsLoadSingle = radioSingle.Checked ? 1 : 0;

            // 是否极线对地
            pOrder.IsUdToGround = radGroundLine.Checked ? 1 : 0;

            pOrder.IsUdToGround = radGroundLine.Checked ? 1 : 2;
            pOrder.IsLoadSingle = radioSingle.Checked ? 0 : 1;
            pOrder.nValNum = (int)num12Count.Value;
            pOrder.UdSingle = (double)numUd.Value;
            pOrder.PdSingle = (double)numPd.Value;
            //pOrder.DcId = (double)numId.Value;
            pOrder.PdStartPer = (double)numBdStart.Value;
            pOrder.PdIncrePer = (double)numBdIncre.Value;
            pOrder.PdSize = (int)numBdSize.Value;
        }


        private void configCheckBox(int choose, CheckBox box)
        {
            box.Checked = choose != 0;
        }

        private int getCheckBoxValue(CheckBox box)
        {
            return box.Checked ? 1 : 0;
        }

        
        protected void RestUI()
        {
            chkBAcUdNE.Checked = false;
            chkDcHZr.Checked = false;
            chkDcLZr.Checked = false;
            chkDcUd70.Checked = false;
            chkDcUd80.Checked = false;
            chkDcUdAll.Checked = false;
            chkDRun.Checked = false;
            chkRAcUdLow.Checked = false;
            chkRAcUdLowest.Checked = false;
            chkRAcUdMax.Checked = false;
            chkRAcUdN.Checked = false;
            chkSGround.Checked = false;
            chkSMetal.Checked = false;
            numUd.ResetText();
            numPd.ResetText();
            numId.ResetText();
            numBdSize.ResetText();
            numBdStart.ResetText();
            numBdIncre.ResetText();
        }

        
        // 勾选“是否不平衡”时“直流电压水平计算选择”内的全部勾选
        private void chkBAcUdNE_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBAcUdNE.Checked)
            {
                chkDcUdAll.Checked = true;
                chkDcUd80.Checked = true;
                chkDcUd70.Checked = true;
            }
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

        private void radioSingle_CheckedChanged(object sender, EventArgs e)
        {
            numBdStart.ResetText();
            numBdIncre.ResetText();
            numBdSize.ResetText();
            numBdStart.Enabled = false;
            numBdIncre.Enabled = false;
            numBdSize.Enabled = false;
            numUd.Enabled = true;
            numPd.Enabled = true;
            numId.Enabled = true;
        }

        private void radioMult_CheckedChanged(object sender, EventArgs e)
        {
            numUd.ResetText();
            numPd.ResetText();
            numId.ResetText();
            numBdStart.Enabled = true;
            numBdIncre.Enabled = true;
            numBdSize.Enabled = true;
            numUd.Enabled = false;
            numPd.Enabled = false;
            numId.Enabled = false;
     
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OnApply();

            CmcMvcs.OnSaveOrder();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            OnApply();

            pOrder.CalName = "南网多端mc计算";
            CmcMvcs.OnSaveOrder();


            //
            StringBuilder vdbfFile = new StringBuilder();
            vdbfFile.Append(CmcParams.dbfFile);

            StringBuilder vCalName = new StringBuilder();
            vCalName.Append("南网多端mc计算");           

            CmcDLL.Run(vdbfFile, vCalName);

        }
    }
}
