namespace cn.csg.dpcp.ui.zk
{
    partial class CzkTxBaseUI
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
            this.radF1 = new System.Windows.Forms.RadioButton();
            this.lstF1 = new System.Windows.Forms.ListBox();
            this.lstF2 = new System.Windows.Forms.ListBox();
            this.radF2 = new System.Windows.Forms.RadioButton();
            this.grpFparam = new System.Windows.Forms.GroupBox();
            this.grpTxCount = new System.Windows.Forms.GroupBox();
            this.radTxTwo = new System.Windows.Forms.RadioButton();
            this.radTxThree = new System.Windows.Forms.RadioButton();
            this.radXtOnw = new System.Windows.Forms.RadioButton();
            this.pnlTx = new System.Windows.Forms.Panel();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.grpFparam.SuspendLayout();
            this.grpTxCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // radF1
            // 
            this.radF1.AutoSize = true;
            this.radF1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radF1.Location = new System.Drawing.Point(6, 18);
            this.radF1.Name = "radF1";
            this.radF1.Size = new System.Drawing.Size(35, 16);
            this.radF1.TabIndex = 0;
            this.radF1.TabStop = true;
            this.radF1.Text = "F1";
            this.radF1.UseVisualStyleBackColor = true;
            // 
            // lstF1
            // 
            this.lstF1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstF1.FormattingEnabled = true;
            this.lstF1.ItemHeight = 12;
            this.lstF1.Location = new System.Drawing.Point(6, 40);
            this.lstF1.Name = "lstF1";
            this.lstF1.Size = new System.Drawing.Size(158, 88);
            this.lstF1.TabIndex = 1;
            // 
            // lstF2
            // 
            this.lstF2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstF2.FormattingEnabled = true;
            this.lstF2.ItemHeight = 12;
            this.lstF2.Location = new System.Drawing.Point(6, 172);
            this.lstF2.Name = "lstF2";
            this.lstF2.Size = new System.Drawing.Size(158, 88);
            this.lstF2.TabIndex = 3;
            // 
            // radF2
            // 
            this.radF2.AutoSize = true;
            this.radF2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radF2.Location = new System.Drawing.Point(6, 150);
            this.radF2.Name = "radF2";
            this.radF2.Size = new System.Drawing.Size(35, 16);
            this.radF2.TabIndex = 2;
            this.radF2.TabStop = true;
            this.radF2.Text = "F2";
            this.radF2.UseVisualStyleBackColor = true;
            // 
            // grpFparam
            // 
            this.grpFparam.Controls.Add(this.lstF1);
            this.grpFparam.Controls.Add(this.lstF2);
            this.grpFparam.Controls.Add(this.radF2);
            this.grpFparam.Controls.Add(this.radF1);
            this.grpFparam.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpFparam.Location = new System.Drawing.Point(12, 12);
            this.grpFparam.Name = "grpFparam";
            this.grpFparam.Size = new System.Drawing.Size(170, 278);
            this.grpFparam.TabIndex = 4;
            this.grpFparam.TabStop = false;
            this.grpFparam.Text = "参数";
            // 
            // grpTxCount
            // 
            this.grpTxCount.Controls.Add(this.radTxTwo);
            this.grpTxCount.Controls.Add(this.radTxThree);
            this.grpTxCount.Controls.Add(this.radXtOnw);
            this.grpTxCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpTxCount.Location = new System.Drawing.Point(188, 12);
            this.grpTxCount.Name = "grpTxCount";
            this.grpTxCount.Size = new System.Drawing.Size(431, 52);
            this.grpTxCount.TabIndex = 5;
            this.grpTxCount.TabStop = false;
            this.grpTxCount.Text = "滤波器设置";
            // 
            // radTxTwo
            // 
            this.radTxTwo.AutoSize = true;
            this.radTxTwo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radTxTwo.Location = new System.Drawing.Point(126, 20);
            this.radTxTwo.Name = "radTxTwo";
            this.radTxTwo.Size = new System.Drawing.Size(59, 16);
            this.radTxTwo.TabIndex = 6;
            this.radTxTwo.TabStop = true;
            this.radTxTwo.Text = "双调谐";
            this.radTxTwo.UseVisualStyleBackColor = true;
            this.radTxTwo.CheckedChanged += new System.EventHandler(this.radTxTwo_CheckedChanged);
            // 
            // radTxThree
            // 
            this.radTxThree.AutoSize = true;
            this.radTxThree.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radTxThree.Location = new System.Drawing.Point(240, 20);
            this.radTxThree.Name = "radTxThree";
            this.radTxThree.Size = new System.Drawing.Size(59, 16);
            this.radTxThree.TabIndex = 5;
            this.radTxThree.TabStop = true;
            this.radTxThree.Text = "三调谐";
            this.radTxThree.UseVisualStyleBackColor = true;
            this.radTxThree.CheckedChanged += new System.EventHandler(this.radTxThree_CheckedChanged);
            // 
            // radXtOnw
            // 
            this.radXtOnw.AutoSize = true;
            this.radXtOnw.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radXtOnw.Location = new System.Drawing.Point(6, 20);
            this.radXtOnw.Name = "radXtOnw";
            this.radXtOnw.Size = new System.Drawing.Size(59, 16);
            this.radXtOnw.TabIndex = 4;
            this.radXtOnw.TabStop = true;
            this.radXtOnw.Text = "单调谐";
            this.radXtOnw.UseVisualStyleBackColor = true;
            this.radXtOnw.CheckedChanged += new System.EventHandler(this.radXtOnw_CheckedChanged);
            // 
            // pnlTx
            // 
            this.pnlTx.Location = new System.Drawing.Point(188, 70);
            this.pnlTx.Name = "pnlTx";
            this.pnlTx.Size = new System.Drawing.Size(580, 418);
            this.pnlTx.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(18, 465);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CzkTxBaseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 500);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlTx);
            this.Controls.Add(this.grpTxCount);
            this.Controls.Add(this.grpFparam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CzkTxBaseUI";
            this.Text = "CzkXtBaseUI";
            this.grpFparam.ResumeLayout(false);
            this.grpFparam.PerformLayout();
            this.grpTxCount.ResumeLayout(false);
            this.grpTxCount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radF1;
        private System.Windows.Forms.ListBox lstF1;
        private System.Windows.Forms.ListBox lstF2;
        private System.Windows.Forms.RadioButton radF2;
        private System.Windows.Forms.GroupBox grpFparam;
        private System.Windows.Forms.GroupBox grpTxCount;
        private System.Windows.Forms.RadioButton radXtOnw;
        private System.Windows.Forms.RadioButton radTxTwo;
        private System.Windows.Forms.RadioButton radTxThree;
        private System.Windows.Forms.Panel pnlTx;
        private DevComponents.DotNetBar.ButtonX btnSave;
    }
}