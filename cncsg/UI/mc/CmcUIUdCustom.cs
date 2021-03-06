﻿using cn.csg.dpcp.common;
using Hvdc.MT.mc.App;
using Hvdc.MT.mc.Def;
using Hvdc.MT.mc.Solve;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Hvdc.MT.mc.Solve.CmcOrder;

namespace cn.csg.dpcp.ui.mc
{
    public partial class CmcUIUdCustom : CfmBaseFrom
    {
        private IList<RecUdCustom> udCustomList;

        public CmcUIUdCustom()
        {
            InitializeComponent();
            Name = Constants.MCOrderUdCustomUI;
        }


        private void MCOrderUdCustomUI_Load(object sender, EventArgs e)
        {
            //CmcVars.pOrder.CalName = "南网多端mc计算";

            CmcVars.pOrder.Clear();
            CmcMvcs.OnLoadOrder();

            udCustomList = CmcVars.pOrder.UdCustoms;

            DevToUI();

        }


        protected override void DevToUI()
        {
            chkIsDefault.Checked = CmcVars.pOrder.IsUdCustom == 1;
            foreach (RecUdCustom vUdCustom in udCustomList)
            {
                dgvCustom.Rows.Add(new object[] { vUdCustom.PdIndex, vUdCustom.Ud22, vUdCustom.Ud21, vUdCustom.Ud11 });

            }
        }

        protected override void uiToDev()
        {
            CmcVars.pOrder.IsUdCustom = chkIsDefault.Checked ? 1 : 0;
            udCustomList.Clear();
            for (int i = 0; i < dgvCustom.Rows.Count - 1; i++)
            {
                RecUdCustom custom = new RecUdCustom();
                custom.Ud22 = double.Parse(dgvCustom.Rows[i].Cells["Ud22"].Value.ToString());
                custom.Ud21 = double.Parse(dgvCustom.Rows[i].Cells["Ud21"].Value.ToString());
                custom.Ud11 = double.Parse(dgvCustom.Rows[i].Cells["Ud11"].Value.ToString());
                udCustomList.Add(custom);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            OnApply();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            OnApply();

            CmcMvcs.OnSaveOrder();

        }
    }

}
