using cn.csg.dpcp.common;
using cn.csg.dpcp.dal;
using cn.csg.dpcp.dal.mc;
using cn.csg.dpcp.model.dataset;
using cn.csg.dpcp.model.vo.mc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cn.csg.dpcp.ui.mc
{
    public partial class MCDcFilterUI : MCBaseUI
    {
        public MCDcFilterUI()
        {
            InitializeComponent();
            Name = Constants.MC_CDcFilter;
        }

        protected override string Verify()
        {
            return "";
        }

        /// <summary>
        /// 填充数据到Vo
        /// </summary>
        /// <returns>MCDeviceVo</returns>
        //protected override CMCDeviceVo Fill(CMCDeviceVo baseVo)
        //{
        //    CXBDcFilterVo vo = baseVo as CXBDcFilterVo;
        //    if (vo == null)
        //    {
        //        return null;
        //    }
        //    vo.DeviceID = getSelectedDeviceID();
        //    vo.DeviceName = txtDeviceName.Text;
        //    vo.DeviceType = int.Parse(txtDeviceType.Text);
        //    vo.DcfType = (int)numDcfType.Value;
        //    vo.Zc = (double)numZc.Value;
        //    vo.Zr = (double)numZr.Value;
        //    vo.Zx = (double)numZx.Value;


        //    return vo;

        //}

        ///// <summary>
        ///// 绑定数据到UI
        ///// </summary>
        //protected override void Binding(CMCDeviceVo baseVo)
        //{
        //    CXBDcFilterVo vo = baseVo as CXBDcFilterVo;
        //    cboDeviceID.SelectedItem = vo.DeviceID;
        //    txtDeviceName.Text = vo.DeviceName;
        //    txtDeviceType.Text = vo.DeviceType + "";
        //    numDcfType.Value = (decimal)vo.DcfType;
        //    numZc.Value = (decimal)vo.Zc;
        //    numZr.Value = (decimal)vo.Zr;
        //    numZx.Value = (decimal)vo.Zx;
        //}

        //protected override CMCDeviceVo FindVo()
        //{
        //    string deviceID = getSelectedDeviceID();
        //    foreach (CMCDeviceVo vo in CMCDeviceDataSet.DcFilter.VoList)
        //    {
        //        if (vo.DeviceID.Equals(deviceID))
        //        {
        //            return vo;
        //        }
        //    }
        //    return null;
        //}

        /// <summary>
        /// 界面数据重置
        /// </summary>
        protected override void RestUI()
        {
            base.RestUI();
            numDcfType.ResetText();
            numZc.ResetText();
            numZr.ResetText();
            numZx.ResetText();
        }

        protected override void Save(object sender, EventArgs e)
        {
            //int id = FindVo().ID;
            //CXBDcFilterVo vo = new CXBDcFilterVo();
            //vo.ID = id;
            //vo = Fill(vo) as CXBDcFilterVo;
            //if (vo == null)
            //{
            //    vo = Fill(new CXBDcFilterVo()) as CXBDcFilterVo;
            //    vo.ID = new Random().Next(-1000000, -1);
            //}
            //BaseDAL<CXBDcFilterVo> dal = new CXBDcFilterDAL();
            //id = dal.Save(vo, CMCDeviceDataSet.DcFilter.tableName);
            //CXBDcFilterVo oldVo = CMCDeviceDataSet.DcFilter.Find(id);
            //if (oldVo == null)
            //{
            //    vo.ID = id;
            //    CMCDeviceDataSet.DcFilter.VoList.Add(vo);
            //}
            //else
            //{
            //    int index = CMCDeviceDataSet.DcFilter.VoList.IndexOf(oldVo);
            //    CMCDeviceDataSet.DcFilter.VoList.Remove(oldVo);
            //    CMCDeviceDataSet.DcFilter.VoList.Insert(index, vo);
            //}
            //cboDeviceID.DropDownStyle = ComboBoxStyle.DropDownList;

            reload();
        }

        //// 重新加载数据下拉框
        //private void reload()
        //{
        //    IList<CMCDeviceVo> list = new List<CMCDeviceVo>();
        //    foreach (CXBDcFilterVo vo1 in CMCDeviceDataSet.DcFilter.VoList)
        //    {
        //        list.Add(vo1);
        //    }
        //    initDeviceID(list);
        //}

        private void MCDcFilterUI_Load(object sender, EventArgs e)
        {
            //if (CMCDeviceDataSet.DcFilter.VoList == null || CMCDeviceDataSet.DcFilter.VoList.Count == 0)
            //{
            //    BaseDAL<CXBDcFilterVo> dal = new CXBDcFilterDAL();
            //    CMCDeviceDataSet.DcFilter.VoList = new List<CXBDcFilterVo>();
            //    dal.QueryList(CMCDeviceDataSet.DcFilter.tableName, CMCDeviceDataSet.DcFilter.VoList);
            //}
            reload();
            initNumControlButton(this);
        }
    }
}
