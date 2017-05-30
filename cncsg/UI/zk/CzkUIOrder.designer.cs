namespace cn.csg.dpcp.ui.zk
{
    partial class CzkUIOrder
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk12Count = new System.Windows.Forms.CheckBox();
            this.num12Count = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkRdN = new System.Windows.Forms.CheckBox();
            this.chkRdL = new System.Windows.Forms.CheckBox();
            this.chkDcHZr = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkSMetal = new System.Windows.Forms.CheckBox();
            this.chkDRun = new System.Windows.Forms.CheckBox();
            this.chkSGround = new System.Windows.Forms.CheckBox();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.radXn = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numFreqDim = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numFreqStep = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numFreqStat = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstPort = new System.Windows.Forms.ListBox();
            this.btnApply = new DevComponents.DotNetBar.ButtonX();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num12Count)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.radXn.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFreqDim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFreqStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFreqStat)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk12Count);
            this.groupBox2.Controls.Add(this.num12Count);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 67);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "每极12脉动数选择";
            // 
            // chk12Count
            // 
            this.chk12Count.AutoSize = true;
            this.chk12Count.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chk12Count.Location = new System.Drawing.Point(15, 20);
            this.chk12Count.Name = "chk12Count";
            this.chk12Count.Size = new System.Drawing.Size(132, 16);
            this.chk12Count.TabIndex = 8;
            this.chk12Count.Text = "12脉动中间是否接地";
            this.chk12Count.UseVisualStyleBackColor = true;
            // 
            // num12Count
            // 
            this.num12Count.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.num12Count.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num12Count.Location = new System.Drawing.Point(108, 43);
            this.num12Count.Name = "num12Count";
            this.num12Count.Size = new System.Drawing.Size(120, 17);
            this.num12Count.TabIndex = 2;
            this.num12Count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "每极12脉动组数";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkRdN);
            this.groupBox3.Controls.Add(this.chkRdL);
            this.groupBox3.Controls.Add(this.chkDcHZr);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(12, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 91);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "直流线路电阻计算选择";
            // 
            // chkRdN
            // 
            this.chkRdN.AutoSize = true;
            this.chkRdN.Location = new System.Drawing.Point(15, 63);
            this.chkRdN.Name = "chkRdN";
            this.chkRdN.Size = new System.Drawing.Size(96, 16);
            this.chkRdN.TabIndex = 9;
            this.chkRdN.Text = "直流线路额定";
            this.chkRdN.UseVisualStyleBackColor = true;
            // 
            // chkRdL
            // 
            this.chkRdL.AutoSize = true;
            this.chkRdL.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkRdL.Location = new System.Drawing.Point(15, 41);
            this.chkRdL.Name = "chkRdL";
            this.chkRdL.Size = new System.Drawing.Size(96, 16);
            this.chkRdL.TabIndex = 8;
            this.chkRdL.Text = "直流线路低阻";
            this.chkRdL.UseVisualStyleBackColor = true;
            // 
            // chkDcHZr
            // 
            this.chkDcHZr.AutoSize = true;
            this.chkDcHZr.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkDcHZr.Location = new System.Drawing.Point(15, 19);
            this.chkDcHZr.Name = "chkDcHZr";
            this.chkDcHZr.Size = new System.Drawing.Size(96, 16);
            this.chkDcHZr.TabIndex = 7;
            this.chkDcHZr.Text = "直流线路高阻";
            this.chkDcHZr.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkSMetal);
            this.groupBox6.Controls.Add(this.chkDRun);
            this.groupBox6.Controls.Add(this.chkSGround);
            this.groupBox6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.Location = new System.Drawing.Point(383, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(365, 46);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "扫描模式计算选择";
            // 
            // chkSMetal
            // 
            this.chkSMetal.AutoSize = true;
            this.chkSMetal.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkSMetal.Location = new System.Drawing.Point(14, 22);
            this.chkSMetal.Name = "chkSMetal";
            this.chkSMetal.Size = new System.Drawing.Size(72, 16);
            this.chkSMetal.TabIndex = 9;
            this.chkSMetal.Text = "单极金属";
            this.chkSMetal.UseVisualStyleBackColor = true;
            // 
            // chkDRun
            // 
            this.chkDRun.AutoSize = true;
            this.chkDRun.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkDRun.Location = new System.Drawing.Point(269, 22);
            this.chkDRun.Name = "chkDRun";
            this.chkDRun.Size = new System.Drawing.Size(72, 16);
            this.chkDRun.TabIndex = 7;
            this.chkDRun.Text = "双极运行";
            this.chkDRun.UseVisualStyleBackColor = true;
            // 
            // chkSGround
            // 
            this.chkSGround.AutoSize = true;
            this.chkSGround.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkSGround.Location = new System.Drawing.Point(145, 22);
            this.chkSGround.Name = "chkSGround";
            this.chkSGround.Size = new System.Drawing.Size(72, 16);
            this.chkSGround.TabIndex = 8;
            this.chkSGround.Text = "单极大地";
            this.chkSGround.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(683, 450);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(61, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "保存";
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstOrder
            // 
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.ItemHeight = 12;
            this.lstOrder.Location = new System.Drawing.Point(6, 20);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(353, 352);
            this.lstOrder.TabIndex = 17;
            // 
            // radXn
            // 
            this.radXn.Controls.Add(this.lstOrder);
            this.radXn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radXn.Location = new System.Drawing.Point(383, 65);
            this.radXn.Name = "radXn";
            this.radXn.Size = new System.Drawing.Size(365, 379);
            this.radXn.TabIndex = 18;
            this.radXn.TabStop = false;
            this.radXn.Text = "工选择况";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numFreqDim);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numFreqStep);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numFreqStat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 97);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "扫描频率";
            // 
            // numFreqDim
            // 
            this.numFreqDim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numFreqDim.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numFreqDim.Location = new System.Drawing.Point(72, 43);
            this.numFreqDim.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numFreqDim.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numFreqDim.Name = "numFreqDim";
            this.numFreqDim.Size = new System.Drawing.Size(120, 17);
            this.numFreqDim.TabIndex = 8;
            this.numFreqDim.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(13, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "计算数量";
            // 
            // numFreqStep
            // 
            this.numFreqStep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numFreqStep.DecimalPlaces = 2;
            this.numFreqStep.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numFreqStep.Location = new System.Drawing.Point(72, 69);
            this.numFreqStep.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numFreqStep.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numFreqStep.Name = "numFreqStep";
            this.numFreqStep.Size = new System.Drawing.Size(120, 17);
            this.numFreqStep.TabIndex = 6;
            this.numFreqStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "频率步长";
            // 
            // numFreqStat
            // 
            this.numFreqStat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numFreqStat.DecimalPlaces = 2;
            this.numFreqStat.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numFreqStat.Location = new System.Drawing.Point(72, 17);
            this.numFreqStat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numFreqStat.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numFreqStat.Name = "numFreqStat";
            this.numFreqStat.Size = new System.Drawing.Size(120, 17);
            this.numFreqStat.TabIndex = 4;
            this.numFreqStat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(13, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "开始频率";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstPort);
            this.groupBox4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(12, 285);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(365, 152);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "端口选择";
            // 
            // lstPort
            // 
            this.lstPort.FormattingEnabled = true;
            this.lstPort.ItemHeight = 12;
            this.lstPort.Location = new System.Drawing.Point(6, 20);
            this.lstPort.Name = "lstPort";
            this.lstPort.Size = new System.Drawing.Size(353, 124);
            this.lstPort.TabIndex = 18;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(599, 450);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(61, 23);
            this.btnApply.TabIndex = 21;
            this.btnApply.Text = "应用";
            this.btnApply.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            // 
            // CzkOrderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 478);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radXn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "CzkOrderUI";
            this.Text = "计算方式";
            this.Load += new System.EventHandler(this.CzkOrderUI_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num12Count)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.radXn.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFreqDim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFreqStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFreqStat)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkRdL;
        private System.Windows.Forms.CheckBox chkDcHZr;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chkDRun;
        private System.Windows.Forms.CheckBox chkSMetal;
        private System.Windows.Forms.CheckBox chkSGround;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num12Count;
        private System.Windows.Forms.CheckBox chkRdN;
        private System.Windows.Forms.CheckBox chk12Count;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.GroupBox radXn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numFreqDim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numFreqStep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numFreqStat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstPort;
        private DevComponents.DotNetBar.ButtonX btnApply;
    }
}