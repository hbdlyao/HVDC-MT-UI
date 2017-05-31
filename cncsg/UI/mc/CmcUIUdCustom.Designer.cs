namespace cn.csg.dpcp.ui.mc
{
    partial class CmcUIUdCustom
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkIsDefault = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCustom = new System.Windows.Forms.DataGridView();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btn_Apply = new DevComponents.DotNetBar.ButtonX();
            this.PdIndex = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.Ud22 = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.Ud21 = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.Ud11 = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustom)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkIsDefault);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(640, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "直流电压预设";
            // 
            // chkIsDefault
            // 
            this.chkIsDefault.AutoSize = true;
            this.chkIsDefault.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkIsDefault.Location = new System.Drawing.Point(28, 35);
            this.chkIsDefault.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.chkIsDefault.Name = "chkIsDefault";
            this.chkIsDefault.Size = new System.Drawing.Size(246, 25);
            this.chkIsDefault.TabIndex = 0;
            this.chkIsDefault.Text = "是否采用预设直流电压";
            this.chkIsDefault.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCustom);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(24, 147);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox2.Size = new System.Drawing.Size(1366, 611);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "直流电压预设值";
            // 
            // dgvCustom
            // 
            this.dgvCustom.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvCustom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PdIndex,
            this.Ud22,
            this.Ud21,
            this.Ud11});
            this.dgvCustom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustom.Location = new System.Drawing.Point(6, 29);
            this.dgvCustom.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dgvCustom.Name = "dgvCustom";
            this.dgvCustom.RowTemplate.Height = 23;
            this.dgvCustom.Size = new System.Drawing.Size(1354, 577);
            this.dgvCustom.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(438, 812);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btn_Apply
            // 
            this.btn_Apply.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Apply.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Apply.Location = new System.Drawing.Point(231, 812);
            this.btn_Apply.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(108, 40);
            this.btn_Apply.TabIndex = 3;
            this.btn_Apply.Text = "应用";
            this.btn_Apply.Click += new System.EventHandler(this.button1_Click);
            // 
            // PdIndex
            // 
            // 
            // 
            // 
            this.PdIndex.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.PdIndex.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.PdIndex.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PdIndex.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.PdIndex.HeaderText = "功率水平";
            this.PdIndex.Increment = 1D;
            this.PdIndex.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.PdIndex.Name = "PdIndex";
            this.PdIndex.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Ud22
            // 
            // 
            // 
            // 
            this.Ud22.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.Ud22.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.Ud22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Ud22.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.Ud22.HeaderText = "双极双阀";
            this.Ud22.Increment = 1D;
            this.Ud22.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.Ud22.Name = "Ud22";
            this.Ud22.Width = 200;
            // 
            // Ud21
            // 
            // 
            // 
            // 
            this.Ud21.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.Ud21.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.Ud21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Ud21.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.Ud21.HeaderText = "双极单阀";
            this.Ud21.Increment = 1D;
            this.Ud21.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.Ud21.Name = "Ud21";
            this.Ud21.Width = 200;
            // 
            // Ud11
            // 
            // 
            // 
            // 
            this.Ud11.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.Ud11.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.Ud11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Ud11.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.Ud11.HeaderText = "单极单阀";
            this.Ud11.Increment = 1D;
            this.Ud11.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.Ud11.Name = "Ud11";
            this.Ud11.Width = 200;
            // 
            // CmcUIUdCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2044, 945);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.Name = "CmcUIUdCustom";
            this.Text = "MCOrderUdCustomUI";
            this.Load += new System.EventHandler(this.MCOrderUdCustomUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkIsDefault;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCustom;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btn_Apply;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn PdIndex;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn Ud22;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn Ud21;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn Ud11;
    }
}