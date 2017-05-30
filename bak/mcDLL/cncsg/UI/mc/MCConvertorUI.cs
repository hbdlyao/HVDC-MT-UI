﻿using cn.csg.dpcp.common;
using cn.csg.dpcp.dal;
using cn.csg.dpcp.dal.mc;
using cn.csg.dpcp.model.dataset;
using cn.csg.dpcp.model.vo.mc;
using Hvdc.MT.HvdcCommon;
using Hvdc.MT.mc.App;
using Hvdc.MT.mc.Def;
using Hvdc.MT.mc.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Yao.BaseFrame.Device;

namespace cn.csg.dpcp.ui.mc
{
    public partial class MCConvertorUI : MCBaseUI
    {
        public MCConvertorUI()
        {
            InitializeComponent();
            Name = Constants.MC_CConvertor;
        }


        private void MCConvertorUI_Load(object sender, EventArgs e)
        {
            InitForm(CmcVars.pmcHvdcGrid, CHvdcDefs.mcGridType, CmcDef.mc_Convertor);
            FillComboxFromDevice(cboDeviceID);
        }

        protected override void DevToUI()
        {
            CmcDevConvertor vo = Device as CmcDevConvertor;
            cboDeviceID.SelectedItem = vo.DeviceID;
            txtDeviceName.Text = vo.DeviceName;
            txtDeviceType.Text = vo.DeviceType + "";
            txtStationName.Text = vo.StationNames[0];
            numAlpha_gamaN.Value = (decimal)vo.Alpha_gamaN;
            numAngleMin.Value = (decimal)vo.AngleMin;
            numPdN.Value = (decimal)vo.PdN;
            numUdN.Value = (decimal)vo.UdN;
            numUT.Value = (decimal)vo.UT;
            numValvor12Count.Value = (decimal)vo.Valvor12Count;
            //numQmin.Value = (decimal)vo.Qmin;
            if (vo.StationCtrlType == 2)
            {
                cboStationCtrlType.SelectedItem = "定功率";
            }
            else if (vo.StationCtrlType == 3)
            {
                cboStationCtrlType.SelectedItem = "定电压";
            }
            else if (vo.StationCtrlType == 5)
            {
                cboStationCtrlType.SelectedItem = "定角度";
            }
            else if (vo.StationCtrlType == 1)
            {
                cboStationCtrlType.SelectedItem = "定电流";
            }
            else if (vo.StationCtrlType == 6)
            {
                cboStationCtrlType.SelectedItem = "电流跟随";
            }

            if (vo.StationType == 0)
            {
                cboStationType.SelectedItem = "整流";
            }
            else if (vo.StationType == 1)
            {
                cboStationType.SelectedItem = "逆变";
            }
        }

        protected override void uiToDev()
        {
            CmcDevConvertor vo = Device as CmcDevConvertor;
            vo.DeviceName = txtDeviceName.Text;
            vo.DeviceType = int.Parse(txtDeviceType.Text);
            vo.StationNames[0] = txtStationName.Text;
            vo.Alpha_gamaN = (double)numAlpha_gamaN.Value;
            vo.AngleMin = (double)numAngleMin.Value;
            vo.PdN = (double)numPdN.Value;
            vo.UdN = (double)numUdN.Value;
            vo.UT = (double)numUT.Value;
            vo.Valvor12Count = (int)numValvor12Count.Value;
            //vo.Qmin = (double)numQmin.Value;
            if (cboStationType.SelectedItem.ToString().Equals("整流"))
            {
                vo.StationType = 0;
            }
            else if (cboStationType.SelectedItem.ToString().Equals("逆变"))
            {
                vo.StationType = 1;
            }
            if (cboStationCtrlType.SelectedItem.ToString().Equals("定功率"))
            {
                vo.StationCtrlType = 2;
            }
            else if (cboStationCtrlType.SelectedItem.ToString().Equals("定电压"))
            {
                vo.StationCtrlType = 3;
            }
            else if (cboStationCtrlType.SelectedItem.ToString().Equals("定角度"))
            {
                vo.StationCtrlType = 5;
            }
            else if (cboStationCtrlType.SelectedItem.ToString().Equals("定电流"))
            {
                vo.StationCtrlType = 1;
            }
            else if (cboStationCtrlType.SelectedItem.ToString().Equals("定电流跟随"))
            {
                vo.StationCtrlType = 6;
            }
        }
    }
}