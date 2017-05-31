namespace cn.csg.dpcp.ui
{
    partial class CDlgNewDCLine
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
            this.btnEnter = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLineName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cboStation2 = new System.Windows.Forms.ComboBox();
            this.cboStation1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEnter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEnter.Location = new System.Drawing.Point(508, 57);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(138, 40);
            this.btnEnter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "确定";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(508, 200);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 40);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "线路名称";
            // 
            // txtLineName
            // 
            // 
            // 
            // 
            this.txtLineName.Border.Class = "TextBoxBorder";
            this.txtLineName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLineName.Location = new System.Drawing.Point(212, 37);
            this.txtLineName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtLineName.Name = "txtLineName";
            this.txtLineName.PreventEnterBeep = true;
            this.txtLineName.Size = new System.Drawing.Size(183, 31);
            this.txtLineName.TabIndex = 6;
            // 
            // cboStation2
            // 
            this.cboStation2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStation2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStation2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboStation2.FormattingEnabled = true;
            this.cboStation2.Location = new System.Drawing.Point(212, 200);
            this.cboStation2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cboStation2.Name = "cboStation2";
            this.cboStation2.Size = new System.Drawing.Size(184, 29);
            this.cboStation2.TabIndex = 35;
            // 
            // cboStation1
            // 
            this.cboStation1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStation1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStation1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboStation1.FormattingEnabled = true;
            this.cboStation1.Location = new System.Drawing.Point(212, 125);
            this.cboStation1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cboStation1.Name = "cboStation1";
            this.cboStation1.Size = new System.Drawing.Size(184, 29);
            this.cboStation1.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(51, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "末端换流站";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(51, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 32;
            this.label5.Text = "首端换流站";
            // 
            // CDlgNewDCLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(666, 294);
            this.Controls.Add(this.cboStation2);
            this.Controls.Add(this.cboStation1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLineName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "CDlgNewDCLine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "直流线路";
            this.Load += new System.EventHandler(this.CDlgNewDCLine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX btnEnter;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLineName;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.ComboBox cboStation2;
        protected System.Windows.Forms.ComboBox cboStation1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}