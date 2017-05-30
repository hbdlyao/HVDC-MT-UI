namespace cn.csg.dpcp.ui.mc
{
    partial class MCOrderUdCustomUI
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
            this.Ud22 = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.Ud21 = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.Ud11 = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustom)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkIsDefault);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "直流电压预设";
            // 
            // chkIsDefault
            // 
            this.chkIsDefault.AutoSize = true;
            this.chkIsDefault.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkIsDefault.Location = new System.Drawing.Point(15, 20);
            this.chkIsDefault.Name = "chkIsDefault";
            this.chkIsDefault.Size = new System.Drawing.Size(144, 16);
            this.chkIsDefault.TabIndex = 0;
            this.chkIsDefault.Text = "是否采用预设直流电压";
            this.chkIsDefault.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCustom);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(13, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(745, 349);
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
            this.Ud22,
            this.Ud21,
            this.Ud11});
            this.dgvCustom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustom.Location = new System.Drawing.Point(3, 17);
            this.dgvCustom.Name = "dgvCustom";
            this.dgvCustom.RowTemplate.Height = 23;
            this.dgvCustom.Size = new System.Drawing.Size(739, 329);
            this.dgvCustom.TabIndex = 0;
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
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(239, 464);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btn_Apply
            // 
            this.btn_Apply.Location = new System.Drawing.Point(126, 464);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(59, 23);
            this.btn_Apply.TabIndex = 3;
            this.btn_Apply.Text = "应用";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.button1_Click);
            // 
            // MCOrderUdCustomUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 540);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MCOrderUdCustomUI";
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
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn Ud22;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn Ud21;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn Ud11;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btn_Apply;
    }
}