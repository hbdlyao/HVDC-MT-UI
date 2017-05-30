namespace cn.csg.dpcp.ui.mc
{
    partial class MCDcFilterUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.numDcfType = new System.Windows.Forms.NumericUpDown();
            this.numZc = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numZx = new System.Windows.Forms.NumericUpDown();
            this.电抗 = new System.Windows.Forms.Label();
            this.numZr = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDcfType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "交流滤波器类型（单调谐/双调谐）";
            // 
            // numDcfType
            // 
            this.numDcfType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numDcfType.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numDcfType.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDcfType.Location = new System.Drawing.Point(214, 79);
            this.numDcfType.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDcfType.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numDcfType.Name = "numDcfType";
            this.numDcfType.Size = new System.Drawing.Size(120, 17);
            this.numDcfType.TabIndex = 7;
            // 
            // numZc
            // 
            this.numZc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numZc.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numZc.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numZc.Location = new System.Drawing.Point(578, 79);
            this.numZc.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numZc.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numZc.Name = "numZc";
            this.numZc.Size = new System.Drawing.Size(120, 17);
            this.numZc.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(384, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "电容";
            // 
            // numZx
            // 
            this.numZx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numZx.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numZx.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numZx.Location = new System.Drawing.Point(578, 112);
            this.numZx.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numZx.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numZx.Name = "numZx";
            this.numZx.Size = new System.Drawing.Size(120, 17);
            this.numZx.TabIndex = 19;
            // 
            // 电抗
            // 
            this.电抗.AutoSize = true;
            this.电抗.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.电抗.Location = new System.Drawing.Point(384, 114);
            this.电抗.Name = "电抗";
            this.电抗.Size = new System.Drawing.Size(29, 12);
            this.电抗.TabIndex = 18;
            this.电抗.Text = "电抗";
            // 
            // numZr
            // 
            this.numZr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numZr.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numZr.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numZr.Location = new System.Drawing.Point(214, 112);
            this.numZr.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numZr.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numZr.Name = "numZr";
            this.numZr.Size = new System.Drawing.Size(120, 17);
            this.numZr.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(8, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "电阻";
            // 
            // MCDcFilterUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 500);
            this.Controls.Add(this.numZx);
            this.Controls.Add(this.电抗);
            this.Controls.Add(this.numZr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numZc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numDcfType);
            this.Controls.Add(this.label1);
            this.Name = "MCDcFilterUI";
            this.Text = "MCAcFilterUI";
            this.Load += new System.EventHandler(this.MCDcFilterUI_Load);
            this.Controls.SetChildIndex(this.grpBoxDevice, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.numDcfType, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.numZc, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.numZr, 0);
            this.Controls.SetChildIndex(this.电抗, 0);
            this.Controls.SetChildIndex(this.numZx, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numDcfType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numDcfType;
        private System.Windows.Forms.NumericUpDown numZc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numZx;
        private System.Windows.Forms.Label 电抗;
        private System.Windows.Forms.NumericUpDown numZr;
        private System.Windows.Forms.Label label8;
    }
}