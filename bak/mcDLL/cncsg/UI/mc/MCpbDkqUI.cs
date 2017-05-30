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
    public partial class MCpbDkqUI : MCBaseUI
    {
        public MCpbDkqUI()
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
        protected CMCDeviceVo Fill(CMCDeviceVo baseVo)
        {
            CXBpbDkqVo vo = baseVo as CXBpbDkqVo;
            if (vo == null)
            {
                return null;
            }
            vo.DeviceID = getSelectedDeviceID();
            vo.DeviceName = txtDeviceName.Text;
            vo.DeviceType = int.Parse(txtDeviceType.Text);
            vo.Zr = (double)numZr.Value;
            vo.Zx = (double)numZx.Value;


            return vo;

        }

        /// <summary>
        /// 绑定数据到UI
        /// </summary>
        protected void Binding(CMCDeviceVo baseVo)
        {
            CXBpbDkqVo vo = baseVo as CXBpbDkqVo;
            cboDeviceID.SelectedItem = vo.DeviceID;
            txtDeviceName.Text = vo.DeviceName;
            txtDeviceType.Text = vo.DeviceType + "";
            numZr.Value = (decimal)vo.Zr;
            numZx.Value = (decimal)vo.Zx;
        }

        protected CMCDeviceVo FindVo()
        {
            string deviceID = getSelectedDeviceID();
            foreach (CMCDeviceVo vo in CMCDeviceDataSet.Pbdkq.VoList)
            {
                if (vo.DeviceID.Equals(deviceID))
                {
                    return vo;
                }
            }
            return null;
        }

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
            int id = FindVo().ID;
            CXBpbDkqVo vo = new CXBpbDkqVo();
            vo.ID = id;
            vo = Fill(vo) as CXBpbDkqVo;
            if (vo == null)
            {
                vo = Fill(new CXBpbDkqVo()) as CXBpbDkqVo;
                vo.ID = new Random().Next(-1000000, -1);
            }
            BaseDAL<CXBpbDkqVo> dal = new CMCpbDkqDAL();
            id = dal.Save(vo, CMCDeviceDataSet.Pbdkq.tableName);
            CXBpbDkqVo oldVo = CMCDeviceDataSet.Pbdkq.Find(id);
            if (oldVo == null)
            {
                vo.ID = id;
                CMCDeviceDataSet.Pbdkq.VoList.Add(vo);
            }
            else
            {
                int index = CMCDeviceDataSet.Pbdkq.VoList.IndexOf(oldVo);
                CMCDeviceDataSet.Pbdkq.VoList.Remove(oldVo);
                CMCDeviceDataSet.Pbdkq.VoList.Insert(index, vo);
            }
            cboDeviceID.DropDownStyle = ComboBoxStyle.DropDownList;

            reload();
        }

        //// 重新加载数据下拉框
        //private void reload()
        //{
        //    IList<CMCDeviceVo> list = new List<CMCDeviceVo>();
        //    foreach (CXBpbDkqVo vo1 in CMCDeviceDataSet.Pbdkq.VoList)
        //    {
        //        list.Add(vo1);
        //    }
        //    initDeviceID(list);
        //}

        private void MCDcFilterUI_Load(object sender, EventArgs e)
        {
            if (CMCDeviceDataSet.Pbdkq.VoList == null || CMCDeviceDataSet.Pbdkq.VoList.Count == 0)
            {
                BaseDAL<CXBpbDkqVo> dal = new CMCpbDkqDAL();
                CMCDeviceDataSet.Pbdkq.VoList = new List<CXBpbDkqVo>();
                dal.QueryList(CMCDeviceDataSet.Pbdkq.tableName, CMCDeviceDataSet.Pbdkq.VoList);
            }
            reload();
            initNumControlButton(this);
        }
    }
}
