namespace cn.csg.dpcp.ui.u3p
{
    partial class C3pConvertorUI
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDevice = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cboStation = new System.Windows.Forms.ComboBox();
            this.device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posOrNeg = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.value1 = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.value2 = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.value3 = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.value4 = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.value5 = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.value6 = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.autoDiff = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.diff = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(97, 410);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 26);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnApply.Location = new System.Drawing.Point(10, 410);
            this.btnApply.Margin = new System.Windows.Forms.Padding(2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(65, 26);
            this.btnApply.TabIndex = 9;
            this.btnApply.Text = "应用";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDevice);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(10, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1071, 326);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设备参数";
            // 
            // dgvDevice
            // 
            this.dgvDevice.AllowUserToAddRows = false;
            this.dgvDevice.AllowUserToDeleteRows = false;
            this.dgvDevice.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvDevice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.device,
            this.posOrNeg,
            this.value1,
            this.value2,
            this.value3,
            this.value4,
            this.value5,
            this.value6,
            this.autoDiff,
            this.diff});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDevice.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDevice.Location = new System.Drawing.Point(3, 17);
            this.dgvDevice.Name = "dgvDevice";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevice.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDevice.RowTemplate.Height = 23;
            this.dgvDevice.Size = new System.Drawing.Size(1065, 306);
            this.dgvDevice.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "当前站点";
            // 
            // cboStation
            // 
            this.cboStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStation.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboStation.FormattingEnabled = true;
            this.cboStation.Location = new System.Drawing.Point(67, 15);
            this.cboStation.Name = "cboStation";
            this.cboStation.Size = new System.Drawing.Size(121, 20);
            this.cboStation.TabIndex = 12;
            this.cboStation.SelectedIndexChanged += new System.EventHandler(this.cboStation_SelectedIndexChanged);
            // 
            // device
            // 
            this.device.HeaderText = "设备";
            this.device.Name = "device";
            this.device.ReadOnly = true;
            // 
            // posOrNeg
            // 
            // 
            // 
            // 
            this.posOrNeg.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.posOrNeg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.posOrNeg.HeaderText = "站点序号";
            this.posOrNeg.Name = "posOrNeg";
            this.posOrNeg.ReadOnly = true;
            this.posOrNeg.Width = 80;
            // 
            // value1
            // 
            // 
            // 
            // 
            this.value1.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.value1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.value1.HeaderText = "阀1角度偏差";
            this.value1.Increment = 1D;
            this.value1.Name = "value1";
            // 
            // value2
            // 
            // 
            // 
            // 
            this.value2.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.value2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.value2.HeaderText = "阀2角度偏差";
            this.value2.Increment = 1D;
            this.value2.Name = "value2";
            // 
            // value3
            // 
            // 
            // 
            // 
            this.value3.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.value3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.value3.HeaderText = "阀3角度偏差";
            this.value3.Increment = 1D;
            this.value3.Name = "value3";
            // 
            // value4
            // 
            // 
            // 
            // 
            this.value4.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.value4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.value4.HeaderText = "阀4角度偏差";
            this.value4.Increment = 1D;
            this.value4.Name = "value4";
            // 
            // value5
            // 
            // 
            // 
            // 
            this.value5.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.value5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.value5.HeaderText = "阀5角度偏差";
            this.value5.Increment = 1D;
            this.value5.Name = "value5";
            // 
            // value6
            // 
            // 
            // 
            // 
            this.value6.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.value6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.value6.HeaderText = "阀6角度偏差";
            this.value6.Increment = 1D;
            this.value6.Name = "value6";
            // 
            // autoDiff
            // 
            // 
            // 
            // 
            this.autoDiff.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.autoDiff.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.autoDiff.HeaderText = "自动分配角度偏差";
            this.autoDiff.Increment = 1D;
            this.autoDiff.Name = "autoDiff";
            this.autoDiff.Width = 140;
            // 
            // diff
            // 
            // 
            // 
            // 
            this.diff.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.diff.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diff.HeaderText = "角度标准差";
            this.diff.Increment = 1D;
            this.diff.Name = "diff";
            // 
            // C3pConvertorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1093, 554);
            this.Controls.Add(this.cboStation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnSave);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "C3pConvertorUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.C3pHlbXhjDiffUI_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn device;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn posOrNeg;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn value1;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn value2;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn value3;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn value4;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn value5;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn value6;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn autoDiff;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn diff;
    }
}

