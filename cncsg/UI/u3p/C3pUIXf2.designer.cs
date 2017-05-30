namespace cn.csg.dpcp.ui.u3p
{
    partial class C3pUIXf2
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
            this.button1 = new DevComponents.DotNetBar.ButtonX();
            this.dgvDevice = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnApply = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.cboStation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posOrNeg = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.aValue = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.bValue = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.cValue = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.autoDiff = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.diff = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 561);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "保存";
            this.button1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            // 
            // dgvDevice
            // 
            this.dgvDevice.AllowUserToAddRows = false;
            this.dgvDevice.AllowUserToDeleteRows = false;
            this.dgvDevice.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvDevice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.device,
            this.posOrNeg,
            this.aValue,
            this.bValue,
            this.cValue,
            this.autoDiff,
            this.diff});
            this.dgvDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDevice.Location = new System.Drawing.Point(3, 17);
            this.dgvDevice.Name = "dgvDevice";
            this.dgvDevice.RowTemplate.Height = 23;
            this.dgvDevice.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDevice.Size = new System.Drawing.Size(931, 231);
            this.dgvDevice.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDevice);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(937, 251);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设备参数";
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnApply.Location = new System.Drawing.Point(12, 330);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 11;
            this.btnApply.Text = "应用";
            this.btnApply.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground ;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(109, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "保存";
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground ;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboStation
            // 
            this.cboStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStation.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboStation.FormattingEnabled = true;
            this.cboStation.Location = new System.Drawing.Point(82, 12);
            this.cboStation.Name = "cboStation";
            this.cboStation.Size = new System.Drawing.Size(121, 20);
            this.cboStation.TabIndex = 13;
            this.cboStation.SelectedIndexChanged += new System.EventHandler(this.cboStation_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "当前站点";
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
            this.posOrNeg.HeaderText = "设备序号";
            this.posOrNeg.Name = "posOrNeg";
            this.posOrNeg.ReadOnly = true;
            // 
            // aValue
            // 
            // 
            // 
            // 
            this.aValue.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.aValue.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.aValue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.aValue.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.aValue.HeaderText = "A相偏差";
            this.aValue.Increment = 1D;
            this.aValue.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.aValue.Name = "aValue";
            this.aValue.Width = 120;
            // 
            // bValue
            // 
            // 
            // 
            // 
            this.bValue.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.bValue.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.bValue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.bValue.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.bValue.HeaderText = "B相偏差";
            this.bValue.Increment = 1D;
            this.bValue.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.bValue.Name = "bValue";
            this.bValue.Width = 120;
            // 
            // cValue
            // 
            // 
            // 
            // 
            this.cValue.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.cValue.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.cValue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cValue.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.cValue.HeaderText = "C相偏差";
            this.cValue.Increment = 1D;
            this.cValue.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.cValue.Name = "cValue";
            this.cValue.Width = 120;
            // 
            // autoDiff
            // 
            // 
            // 
            // 
            this.autoDiff.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.autoDiff.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.autoDiff.HeaderText = "自动分配偏差";
            this.autoDiff.Increment = 1D;
            this.autoDiff.Name = "autoDiff";
            this.autoDiff.Width = 130;
            // 
            // diff
            // 
            // 
            // 
            // 
            this.diff.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.diff.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diff.HeaderText = "标准偏差";
            this.diff.Increment = 1D;
            this.diff.Name = "diff";
            // 
            // C3pXf2UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1093, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboStation);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "C3pXf2UI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.C3pHlbDxDiffUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX button1;
        private System.Windows.Forms.DataGridView dgvDevice;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnApply;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private System.Windows.Forms.ComboBox cboStation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn device;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn posOrNeg;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn aValue;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn bValue;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn cValue;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn autoDiff;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn diff;
    }
}

