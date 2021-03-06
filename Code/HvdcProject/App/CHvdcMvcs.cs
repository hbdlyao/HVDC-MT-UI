///////////////////////////////////////////////////////////
//  CHvdcMvcs.cs
//  Implementation of the Class CHvdcMvcs
//  Generated by Enterprise Architect
//  Created on:      09-5��-2017 16:15:35
//  Original author: open2
///////////////////////////////////////////////////////////


using Hvdc.MT.mc.App;
using Hvdc.MT.xb.App;

using Hvdc.MT.Project.Rw;
using Hvdc.MT.U3p.App;
using Hvdc.MT.HvdcCommon;
using Hvdc.MT.mc.DevTBL;
using Yao.BaseFrame.App;

namespace Hvdc.MT.Project.App
{
    public static class CHvdcMvcs
    {
        public static CHvdcRwMvc pHvdcRwMvc;

        public static void Init()
        {
            


            CmcMvcs.Init();
            CxbMvcs.Init();

            C3pMvcs.Init();


        }
        public static void Release()
        {
            CmcMvcs.Release();
            CxbMvcs.Release();

            C3pMvcs.Release();

        }

        public static void Clear()
        {
            CmcMvcs.Clear();
            CxbMvcs.Clear();
            C3pMvcs.Clear();
        }

        public static void OnLoad()
        {
            OnLoad_PRJ(CMyParams.PRJFile);

            CmcMvcs.OnLoad(CmcParams.dbfFile);

            CxbMvcs.OnLoad(CxbParams.dbfFile);

            C3pMvcs.OnLoad(C3pParams.dbfFile);

        }

        public static void OnSave()
        {

            //OnSave_PRJ(CMyParams.PRJFile);

            // CmcMvcs.OnSave(CmcParams.dbfFile);

            //CxbMvcs.OnSave(CxbParams.dbfFile);

            //C3pMvcs.OnSave(C3pParams.dbfFile);
        }

        public static void OnSave(int vGridType, int vTblType)
        {
            switch (vGridType)
            {
                case CHvdcDefs.mcGridType:
                    CmcMvcs.OnSave(vTblType);
                    break;

                case CHvdcDefs.xbGridType:
                    CxbMvcs.OnSave(vTblType);
                    break;

                case CHvdcDefs.u3pGridType:
                    C3pMvcs.OnSave(vTblType);
                    break;

                default:
                    break;
            }

        }


        public static void OnLoad_PRJ(string vdbf)
        {
            CHvdcRwMvc vRwMvc;

            vRwMvc = new CHvdcRwMvc();
            vRwMvc.InitAdo(vdbf);

            vRwMvc.OnLoad(vdbf);

        }

        public static void OnSave_PRJ(string vdbf)
        {
            CHvdcRwMvc vRwMvc;

            vRwMvc = new CHvdcRwMvc();
            vRwMvc.InitAdo(vdbf);

            vRwMvc.OnSave(vdbf);
        }

    }//end CHvdcMvcs
}//end namespace