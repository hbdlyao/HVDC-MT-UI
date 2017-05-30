using cn.csg.dpcp.common;
using Hvdc.MT.HvdcCommon;
using Hvdc.MT.xb.App;
using Hvdc.MT.xb.Def;
using Hvdc.MT.xb.Device;
using Hvdc.MT.xb.DevTBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yao.BaseFrame.Device;

namespace cn.csg.dpcp.ui.xb
{
    /// <summary>
    /// 单回路接地极线
    /// </summary>
    public partial class CxbSingleGroundLineUI : DpcpBaseForm
    {
        // 用以标识新增新路名后的数字，如“新增线路X”
        private int newLineSeq = 1;

        private const string newLine = "新线路";

        private CxbDevGroundLine_Seg DevSeg = null;

        private IDictionary<string, CxbDevGroundLine_Seg> DevSegMap = new Dictionary<string, CxbDevGroundLine_Seg>();

        public CxbSingleGroundLineUI()
        {
            InitializeComponent();
            Name = Constants.CxbDcLineLbqGroundLineUI;
        }

        /// <summary>
        /// 界面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CxbSingleGroundLineUI_Load(object sender, EventArgs e)
        {
            InitForm(CxbVars.pxbHvdcGrid, CHvdcDefs.xbGridType, CxbDef.xb_GroundLine);
            FillComboxFromDevice(cboStation);
            EnableControl();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Device.nEw
            CxbDevGroundLine_Seg vSeg = CxbDevTBL.xbNewDevice(CxbDef.xb_GroundLine_Seg) as CxbDevGroundLine_Seg;
            while (lstLine.Items.Contains(newLine + newLineSeq))
            {
                newLineSeq++;
            }
            vSeg.DeviceName = newLine + newLineSeq;
            DevSegMap.Add(vSeg.DeviceName, vSeg);
            Device.Add(vSeg);

            lstLine.Items.Insert(0, vSeg.DeviceName);

            reset(this);
            lstLine.SelectedIndex = 0;
            EnableControl();
        }

        /// <summary>
        /// 重置界面所有输入参数
        /// </summary>
        /// <param name="control"></param>
        private void reset(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c.Controls.Count > 0)
                {
                    reset(c);
                }
                if (c is TextBox)
                {
                    (c as TextBox).ResetText();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            string lineName = lstLine.SelectedItem.ToString();

            DevSegMap.Remove(DevSeg.DeviceName);
            Device.Remove(DevSeg);

            lstLine.Items.Remove(lineName);

            DevSeg = null;
            if (lstLine.Items.Count > 0)
            {
                lstLine.SelectedIndex = 0;
            }

            EnableControl();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OnSave();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            uiToDevSeg();
        }

        protected override void OnClear()
        {
            lstLine.Items.Clear();

            reset(this);//
        }

        protected override void OnLoadDevice()
        {
            AddToSegMap();

            cboStationChanged();

        }


        /// <summary>
        /// 设备下来框选择重新加载断数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboStationChanged()
        {
            CxbDevGroundLine vDev = Device as CxbDevGroundLine;

            foreach (CxbDevGroundLine_Seg vDevSeg in vDev.Children())
            {
                lstLine.Items.Add(vDevSeg.DeviceName);
            }


            //
            lblLineCount.Text = lstLine.Items.Count.ToString();
            if (lstLine.Items.Count > 0)
            {
                lstLine.SelectedIndex = 0;
            }

        }
        protected virtual void AddToSegMap()
        {//Seg
            DevSegMap.Clear();

            CxbDevGroundLine vDev = Device as CxbDevGroundLine;
            foreach (CxbDevGroundLine_Seg vDevSeg in vDev.Children())
            {
                DevSegMap.Add(vDevSeg.DeviceName, vDevSeg);
            }

        }


        private void cboStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnDeviceChanged(cboStation);
            EnableControl();
        }


        private void lstLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLine.SelectedIndex < 0)
            {
                return;
            }

            DevSeg = DevSegMap[lstLine.SelectedItem.ToString()] as CxbDevGroundLine_Seg;

            DevSeqToUI();
        }

        /// <summary>
        /// 对象数据绑定到ui
        /// </summary>
        private void DevSeqToUI()
        {
            txtSoilRe.Text = DevSeg.LineModel.SoilRe.ToString();
            txtLeng.Text = DevSeg.LineModel.Leng.ToString();
            txtL_CondRadius.Text = DevSeg.LineModel.L_CondRadius.ToString();
            txtG_CondRadius.Text = DevSeg.LineModel.G_CondRadius.ToString();
            if (DevSeg.LineModel.L_CondType == 1)
            {
                radioButton5.Checked = true;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                textBox9.Text = DevSeg.LineModel.L_CondValue.ToString();
                textBox6.Clear();
                textBox7.Clear();
            }
            else if (DevSeg.LineModel.L_CondType == 2)
            {
                radioButton5.Checked = false;
                radioButton1.Checked = true;
                radioButton2.Checked = false;
                textBox9.Clear();
                textBox6.Text = DevSeg.LineModel.L_CondValue.ToString();
                textBox7.Clear();
            }
            else
            {
                radioButton5.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = true;
                textBox9.Clear();
                textBox6.Clear();
                textBox7.Text = DevSeg.LineModel.L_CondValue.ToString();
            }

            if (DevSeg.LineModel.G_CondType == 1)
            {
                radioButton6.Checked = true;
                radioButton4.Checked = false;
                radioButton3.Checked = false;
                textBox21.Text = DevSeg.LineModel.G_CondValue.ToString();
                textBox18.Clear();
                textBox19.Clear();
            }
            else if (DevSeg.LineModel.G_CondType == 2)
            {
                radioButton6.Checked = false;
                radioButton4.Checked = true;
                radioButton3.Checked = false;
                textBox21.Clear();
                textBox18.Text = DevSeg.LineModel.G_CondValue.ToString();
                textBox19.Clear();
            }
            else
            {
                radioButton6.Checked = false;
                radioButton4.Checked = false;
                radioButton3.Checked = true;
                textBox21.Clear();
                textBox18.Clear();
                textBox19.Text = DevSeg.LineModel.G_CondValue.ToString();
            }

            txtL_SplitAmount.Text = DevSeg.LineModel.L_SplitAmount.ToString();
            txtG_SplitAmount.Text = DevSeg.LineModel.G_SplitAmount.ToString();
            txtL_BundleSpace.Text = DevSeg.LineModel.L_BundleSpace.ToString();
            txtG_BundleSpace.Text = DevSeg.LineModel.G_BundleSpace.ToString();
        }

        private void fillDefaultValue(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c.Controls.Count > 0)
                {
                    fillDefaultValue(c);
                }
                if (c is TextBox)
                {
                    if ((c as TextBox).Text.Equals(string.Empty) || (c as TextBox).Text == null)
                    {
                        (c as TextBox).Text = "0";
                    }
                }
            }
        }

        /// <summary>
        /// 界面数据填充到对象
        /// </summary>
        private void uiToDevSeg()
        {
            fillDefaultValue(this);

            DevSeg.LineModel.SoilRe = double.Parse(txtSoilRe.Text);
            DevSeg.LineModel.Leng = double.Parse(txtLeng.Text);
            DevSeg.LineModel.L_CondRadius = double.Parse(txtL_CondRadius.Text);
            DevSeg.LineModel.G_CondRadius = double.Parse(txtG_CondRadius.Text);

            if (radioButton5.Checked)
            {
                DevSeg.LineModel.L_CondValue = double.Parse(textBox9.Text);
            }
            else if (radioButton1.Checked)
            {
                DevSeg.LineModel.L_CondValue = double.Parse(textBox6.Text);
            }
            else
            {
                DevSeg.LineModel.L_CondValue = double.Parse(textBox7.Text);
            }

            if (radioButton6.Checked)
            {
                DevSeg.LineModel.G_CondValue = double.Parse(textBox21.Text);
            }
            else if (radioButton4.Checked)
            {
                DevSeg.LineModel.G_CondValue = double.Parse(textBox18.Text);
            }
            else
            {
                DevSeg.LineModel.G_CondValue = double.Parse(textBox19.Text);
            }

            DevSeg.LineModel.L_SplitAmount = int.Parse(txtL_SplitAmount.Text);
            DevSeg.LineModel.G_SplitAmount = int.Parse(txtG_SplitAmount.Text);
            DevSeg.LineModel.L_BundleSpace = double.Parse(txtL_BundleSpace.Text);
            DevSeg.LineModel.G_BundleSpace = double.Parse(txtG_BundleSpace.Text);
        }

        protected override void EnableControl()
        {
            btnRemove.Enabled = lstLine.Items.Count > 0;

            lblLineCount.Text = lstLine.Items.Count.ToString();
        }
    }
}
