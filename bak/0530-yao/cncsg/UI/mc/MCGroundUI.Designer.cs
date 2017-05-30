namespace cn.csg.dpcp.ui.mc
{
    partial class MCGroundUI
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
            this.numZr = new System.Windows.Forms.NumericUpDown();
            this.grpBoxDevice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "电阻(Ω)";
            // 
            // numZr
            // 
            this.numZr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numZr.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numZr.Location = new System.Drawing.Point(90, 79);
            this.numZr.Name = "numZr";
            this.numZr.Size = new System.Drawing.Size(120, 17);
            this.numZr.TabIndex = 7;
            // 
            // MCGroundUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 500);
            this.Controls.Add(this.numZr);
            this.Controls.Add(this.label1);
            this.Name = "MCGroundUI";
            this.Text = "MCGroundUI";
            this.Load += new System.EventHandler(this.MCGroundUI_Load);
            this.Controls.SetChildIndex(this.grpBoxDevice, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.numZr, 0);
            this.grpBoxDevice.ResumeLayout(false);
            this.grpBoxDevice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numZr;
    }
}