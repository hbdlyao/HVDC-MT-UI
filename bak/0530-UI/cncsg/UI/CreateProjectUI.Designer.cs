namespace cn.csg.dpcp.ui
{
    partial class CreateProjectUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtProjectName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.btnRemove = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboStationType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStationName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.lstStation = new System.Windows.Forms.ListView();
            this.btnModify = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCtrlType = new System.Windows.Forms.ComboBox();
            this.colSeq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStationName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStationType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCtrlType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(403, 227);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "确定";
            this.btnEnter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "工程名称";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(71, 23);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(144, 21);
            this.txtProjectName.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(403, 41);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "添加";
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(403, 103);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "删除选择";
            this.btnRemove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboCtrlType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboStationType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtStationName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(15, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 119);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "换流站信息";
            // 
            // cboStationType
            // 
            this.cboStationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStationType.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboStationType.FormattingEnabled = true;
            this.cboStationType.Items.AddRange(new object[] {
            "整流",
            "逆变"});
            this.cboStationType.Location = new System.Drawing.Point(100, 53);
            this.cboStationType.Name = "cboStationType";
            this.cboStationType.Size = new System.Drawing.Size(179, 20);
            this.cboStationType.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(17, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "换流站类型";
            // 
            // txtStationName
            // 
            this.txtStationName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStationName.Location = new System.Drawing.Point(100, 23);
            this.txtStationName.Name = "txtStationName";
            this.txtStationName.Size = new System.Drawing.Size(179, 21);
            this.txtStationName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(17, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "换流站名称";
            // 
            // lstStation
            // 
            this.lstStation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSeq,
            this.colStationName,
            this.colStationType,
            this.colCtrlType});
            this.lstStation.FullRowSelect = true;
            this.lstStation.Location = new System.Drawing.Point(15, 196);
            this.lstStation.Name = "lstStation";
            this.lstStation.Size = new System.Drawing.Size(354, 183);
            this.lstStation.TabIndex = 0;
            this.lstStation.UseCompatibleStateImageBehavior = false;
            this.lstStation.View = System.Windows.Forms.View.Details;
            this.lstStation.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstStation_ItemSelectionChanged);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(403, 165);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 10;
            this.btnModify.Text = "更新选择";
            this.btnModify.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(403, 289);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取消";
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(17, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "控制类型";
            // 
            // cboCtrlType
            // 
            this.cboCtrlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCtrlType.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboCtrlType.FormattingEnabled = true;
            this.cboCtrlType.Items.AddRange(new object[] {
            "定功率",
            "定电压",
            "定角度",
            "定电流",
            "电流跟随"});
            this.cboCtrlType.Location = new System.Drawing.Point(100, 82);
            this.cboCtrlType.Name = "cboCtrlType";
            this.cboCtrlType.Size = new System.Drawing.Size(179, 20);
            this.cboCtrlType.TabIndex = 9;
            // 
            // colSeq
            // 
            this.colSeq.Text = "序号";
            this.colSeq.Width = 40;
            // 
            // colStationName
            // 
            this.colStationName.Text = "换流站名称";
            this.colStationName.Width = 140;
            // 
            // colStationType
            // 
            this.colStationType.Text = "换流站类型";
            this.colStationType.Width = 80;
            // 
            // colCtrlType
            // 
            this.colCtrlType.Text = "控制类型";
            // 
            // CreateProjectUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 391);
            this.Controls.Add(this.lstStation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEnter);
            this.MaximizeBox = false;
            this.Name = "CreateProjectUI";
            this.Text = "新建换流站";
            this.Load += new System.EventHandler(this.CreateProjectUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX btnEnter;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProjectName;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.ButtonX btnRemove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboStationType;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStationName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstStation;
        private DevComponents.DotNetBar.ButtonX btnModify;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private System.Windows.Forms.ComboBox cboCtrlType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader colSeq;
        private System.Windows.Forms.ColumnHeader colStationName;
        private System.Windows.Forms.ColumnHeader colStationType;
        private System.Windows.Forms.ColumnHeader colCtrlType;
    }
}