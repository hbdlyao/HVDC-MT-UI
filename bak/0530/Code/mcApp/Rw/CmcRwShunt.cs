///////////////////////////////////////////////////////////
//  CmcRwShunt.cs
//  Implementation of the class CmcRwShunt
//  Generated by Enterprise Architect
//  Created on:      09-5��-2017 8:08:05
//  Original author: open2
///////////////////////////////////////////////////////////


using Hvdc.MT.mc.Device;
using Yao.BaseFrame.Device;

namespace Hvdc.MT.mc.Rw
{
    public class CmcRwShunt : CmcRwOne
    {
        protected override void doLoad(CDevBase vDevice)
        {
            CmcDevShunt vDev;
            vDev = (CmcDevShunt)vDevice;

            base.doLoad(vDevice);

            /*
            vDev.Zr = RwAdo.ReadDouble("Zr") ;

            
            vDev.Z_L = RwAdo.ReadDouble("Z_L") ;
            vDev.Z_C = RwAdo.ReadDouble("Z_C") ;
            vDev.Zx_L = RwAdo.ReadDouble("Zx_L") ;
            vDev.Zx_C = RwAdo.ReadDouble("Zx_C") ;
            */

        }

        /// 
        /// <param name="vDevice"></param>
        protected override void doSave(CDevBase vDevice)
        {
            CmcDevShunt vDev;
            vDev = (CmcDevShunt)vDevice;

            base.doSave(vDevice);

            //SqlStr = SqlStr + ",";
            //SqlParam = SqlParam + ",";

            //SqlStr = SqlStr + "Zr, ";
            //SqlParam = SqlParam + GetString(vDev.Zr) + " , ";

            //SqlStr = SqlStr + "Z_L, ";
            //SqlParam = SqlParam + GetString(vDev.Z_L) + " , ";

            //SqlStr = SqlStr + "Z_C, ";
            //SqlParam = SqlParam + GetString(vDev.Z_C) + " , ";

            //SqlStr = SqlStr + "Zx_L, ";
            //SqlParam = SqlParam + GetString(vDev.Zx_L + " , ";

            //SqlStr = SqlStr + "Zx_C ";
            //SqlParam = SqlParam + GetString(vDev.Zx_C) ;

        }

    }//end CmcRwShunt
}//end namespace mc