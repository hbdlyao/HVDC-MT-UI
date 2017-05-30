namespace cn.csg.dpcp.ui.mc
{
    partial class CmcUIMetalLine
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numZrMin = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numZrMax = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numZrN = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cboStation2 = new System.Windows.Forms.ComboBox();
            this.cboStation1 = new System.Windows.Forms.ComboBox();
            this.btnAddLine = new DevComponents.DotNetBar.ButtonX();
            this.btnRemove = new DevComponents.DotNetBar.ButtonX();
            this.grpBoxDevice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZrMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZrMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZrN)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(128, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "送端换流站名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(809, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "受端换流站名称";
            // 
            // numZrMin
            // 
            this.numZrMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numZrMin.DecimalPlaces = 4;
            this.numZrMin.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numZrMin.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numZrMin.Location = new System.Drawing.Point(1069, 201);
            this.numZrMin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.numZrMin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numZrMin.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numZrMin.Name = "numZrMin";
            this.numZrMin.Size = new System.Drawing.Size(220, 27);
            this.numZrMin.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(809, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "电阻最小值(Ω)";
            // 
            // numZrMax
            // 
            this.numZrMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numZrMax.DecimalPlaces = 4;
            this.numZrMax.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numZrMax.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numZrMax.Location = new System.Drawing.Point(431, 198);
            this.numZrMax.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.numZrMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numZrMax.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numZrMax.Name = "numZrMax";
            this.numZrMax.Size = new System.Drawing.Size(220, 27);
            this.numZrMax.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(128, 201);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "电阻最大值(Ω)";
            // 
            // numZrN
            // 
            this.numZrN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numZrN.DecimalPlaces = 4;
            this.numZrN.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numZrN.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numZrN.Location = new System.Drawing.Point(431, 259);
            this.numZrN.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.numZrN.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numZrN.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numZrN.Name = "numZrN";
            this.numZrN.Size = new System.Drawing.Size(220, 27);
            this.numZrN.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(128, 268);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "电阻额定值(Ω)";
            // 
            // cboStation2
            // 
            this.cboStation2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStation2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStation2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboStation2.FormattingEnabled = true;
            this.cboStation2.Location = new System.Drawing.Point(1069, 133);
            this.cboStation2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cboStation2.Name = "cboStation2";
            this.cboStation2.Size = new System.Drawing.Size(184, 29);
            this.cboStation2.TabIndex = 33;
            // 
            // cboStation1
            // 
            this.cboStation1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStation1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStation1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboStation1.FormattingEnabled = true;
            this.cboStation1.Location = new System.Drawing.Point(431, 138);
            this.cboStation1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cboStation1.Name = "cboStation1";
            this.cboStation1.Size = new System.Drawing.Size(184, 29);
            this.cboStation1.TabIndex = 32;
            // 
            // btnAddLine
            // 
            this.btnAddLine.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddLine.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddLine.Location = new System.Drawing.Point(445, 821);
            this.btnAddLine.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(138, 40);
            this.btnAddLine.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddLine.TabIndex = 34;
            this.btnAddLine.Text = "新增线路";
            this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRemove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRemove.Location = new System.Drawing.Point(595, 821);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(138, 40);
            this.btnRemove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRemove.TabIndex = 35;
            this.btnRemove.Text = "删除当前线路";
            this.btnRemove.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // MCDcMetallLineUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 875);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddLine);
            this.Controls.Add(this.cboStation2);
            this.Controls.Add(this.cboStation1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numZrN);
            this.Controls.Add(this.numZrMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numZrMax);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(20, 16, 20, 16);
            this.Name = "MCDcMetallLineUI";
            this.Text = "MCAcFilterUI";
            this.Load += new System.EventHandler(this.MCDcMetalLineUI_Load);
            this.Controls.SetChildIndex(this.btnApply, 0);
            this.Controls.SetChildIndex(this.grpBoxDevice, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.numZrMax, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.numZrMin, 0);
            this.Controls.SetChildIndex(this.numZrN, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cboStation1, 0);
            this.Controls.SetChildIndex(this.cboStation2, 0);
            this.Controls.SetChildIndex(this.btnAddLine, 0);
            this.Controls.SetChildIndex(this.btnRemove, 0);
            this.grpBoxDevice.ResumeLayout(false);
            this.grpBoxDevice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZrMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZrMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZrN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numZrMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numZrMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numZrN;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ComboBox cboStation2;
        protected System.Windows.Forms.ComboBox cboStation1;
        private DevComponents.DotNetBar.ButtonX btnAddLine;
        private DevComponents.DotNetBar.ButtonX btnRemove;
    }
}