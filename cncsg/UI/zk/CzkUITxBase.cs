﻿using cn.csg.dpcp.common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cn.csg.dpcp.ui.zk
{
    public partial class CzkUITxBase : CfmBaseFrom
    {
        public CzkUITxBase()
        {
            InitializeComponent();
            Name = Constants.CzkTxBaseUI;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        private void showTxUI(int count)
        {
            pnlTx.Controls.Clear();
            CfmBaseFrom ui;
            if (count == 2)
            {
                ui = new CzkUITxTwo();
            } else if (count == 3)
            {
                ui = new CzkUITxThree();
            } else
            {
                ui = new CzkUITxOne();
            }
            ui.TopLevel = false;
            ui.Dock = DockStyle.Left;
            pnlTx.Controls.Add(ui);
            ui.Show();
        }

        /// <summary>
        /// 单调谐点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radXtOnw_CheckedChanged(object sender, EventArgs e)
        {
            showTxUI(1);
        }

        /// <summary>
        /// 双调谐点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radTxTwo_CheckedChanged(object sender, EventArgs e)
        {
            showTxUI(2);
        }

        /// <summary>
        /// 三调谐点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radTxThree_CheckedChanged(object sender, EventArgs e)
        {
            showTxUI(3);
        }
    }
}
