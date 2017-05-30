namespace cn.csg.dpcp.ui.mc
{
    partial class MCBaseUI
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
            this.grpBoxDevice = new System.Windows.Forms.GroupBox();
            this.txtStationName = new System.Windows.Forms.TextBox();
            this.lblStationName = new System.Windows.Forms.Label();
            this.cboDeviceID = new System.Windows.Forms.ComboBox();
            this.lblDeviceID = new System.Windows.Forms.Label();
            this.lblDeviceType = new System.Windows.Forms.Label();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.txtDeviceType = new System.Windows.Forms.TextBox();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.grpBoxDevice.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxDevice
            // 
            this.grpBoxDevice.Controls.Add(this.txtStationName);
            this.grpBoxDevice.Controls.Add(this.lblStationName);
            this.grpBoxDevice.Controls.Add(this.cboDeviceID);
            this.grpBoxDevice.Controls.Add(this.lblDeviceID);
            this.grpBoxDevice.Controls.Add(this.lblDeviceType);
            this.grpBoxDevice.Controls.Add(this.lblDeviceName);
            this.grpBoxDevice.Controls.Add(this.txtDeviceType);
            this.grpBoxDevice.Controls.Add(this.txtDeviceName);
            this.grpBoxDevice.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpBoxDevice.Location = new System.Drawing.Point(10, 5);
            this.grpBoxDevice.Name = "grpBoxDevice";
            this.grpBoxDevice.Size = new System.Drawing.Size(738, 51);
            this.grpBoxDevice.TabIndex = 1;
            this.grpBoxDevice.TabStop = false;
            this.grpBoxDevice.Text = "设备";
            // 
            // txtStationName
            // 
            this.txtStationName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStationName.Location = new System.Drawing.Point(573, 20);
            this.txtStationName.Name = "txtStationName";
            this.txtStationName.Size = new System.Drawing.Size(159, 21);
            this.txtStationName.TabIndex = 6;
            this.txtStationName.Visible = false;
            // 
            // lblStationName
            // 
            this.lblStationName.AutoSize = true;
            this.lblStationName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStationName.Location = new System.Drawing.Point(538, 26);
            this.lblStationName.Name = "lblStationName";
            this.lblStationName.Size = new System.Drawing.Size(29, 12);
            this.lblStationName.TabIndex = 6;
            this.lblStationName.Text = "站名";
            this.lblStationName.Visible = false;
            // 
            // cboDeviceID
            // 
            this.cboDeviceID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeviceID.FormattingEnabled = true;
            this.cboDeviceID.Location = new System.Drawing.Point(47, 20);
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
            this.lblDeviceID.Size = new System.Drawing.Size(41, 12);
            this.lblDeviceID.TabIndex = 5;
            this.lblDeviceID.Text = "设备ID";
            // 
            // lblDeviceType
            // 
            this.lblDeviceType.AutoSize = true;
            this.lblDeviceType.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDeviceType.Location = new System.Drawing.Point(374, 26);
            this.lblDeviceType.Name = "lblDeviceType";
            this.lblDeviceType.Size = new System.Drawing.Size(53, 12);
            this.lblDeviceType.TabIndex = 4;
            this.lblDeviceType.Text = "设备类型";
            this.lblDeviceType.Visible = false;
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDeviceName.Location = new System.Drawing.Point(166, 26);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(53, 12);
            this.lblDeviceName.TabIndex = 3;
            this.lblDeviceName.Text = "设备名称";
            this.lblDeviceName.Visible = false;
            // 
            // txtDeviceType
            // 
            this.txtDeviceType.BackColor = System.Drawing.Color.White;
            this.txtDeviceType.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDeviceType.Location = new System.Drawing.Point(433, 20);
            this.txtDeviceType.Name = "txtDeviceType";
            this.txtDeviceType.Size = new System.Drawing.Size(87, 21);
            this.txtDeviceType.TabIndex = 3;
            this.txtDeviceType.Visible = false;
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDeviceName.Location = new System.Drawing.Point(225, 20);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(132, 21);
            this.txtDeviceName.TabIndex = 2;
            this.txtDeviceName.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(612, 471);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(531, 471);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "应用";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // MCBaseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 500);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpBoxDevice);
            this.Name = "MCBaseUI";
            this.Text = "MCCAcSystemUI";
            this.Load += new System.EventHandler(this.MCBaseUI_Load);
            this.grpBoxDevice.ResumeLayout(false);
            this.grpBoxDevice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDeviceType;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.Label lblDeviceID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblStationName;
        protected System.Windows.Forms.GroupBox grpBoxDevice;
        protected System.Windows.Forms.TextBox txtStationName;
        protected System.Windows.Forms.TextBox txtDeviceType;
        protected System.Windows.Forms.TextBox txtDeviceName;
        protected System.Windows.Forms.ComboBox cboDeviceID;
        private System.Windows.Forms.Button btnApply;
    }
}