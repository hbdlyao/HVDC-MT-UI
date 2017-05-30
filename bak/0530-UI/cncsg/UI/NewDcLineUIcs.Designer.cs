namespace cn.csg.dpcp.ui
{
    partial class NewDcLineUIcs
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
            this.txtStation1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtStation2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnEnter = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLineName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // txtStation1
            // 
            // 
            // 
            // 
            this.txtStation1.Border.Class = "TextBoxBorder";
            this.txtStation1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStation1.Location = new System.Drawing.Point(88, 61);
            this.txtStation1.Name = "txtStation1";
            this.txtStation1.PreventEnterBeep = true;
            this.txtStation1.Size = new System.Drawing.Size(100, 21);
            this.txtStation1.TabIndex = 0;
            // 
            // txtStation2
            // 
            // 
            // 
            // 
            this.txtStation2.Border.Class = "TextBoxBorder";
            this.txtStation2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStation2.Location = new System.Drawing.Point(351, 61);
            this.txtStation2.Name = "txtStation2";
            this.txtStation2.PreventEnterBeep = true;
            this.txtStation2.Size = new System.Drawing.Size(100, 21);
            this.txtStation2.TabIndex = 1;
            // 
            // btnEnter
            // 
            this.btnEnter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEnter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEnter.Location = new System.Drawing.Point(275, 199);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "确定";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(376, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "首端换流站";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "末端换流站";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
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
            this.txtLineName.Location = new System.Drawing.Point(88, 20);
            this.txtLineName.Name = "txtLineName";
            this.txtLineName.PreventEnterBeep = true;
            this.txtLineName.Size = new System.Drawing.Size(100, 21);
            this.txtLineName.TabIndex = 6;
            // 
            // NewDcLineUIcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(480, 234);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLineName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtStation2);
            this.Controls.Add(this.txtStation1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "NewDcLineUIcs";
            this.Text = "直流线路";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtStation1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStation2;
        private DevComponents.DotNetBar.ButtonX btnEnter;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLineName;
        private System.Windows.Forms.Label label3;
    }
}