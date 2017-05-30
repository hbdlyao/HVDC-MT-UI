using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cn.csg.dpcp.model.vo;

using Yao.BaseFrame.Device;
using Yao.BaseFrame.DevTBL;
using Hvdc.MT.Project.App;
using Hvdc.MT.U3p.Device;

namespace cn.csg.dpcp.ui
{
    public class DpcpBaseForm : Form
    {
        protected CDevGrid DevGrid = null;
        protected CDevTBL DevTbl = null;
        protected CDevStation DevStation = null;
        protected CDevBase Device = null;

        // 当前页面设备映射
        protected IDictionary<string, CDevBase> deviceMap = new Dictionary<string, CDevBase>();
        // 当前页面换流站映射
        protected IDictionary<string, CDevStation> stationMap = new Dictionary<string, CDevStation>();
        protected int deviceType = -1;
        protected int tblType = -1;
        protected int gridType = -1;

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
            this.SuspendLayout();
            // 
            // DpcpBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1115, 540);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DpcpBaseForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);

        }

        #endregion

        public DpcpBaseForm()
        {
            InitializeComponent();
        }

        public DpcpBaseForm(CDevGrid vGrid, int vGridType, int vTblType)
        {
            InitializeComponent();
            InitForm(vGrid, vGridType, vTblType);
        }

        public void InitForm(CDevGrid vGrid, int vGridType, int vTblType)
        {
            gridType = vGridType;
            tblType = vTblType;
            DevGrid = vGrid;

            //DevTbl = DevGrid.DeviceTBL(vTblType);


        }

        /// <summary>
        /// 初始化站点
        /// </summary>
        /// <param name="box"></param>
        public virtual void FillComboxFromDevice(ComboBox box)
        {
            box.Items.Clear();
            deviceMap.Clear();
            stationMap.Clear();

            DevTbl = DevGrid.DeviceTBL(tblType);
            foreach (CDevBase dev in DevTbl.Children())
            {
                box.Items.Add(dev.StationNames[0]);
                deviceMap.Add(dev.StationNames[0], dev);
            }
            if (box.Items.Count > 0)
            {
                box.SelectedIndex = 0;
            }
        }

        protected void FillComboxFromStation(ComboBox box)
        {
            box.Items.Clear();
            stationMap.Clear();
            deviceMap.Clear();
            foreach (var station in DevGrid.Stations())
            {
                box.Items.Add(station.Key);
                stationMap.Add(station.Key, station.Value);
            }
            if (box.Items.Count > 0)
            {
                box.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 获取下拉框的选择文本
        /// </summary>
        /// <param name="box"></param>
        /// <returns></returns>
        protected string GetComboxSelectedText(ComboBox box)
        {
            if (box.SelectedText == null || string.Empty.Equals(box.SelectedText))
            {
                return box.Text;
            }
            return box.SelectedText;
        }

        protected void OnStationChanged(ComboBox box)
        {
            string vName = GetComboxSelectedText(box);
            DevStation = stationMap[vName];

            DevTbl = DevStation.DeviceTBL(tblType);

            OnClear();

            OnLoadStation();

            //AddToDevMap();
        }

        protected virtual void OnDeviceChanged(ComboBox box)
        {
            string vName = GetComboxSelectedText(box);
            Device = deviceMap[vName];

            OnClear();

            OnLoadDevice();
            
        }

        protected virtual void AddToDevMap()
        {
            deviceMap.Clear();
            foreach (CDevBase vDev in DevTbl.Children())
            {
                deviceMap.Add(vDev.DeviceName, vDev);
            }
        }

        protected virtual void OnClear()
        {
            
        }


        protected virtual void OnLoadStation()
        {

        }


        protected virtual void OnLoadDevice()
        {
            DevToUI();
        }

        public virtual void OnApply()
        {
            OnValidate();
            uiToDev();
        }

        protected virtual void DevToUI()
        {

        }

        protected virtual void uiToDev()
        {

        }


        /// <summary>
        /// 数据校验
        /// </summary>
        public virtual void OnValidate()
        {

        }

        public virtual void OnSave()
        {
            OnApply();

            CHvdcMvcs.OnSave(gridType, tblType);
        }

        public virtual void Addnew()
        {

        }

        public virtual void Delete()
        {

        }
        
    }
}
