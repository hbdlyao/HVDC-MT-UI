///////////////////////////////////////////////////////////
//  CmcDataRwMvc.cs
//  Implementation of the Class CmcDataRwMvc
//  Generated by Enterprise Architect
//  Created on:      09-5��-2017 8:08:05
//  Original author: open2
///////////////////////////////////////////////////////////

using Yao.BaseFrame.dataRw;

using Hvdc.MT.mc.Def;
using Hvdc.MT.mc.DevTBL;
using Hvdc.MT.mc.Rw;

namespace Hvdc.MT.mc.dataRw
{
    public class CmcDataRwMvc : CDataRwMvcAccess
    {
        private CmcHvdcGrid pGrid;
        
        /// 
        /// <param name="vHvdc"></param>
        public void InitGrid(CmcHvdcGrid vGrid)
        {
            pGrid = vGrid;
        }

        protected override void doLoad()
        {
            //
            doLoad_mcAcSys();

            doLoad_mcAcFilter();

            doLoad_mcXf2();
            doLoad_mcConvertor();

            doLoad_mcDcLine();
            doLoad_mcMetalLine();
            doLoad_mcGroundLine();

            doLoad_mcGround();
            
        }

        protected override void doSave()
        {
           doSave_mcAcSys();

           doSave_mcAcFilter();
           doSave_mcXf2();

           doSave_mcConvertor();

           doSave_mcDcLine();
           doSave_mcMetalLine();
           doSave_mcGroundLine();

            doSave_mcGround();
           
        }


        /// <summary>
        /// void
        /// </summary>
        protected void doLoad_mcAcSys()
        {
            CmcDataRwAcSys vRw = new CmcDataRwAcSys();

            vRw.InitAdo(RwAdo);
            vRw.InitTable("mcAcSystem", CmcDef.mc_AcSys, CmcDef.mc_AcSys);
            vRw.InitGrid(pGrid);

            vRw.OnLoad();
        }
       
        protected void doLoad_mcAcFilter()
        {

            CmcDataRwAcfilter vRw=new CmcDataRwAcfilter();

            vRw.InitAdo(RwAdo);
            vRw.InitTable("mcAcFilter", CmcDef.mc_AcF, CmcDef.mc_AcF);
            vRw.InitGrid(pGrid);

            vRw.OnLoad();
        }

        /// <summary>
        /// void
        /// </summary>
        protected void doLoad_mcXf2()
        {

            CmcDataRwXf2 vRw=new CmcDataRwXf2();

            vRw.InitAdo(RwAdo);
            vRw.InitTable("mcTransformer", CmcDef.mc_Xf2, CmcDef.mc_Xf2);
            vRw.InitGrid(pGrid);

            vRw.OnLoad();
        }

        protected void doLoad_mcConvertor()
        {

            CmcDataRwConvertor vRw=new CmcDataRwConvertor();

            vRw.InitAdo(RwAdo);
            vRw.InitTable("mcConvertor", CmcDef.mc_Convertor, CmcDef.mc_Convertor);
            vRw.InitGrid(pGrid);

            vRw.OnLoad();
        }

        /// <summary>
        /// void
        /// </summary>
        protected void doLoad_mcDcLine()
        {

            CmcDataRwDcLine vRw=new CmcDataRwDcLine();

            vRw.InitAdo(RwAdo);
            vRw.InitTable("mcDcLine", CmcDef.mc_DcLine, CmcDef.mc_DcLine);
            vRw.InitGrid(pGrid);

            vRw.OnLoad();
        }

        /// <summary>
        /// void
        /// </summary>
        protected void doLoad_mcMetalLine()
        {

            CmcDataRwMetalLine vRw=new CmcDataRwMetalLine();

            vRw.InitAdo(RwAdo);
            vRw.InitTable("mcMetalLine", CmcDef.mc_MetalLine, CmcDef.mc_MetalLine);
            vRw.InitGrid(pGrid);

            vRw.OnLoad();
        }

        /// <summary>
        /// void
        /// </summary>
        protected void doLoad_mcGroundLine()
        {

            CmcDataRwGroundLine vRw=new CmcDataRwGroundLine();

            vRw.InitAdo(RwAdo);
            vRw.InitTable("mcGroundLine", CmcDef.mc_GroundLine, CmcDef.mc_GroundLine);
            vRw.InitGrid(pGrid);

            vRw.OnLoad();
        }

        protected void doLoad_mcGround()
        {

            CmcDataRwGround vRw=new CmcDataRwGround();

            vRw.InitAdo(RwAdo);
            vRw.InitTable("mcGround", CmcDef.mc_Ground, CmcDef.mc_Ground);
            vRw.InitGrid(pGrid);

            vRw.OnLoad();
        }
       
        /// <summary>
        /// void
        /// </summary>
        protected void doSave_mcAcSys()
        {
            CmcDataRwAcSys vRw=new CmcDataRwAcSys();

            vRw.InitAdo(RwAdo);
            vRw.InitTable("mcAcSystem", CmcDef.mc_AcSys, CmcDef.mc_AcSys);
            vRw.InitGrid(pGrid);

            vRw.OnSave();

        }
        
        protected void doSave_mcAcFilter()
        {

            CmcDataRwAcfilter vRw=new CmcDataRwAcfilter();

            vRw.InitAdo(RwAdo);
            vRw.InitTable("mcAcFilter", CmcDef.mc_AcF, CmcDef.mc_AcF);
            vRw.InitGrid(pGrid);

            vRw.OnSave();
        }

        /// <summary>
        /// void
        /// </summary>
        protected void doSave_mcXf2()
        {

            CmcDataRwXf2 vRw=new CmcDataRwXf2();

            vRw.InitAdo(RwAdo);
            vRw.InitTable("mcTransformer", CmcDef.mc_Xf2, CmcDef.mc_Xf2);
            vRw.InitGrid(pGrid);

            vRw.OnSave();
        }

        protected void doSave_mcConvertor()
        {

            CmcDataRwConvertor vRw=new CmcDataRwConvertor();

            vRw.InitAdo(RwAdo);
            vRw.InitTable("mcConvertor", CmcDef.mc_Convertor, CmcDef.mc_Convertor);
            vRw.InitGrid(pGrid);

            vRw.OnSave();
        }

        /// <summary>
        /// void
        /// </summary>
        protected void doSave_mcDcLine()
        {

            CmcDataRwDcLine vRw=new CmcDataRwDcLine();

            vRw.InitAdo(RwAdo);
            vRw.InitTable("mcDcLine", CmcDef.mc_DcLine, CmcDef.mc_DcLine);
            vRw.InitGrid(pGrid);

            vRw.OnSave();
        }

        /// <summary>
        /// void
        /// </summary>
        protected void doSave_mcMetalLine()
        {
            CmcDataRwMetalLine vRw=new CmcDataRwMetalLine();

            vRw.InitAdo(RwAdo);
            vRw.InitTable("mcMetalLine", CmcDef.mc_MetalLine, CmcDef.mc_MetalLine);
            vRw.InitGrid(pGrid);

            vRw.OnSave();
        }

        /// <summary>
        /// void
        /// </summary>
        protected void doSave_mcGroundLine()
        {

            CmcDataRwGroundLine vRw=new CmcDataRwGroundLine();

            vRw.InitAdo(RwAdo);
            vRw.InitTable("mcGroundLine", CmcDef.mc_GroundLine, CmcDef.mc_GroundLine);
            vRw.InitGrid(pGrid);

            vRw.OnSave();
        }

        protected void doSave_mcGround()
        {

            CmcDataRwGround vRw=new CmcDataRwGround();

            vRw.InitAdo(RwAdo);
            vRw.InitTable("mcGround",CmcDef.mc_Ground, CmcDef.mc_Ground);
            vRw.InitGrid(pGrid);

            vRw.OnSave();
        }
   

    }//end CmcDataRwMvc

}//end namespace mc