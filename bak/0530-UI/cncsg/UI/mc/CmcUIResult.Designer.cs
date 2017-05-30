using System.Windows.Forms;

namespace cn.csg.dpcp.ui.mc
{
    partial class CmcUIResult
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstCase = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExportAll = new DevComponents.DotNetBar.ButtonX();
            this.btnExportSelected = new DevComponents.DotNetBar.ButtonX();
            this.btnCoundQ = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.PdPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Udio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UdL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcPd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pconv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qconv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alphaOrgamma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qf_max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qf_min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Udio_N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uv_N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tk_N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ud6Valve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pd6Valve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pac6Valve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qac6Valve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstStation = new System.Windows.Forms.ListBox();
            this.btnLoad = new DevComponents.DotNetBar.ButtonX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCase = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstCase);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(24, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "工况选择";
            // 
            // lstCase
            // 
            this.lstCase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCase.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstCase.FormattingEnabled = true;
            this.lstCase.ItemHeight = 12;
            this.lstCase.Location = new System.Drawing.Point(6, 20);
            this.lstCase.Name = "lstCase";
            this.lstCase.Size = new System.Drawing.Size(158, 60);
            this.lstCase.TabIndex = 1;
            this.lstCase.SelectedIndexChanged += new System.EventHandler(this.lstCase_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCase);
            this.groupBox2.Controls.Add(this.btnExportAll);
            this.groupBox2.Controls.Add(this.btnExportSelected);
            this.groupBox2.Controls.Add(this.btnCoundQ);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(352, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 87);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // btnExportAll
            // 
            this.btnExportAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExportAll.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExportAll.Location = new System.Drawing.Point(102, 58);
            this.btnExportAll.Name = "btnExportAll";
            this.btnExportAll.Size = new System.Drawing.Size(92, 23);
            this.btnExportAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnExportAll.TabIndex = 4;
            this.btnExportAll.Text = "导出所有工况";
            this.btnExportAll.Click += new System.EventHandler(this.btnExportAll_Click);
            // 
            // btnExportSelected
            // 
            this.btnExportSelected.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportSelected.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExportSelected.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExportSelected.Location = new System.Drawing.Point(6, 58);
            this.btnExportSelected.Name = "btnExportSelected";
            this.btnExportSelected.Size = new System.Drawing.Size(90, 23);
            this.btnExportSelected.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnExportSelected.TabIndex = 3;
            this.btnExportSelected.Text = "导出选中工况";
            this.btnExportSelected.Click += new System.EventHandler(this.btnExportSelected_Click);
            // 
            // btnCoundQ
            // 
            this.btnCoundQ.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCoundQ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCoundQ.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCoundQ.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCoundQ.Location = new System.Drawing.Point(119, 20);
            this.btnCoundQ.Name = "btnCoundQ";
            this.btnCoundQ.Size = new System.Drawing.Size(75, 23);
            this.btnCoundQ.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnCoundQ.TabIndex = 2;
            this.btnCoundQ.Text = "工况查询";
            this.btnCoundQ.Click += new System.EventHandler(this.btnCoundQ_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(558, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "理想空载额定电压(kV)";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(558, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "阀侧额定电压(kV)";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PdPer,
            this.Uac,
            this.Uv,
            this.Udio,
            this.Ud,
            this.UdL,
            this.Id,
            this.DcPd,
            this.Pconv,
            this.Qconv,
            this.TC,
            this.alphaOrgamma,
            this.miu,
            this.Qf_max,
            this.Qf_min,
            this.Udio_N,
            this.Uv_N,
            this.Tk_N,
            this.Tk,
            this.Ud6Valve,
            this.Pd6Valve,
            this.Pac6Valve,
            this.Qac6Valve});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv.Location = new System.Drawing.Point(0, 96);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1076, 470);
            this.dgv.TabIndex = 4;
            this.dgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewX1_RowPostPaint);
            // 
            // PdPer
            // 
            this.PdPer.HeaderText = "功率水平PdPer(%)";
            this.PdPer.Name = "PdPer";
            this.PdPer.ReadOnly = true;
            this.PdPer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PdPer.Width = 110;
            // 
            // Uac
            // 
            this.Uac.HeaderText = "网侧电压Uac(kV)";
            this.Uac.Name = "Uac";
            this.Uac.ReadOnly = true;
            this.Uac.Width = 105;
            // 
            // Uv
            // 
            this.Uv.HeaderText = "阀侧电压Uv(kV)";
            this.Uv.Name = "Uv";
            this.Uv.ReadOnly = true;
            this.Uv.Width = 95;
            // 
            // Udio
            // 
            this.Udio.HeaderText = "理想空载电压Udio(kV)";
            this.Udio.Name = "Udio";
            this.Udio.ReadOnly = true;
            this.Udio.Width = 135;
            // 
            // Ud
            // 
            this.Ud.HeaderText = "直流端口电压Ud(kV)";
            this.Ud.Name = "Ud";
            this.Ud.ReadOnly = true;
            this.Ud.Width = 135;
            // 
            // UdL
            // 
            this.UdL.HeaderText = "直流对地电压UdL(kV)";
            this.UdL.Name = "UdL";
            this.UdL.ReadOnly = true;
            this.UdL.Width = 135;
            // 
            // Id
            // 
            this.Id.HeaderText = "直流电流DcId(kA)";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // DcPd
            // 
            this.DcPd.HeaderText = "直流功率Pd(kA)";
            this.DcPd.Name = "DcPd";
            this.DcPd.ReadOnly = true;
            this.DcPd.Width = 125;
            // 
            // Pconv
            // 
            this.Pconv.HeaderText = "换流器有功Pconv(MW)";
            this.Pconv.Name = "Pconv";
            this.Pconv.ReadOnly = true;
            this.Pconv.Width = 135;
            // 
            // Qconv
            // 
            this.Qconv.HeaderText = "换流器无功Qconv(Mvar)";
            this.Qconv.Name = "Qconv";
            this.Qconv.ReadOnly = true;
            this.Qconv.Width = 135;
            // 
            // TC
            // 
            this.TC.HeaderText = "变压器抽头档位TC";
            this.TC.Name = "TC";
            this.TC.ReadOnly = true;
            this.TC.Width = 130;
            // 
            // alphaOrgamma
            // 
            this.alphaOrgamma.HeaderText = "触发角/关断角alphaOrgamma(°)";
            this.alphaOrgamma.Name = "alphaOrgamma";
            this.alphaOrgamma.ReadOnly = true;
            this.alphaOrgamma.Width = 150;
            // 
            // miu
            // 
            this.miu.HeaderText = "换相角miu(°)";
            this.miu.Name = "miu";
            this.miu.ReadOnly = true;
            this.miu.Width = 90;
            // 
            // Qf_max
            // 
            this.Qf_max.HeaderText = "滤波器的最大无功Qf_max(Mvar)";
            this.Qf_max.Name = "Qf_max";
            this.Qf_max.ReadOnly = true;
            this.Qf_max.Width = 145;
            // 
            // Qf_min
            // 
            this.Qf_min.HeaderText = "滤波器的最小无功Qf_min(Mvar)";
            this.Qf_min.Name = "Qf_min";
            this.Qf_min.ReadOnly = true;
            this.Qf_min.Width = 145;
            // 
            // Udio_N
            // 
            this.Udio_N.HeaderText = "额定理想空载电压Udio_N(kV)";
            this.Udio_N.Name = "Udio_N";
            this.Udio_N.ReadOnly = true;
            this.Udio_N.Width = 170;
            // 
            // Uv_N
            // 
            this.Uv_N.HeaderText = "额定阀侧电压Uv_N(kV)";
            this.Uv_N.Name = "Uv_N";
            this.Uv_N.ReadOnly = true;
            this.Uv_N.Width = 140;
            // 
            // Tk_N
            // 
            this.Tk_N.HeaderText = "变压器额定变比";
            this.Tk_N.Name = "Tk_N";
            this.Tk_N.ReadOnly = true;
            this.Tk_N.Width = 130;
            // 
            // Tk
            // 
            this.Tk.HeaderText = "变压器实际变比";
            this.Tk.Name = "Tk";
            this.Tk.ReadOnly = true;
            this.Tk.Width = 130;
            // 
            // Ud6Valve
            // 
            this.Ud6Valve.HeaderText = "6脉动阀电压";
            this.Ud6Valve.Name = "Ud6Valve";
            this.Ud6Valve.ReadOnly = true;
            this.Ud6Valve.Width = 120;
            // 
            // Pd6Valve
            // 
            this.Pd6Valve.HeaderText = "6脉动阀直流功率";
            this.Pd6Valve.Name = "Pd6Valve";
            this.Pd6Valve.ReadOnly = true;
            this.Pd6Valve.Width = 140;
            // 
            // Pac6Valve
            // 
            this.Pac6Valve.HeaderText = "6脉动阀有功";
            this.Pac6Valve.Name = "Pac6Valve";
            this.Pac6Valve.ReadOnly = true;
            this.Pac6Valve.Width = 120;
            // 
            // Qac6Valve
            // 
            this.Qac6Valve.HeaderText = "6脉动阀有功";
            this.Qac6Valve.Name = "Qac6Valve";
            this.Qac6Valve.ReadOnly = true;
            this.Qac6Valve.Width = 120;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstStation);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(197, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(148, 87);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "整流站选择";
            // 
            // lstStation
            // 
            this.lstStation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstStation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstStation.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstStation.FormattingEnabled = true;
            this.lstStation.ItemHeight = 12;
            this.lstStation.Location = new System.Drawing.Point(6, 20);
            this.lstStation.Name = "lstStation";
            this.lstStation.Size = new System.Drawing.Size(135, 60);
            this.lstStation.TabIndex = 6;
            this.lstStation.SelectedIndexChanged += new System.EventHandler(this.lstStation_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLoad.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLoad.Location = new System.Drawing.Point(837, 61);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "读入数据";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Location = new System.Drawing.Point(698, 21);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(100, 21);
            this.textBoxX1.TabIndex = 8;
            // 
            // textBoxX2
            // 
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX2.Location = new System.Drawing.Point(698, 62);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.PreventEnterBeep = true;
            this.textBoxX2.Size = new System.Drawing.Size(100, 21);
            this.textBoxX2.TabIndex = 9;
            // 
            // txtCase
            // 
            // 
            // 
            // 
            this.txtCase.Border.Class = "TextBoxBorder";
            this.txtCase.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCase.Location = new System.Drawing.Point(6, 23);
            this.txtCase.Name = "txtCase";
            this.txtCase.PreventEnterBeep = true;
            this.txtCase.Size = new System.Drawing.Size(100, 21);
            this.txtCase.TabIndex = 10;
            // 
            // MCResultUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 566);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "MCResultUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主回路状态计算-结果查看";
            this.Load += new System.EventHandler(this.MCCalcResultUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstCase;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.ButtonX btnExportAll;
        private DevComponents.DotNetBar.ButtonX btnExportSelected;
        private DevComponents.DotNetBar.ButtonX btnCoundQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private DataGridView dgv;
        private GroupBox groupBox3;
        private ListBox lstStation;
        private DataGridViewTextBoxColumn PdPer;
        private DataGridViewTextBoxColumn Uac;
        private DataGridViewTextBoxColumn Uv;
        private DataGridViewTextBoxColumn Udio;
        private DataGridViewTextBoxColumn Ud;
        private DataGridViewTextBoxColumn UdL;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn DcPd;
        private DataGridViewTextBoxColumn Pconv;
        private DataGridViewTextBoxColumn Qconv;
        private DataGridViewTextBoxColumn TC;
        private DataGridViewTextBoxColumn alphaOrgamma;
        private DataGridViewTextBoxColumn miu;
        private DataGridViewTextBoxColumn Qf_max;
        private DataGridViewTextBoxColumn Qf_min;
        private DataGridViewTextBoxColumn Udio_N;
        private DataGridViewTextBoxColumn Uv_N;
        private DataGridViewTextBoxColumn Tk_N;
        private DataGridViewTextBoxColumn Tk;
        private DataGridViewTextBoxColumn Ud6Valve;
        private DataGridViewTextBoxColumn Pd6Valve;
        private DataGridViewTextBoxColumn Pac6Valve;
        private DataGridViewTextBoxColumn Qac6Valve;
        private DevComponents.DotNetBar.ButtonX btnLoad;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCase;
    }
}