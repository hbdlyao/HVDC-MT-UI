namespace cn.csg.dpcp.ui.mc
{
    partial class CmcUIBase
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
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnApply = new DevComponents.DotNetBar.ButtonX();
            this.grpBoxDevice = new System.Windows.Forms.GroupBox();
            this.cboDeviceID = new System.Windows.Forms.ComboBox();
            this.lblDeviceID = new System.Windows.Forms.Label();
            this.grpBoxDevice.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(522, 471);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnApply
            // 
            this.btnApply.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnApply.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnApply.Location = new System.Drawing.Point(424, 471);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "应用";
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // grpBoxDevice
            // 
            this.grpBoxDevice.Controls.Add(this.cboDeviceID);
            this.grpBoxDevice.Controls.Add(this.lblDeviceID);
            this.grpBoxDevice.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpBoxDevice.Location = new System.Drawing.Point(10, 5);
            this.grpBoxDevice.Name = "grpBoxDevice";
            this.grpBoxDevice.Size = new System.Drawing.Size(738, 51);
            this.grpBoxDevice.TabIndex = 1;
            this.grpBoxDevice.TabStop = false;
            this.grpBoxDevice.Text = "设备";
            // 
            // cboDeviceID
            // 
            this.cboDeviceID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeviceID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDeviceID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboDeviceID.FormattingEnabled = true;
            this.cboDeviceID.Location = new System.Drawing.Point(66, 20);
            this.cboDeviceID.Name = "cboDeviceID";
            this.cboDeviceID.Size = new System.Drawing.Size(102, 20);
            this.cboDeviceID.TabIndex = 2;
            this.cboDeviceID.SelectedIndexChanged += new System.EventHandler(this.cboDeviceID_SelectedIndexChanged);
            // 
            // lblDeviceID
            // 
            this.lblDeviceID.AutoSize = true;
            this.lblDeviceID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDeviceID.Location = new System.Drawing.Point(6, 26);
            this.lblDeviceID.Name = "lblDeviceID";
            this.lblDeviceID.Size = new System.Drawing.Size(53, 12);
            this.lblDeviceID.TabIndex = 5;
            this.lblDeviceID.Text = "设备名称";
            // 
            // MCBaseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 500);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.grpBoxDevice);
            this.Name = "MCBaseUI";
            this.Text = "MCCAcSystemUI";
            this.Load += new System.EventHandler(this.CmcUIBase_Load);
            this.grpBoxDevice.ResumeLayout(false);
            this.grpBoxDevice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDeviceID;
        protected System.Windows.Forms.GroupBox grpBoxDevice;
        protected System.Windows.Forms.ComboBox cboDeviceID;
        private DevComponents.DotNetBar.ButtonX btnSave;
        protected DevComponents.DotNetBar.ButtonX btnApply;
    }
}