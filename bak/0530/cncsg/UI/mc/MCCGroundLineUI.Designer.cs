namespace cn.csg.dpcp.ui.mc
{
    partial class MCCGroundLineUI
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
            this.numZrMin = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numZrMax = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numZrN = new System.Windows.Forms.NumericUpDown();
            this.grpBoxDevice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZrMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZrMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZrN)).BeginInit();
            this.SuspendLayout();
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
            this.numZrMin.Location = new System.Drawing.Point(573, 91);
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
            this.numZrMin.Size = new System.Drawing.Size(120, 17);
            this.numZrMin.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(441, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
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
            this.numZrMax.Location = new System.Drawing.Point(235, 85);
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
            this.numZrMax.Size = new System.Drawing.Size(120, 17);
            this.numZrMax.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(70, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "电阻最大值(Ω)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(70, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "电阻额定值(Ω)";
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
            this.numZrN.Location = new System.Drawing.Point(235, 118);
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
            this.numZrN.Size = new System.Drawing.Size(120, 17);
            this.numZrN.TabIndex = 26;
            // 
            // MCCGroundLineUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numZrN);
            this.Controls.Add(this.numZrMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numZrMax);
            this.Controls.Add(this.label7);
            this.Name = "MCCGroundLineUI";
            this.Text = "MCAcFilterUI";
            this.Load += new System.EventHandler(this.MCCGroundLineUI_Load);
            this.Controls.SetChildIndex(this.grpBoxDevice, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.numZrMax, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.numZrMin, 0);
            this.Controls.SetChildIndex(this.numZrN, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.grpBoxDevice.ResumeLayout(false);
            this.grpBoxDevice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZrMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZrMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZrN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numZrMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numZrMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numZrN;
    }
}