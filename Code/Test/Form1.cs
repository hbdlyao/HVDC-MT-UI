using System;
using System.Windows.Forms;

using Hvdc.MT.Project.App;
using Hvdc.MT.mc.dataRw;
using Hvdc.MT.mc.App;
using Hvdc.MT.mc.Def;
using Hvdc.MT.xb.App;
using Hvdc.MT.U3p.App;
using Hvdc.MT.xb.Def;
using System.Collections.Generic;
using Yao.BaseFrame.DevTBL;
using Hvdc.MT.xb.DevTBL;
using Hvdc.MT.xb.dataRw;

namespace Hvdc.MT.UI.Test
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CHvdcParams.PrjDBF=
            //CmcParams.dbfFile=
            //CxbParams.dbfFile=

            CHvdcInitApp.Clear();

            CHvdcMvcs.OnLoad();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //CHvdcParams.PrjDBF=
            //CmcParams.dbfFile=
            //CxbParams.dbfFile=

            CHvdcMvcs.OnSave();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //
            CmcDataRwMvc vRwMvc = new CmcDataRwMvc();

            vRwMvc.InitAdo(CmcParams.dbfFile);
            vRwMvc.InitGrid(CmcVars.pmcHvdcGrid);

            vRwMvc.OnLoad();
            //

            
            CmcDataRwMvc vRw1 = new CmcDataRwMvc();
            vRw1.InitAdo(CmcParams.dbfFile);
            vRw1.InitGrid(CmcVars.pmcHvdcGrid);

            vRw1.OnSave();
            

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //
            // CmcMvcs.OnLoad(CmcDef.mc_AcSys, "S站交流系统");

            //CxbVars.pxbHvdcGrid.AddToStation();

            //C3pMvcs.OnSave();

            //CDevTBL vTBL;
            //vTBL =CxbVars.pxbHvdcGrid.DevTBLfromStation("Station1", CxbDef.xb_PbDKQ);

            CmcMvcs.OnLoadOrder();

            //

            C3pVars.NewGrid();

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //CmcVars.pOrder.CalName = "南网多端mc计算";

            //CmcMvcs.OnLoadOrder();

            //CmcVars.pOrder.IsLoadSingle = 0;

            //CmcMvcs.OnSaveOrder();

            //List<string> vNames=new List<string>();
            //vNames.Add("站1");
            //vNames.Add("站2");
            //vNames.Add("站3");
            //CmcVars.pmcHvdcGrid.NewGrid(vNames);


            CmcMvcs.LoadCase_FromMC("南网多端mc计算");

            MessageBox.Show("Load Over");

        }
    }
}
