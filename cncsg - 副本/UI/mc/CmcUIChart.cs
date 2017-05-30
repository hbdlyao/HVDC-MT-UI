using cn.csg.dpcp.common;
using DevComponents.DotNetBar.Charts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Data = System.Data;

namespace cn.csg.dpcp.ui
{
    public partial class MCDisplayUI : CfmBaseFrom
    {
        public MCDisplayUI()
        {
            InitializeComponent();
            Name = Constants.MC_CDisplay;
        }

        private void Drawing_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.SkyBlue);
           Rectangle r = new Rectangle(new Point(10,10), new Size(100,50));
            g.DrawEllipse(p, r);
        }

        private void btnSaveAsPic_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveImageAll_Click(object sender, EventArgs e)
        {

        }

        private void btnMerge_Click(object sender, EventArgs e)
        {

        }

        private void lstStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string caseId = lstOrder.SelectedItem.ToString();
            string station = lstStation.SelectedItem.ToString();
            
            //Data.DataTable dt = dal.QueryResult(caseId, station);
            //chartControl1.DataSource = dt;
            //string type = chartControl1.ChartPanel.ChartContainers["ChartXyMain"].GetType().ToString();
            //MessageBox.Show(type);
            ChartXy chart =  chartControl1.ChartPanel.ChartContainers["ChartXyMain"] as ChartXy;
            chart.ChartSeries.Clear();

            //chart.DataSource = dt;

        }

        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstStation.Items.Clear();
            string caseId = lstOrder.SelectedItem.ToString();
        }

        private void MCDisplayUI_Load(object sender, EventArgs e)
        {
            lstOrder.Items.Clear();
            lstStation.Items.Clear();
            // 加载工况
            
            loadOrder();

        }

        // 加载工况列表
        private void loadOrder()
        {
            
        }

    }
}
