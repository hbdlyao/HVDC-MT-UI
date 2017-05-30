///////////////////////////////////////////////////////////
//  CmcRwMvc.cs
//  Implementation of the class CmcRwMvc
//  Generated by Enterprise Architect
//  Created on:      09-5��-2017 8:08:05
//  Original author: open2
///////////////////////////////////////////////////////////

using Yao.BaseFrame.Rw;

using Hvdc.MT.mc.Def;

using Hvdc.MT.mc.DevTBL;
using Yao.BaseFrame.Device;
using Hvdc.MT.mc.Rw;

namespace Hvdc.MT.mc.RwMvc
{
    public class CmcRwMvc : CRwMvcAccess
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
            CRwDev vRw;
            int i1, i2;

            i1 = CmcDef.mc_AcSys;
            i2 = CmcDef.mc_Ground;

            for (int i = i1; i <= i2; i++)
            {
                vRw = doNewRw(i);
                vRw.OnLoad();
            }                      
        }

        protected override void doSave()
        {
            CRwDev vRw;
            int i1, i2;

            i1 = CmcDef.mc_AcSys;
            i2 = CmcDef.mc_Ground;

            for (int i = i1; i <= i2; i++)
            {
                vRw = doNewRw(i);
                vRw.OnSave();
            }
        }

        protected override CRwDev doNewRw(int vtblType)
        {
            CRwDev vRw;

            switch (vtblType)
            {
                case CmcDef.mc_AcSys:
                    //����ϵͳ  
                    vRw = new CmcRwAcSys();

                    vRw.InitAdo(RwAdo);
                    vRw.InitTable("mcAcSystem");
                    vRw.InitType(CmcDef.mc_AcSys, CmcDef.mc_AcSys);
                    vRw.InitGrid(pGrid);

                    break;

                case CmcDef.mc_AcF:
                    //�����˲���
                    vRw = new CmcRwAcfilter();

                    vRw.InitAdo(RwAdo);
                    vRw.InitTable("mcAcFilter");
                    vRw.InitType(CmcDef.mc_AcF, CmcDef.mc_AcF);
                    vRw.InitGrid(pGrid);

                    break;

                case CmcDef.mc_Xf2:
                    //˫�����ѹ��  
                    vRw = new CmcRwXf2();

                    vRw.InitAdo(RwAdo);
                    vRw.InitTable("mcTransformer");
                    vRw.InitType(CmcDef.mc_Xf2, CmcDef.mc_Xf2);
                    vRw.InitGrid(pGrid);

                    break;

                case CmcDef.mc_Convertor:
                    //������  
                    vRw = new CmcRwConvertor();

                    vRw.InitAdo(RwAdo);
                    vRw.InitTable("mcConvertor");
                    vRw.InitType(CmcDef.mc_Convertor, CmcDef.mc_Convertor);
                    vRw.InitGrid(pGrid);

                    break;

                case CmcDef.mc_DcLine:
                    //ֱ������  
                    vRw = new CmcRwDcLine();

                    vRw.InitAdo(RwAdo);
                    vRw.InitTable("mcDcLine");
                    vRw.InitType(CmcDef.mc_DcLine, CmcDef.mc_DcLine);
                    vRw.InitGrid(pGrid);

                    break;

                case CmcDef.mc_MetalLine:
                    //�ӵؼ���  
                    vRw = new CmcRwMetalLine();

                    vRw.InitAdo(RwAdo);
                    vRw.InitTable("mcMetalLine");
                    vRw.InitType(CmcDef.mc_MetalLine, CmcDef.mc_MetalLine);
                    vRw.InitGrid(pGrid);

                    break;

                case CmcDef.mc_GroundLine:
                    //��������  
                    vRw = new CmcRwGroundLine();

                    vRw.InitAdo(RwAdo);
                    vRw.InitTable("mcGroundLine");
                    vRw.InitType(CmcDef.mc_GroundLine, CmcDef.mc_GroundLine);
                    vRw.InitGrid(pGrid);

                    break;

                case CmcDef.mc_Ground:
                    //�ӵؼ�  
                    vRw = new CmcRwGround();

                    vRw.InitAdo(RwAdo);
                    vRw.InitTable("mcGround");
                    vRw.InitType(CmcDef.mc_Ground, CmcDef.mc_Ground);
                    vRw.InitGrid(pGrid);

                    break;

                default:
                    vRw = null;
                    break;

            }

            return vRw;

        }      


    }//end CmcRwMvc

}//end namespace mc