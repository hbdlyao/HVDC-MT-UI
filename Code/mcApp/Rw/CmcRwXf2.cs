///////////////////////////////////////////////////////////
//  CmcRwXf2.cs
//  Implementation of the class CmcRwXf2
//  Generated by Enterprise Architect
//  Created on:      09-5��-2017 8:08:05
//  Original author: open2
///////////////////////////////////////////////////////////


using Hvdc.MT.mc.Device;
using Yao.BaseFrame.Device;
using Yao.BaseFrame.Func;

namespace Hvdc.MT.mc.Rw
{
    public class CmcRwXf2 : CmcRwTwo
    {
        protected override void doLoad(CDevBase vDevice)
        {
            CmcDevXf2 vDev;
            vDev = (CmcDevXf2)vDevice;

            base.doLoad(vDevice);

            vDev.FixedURef  = RwAdo.ReadDouble("FixedURef") ;
            vDev.FixedUType = RwAdo.ReadInt32("FixedUType");

            vDev.AngleMax = RwAdo.ReadDouble("AngleMax") ;
            vDev.AngleMin = RwAdo.ReadDouble("AngleMin") ;
     
            vDev.TapCtrlType = RwAdo.ReadInt32("TapCtrlType") ;
            vDev.TapN = RwAdo.ReadInt32("TapN");
            vDev.TapMax = RwAdo.ReadInt32("TapMax") ;
            vDev.TapMin = RwAdo.ReadInt32("TapMin") ;
            vDev.TapSetup = RwAdo.ReadDouble("TapSetup") ;

            vDev.Ukp = RwAdo.ReadDouble("Ukp") ;
            vDev.Urp = RwAdo.ReadDouble("Urp") ;

            vDev.TkN = RwAdo.ReadDouble("TkN") ;
            vDev.UacN = RwAdo.ReadDouble("UacN") ;
            vDev.UvN = RwAdo.ReadDouble("UvN") ;
            vDev.UvMax = RwAdo.ReadDouble("UvMax") ;

        }

        /// 
        /// <param name="vDevice"></param>
        protected override void doSave(CDevBase vDevice)
        {
            CmcDevXf2 vDev;
            vDev = (CmcDevXf2)vDevice;

            base.doSave(vDevice);

            SqlStr = SqlStr + ",";
            SqlParam = SqlParam + ",";

            SqlStr = SqlStr + "FixedURef, ";
            SqlParam = SqlParam + GetString(vDev.FixedURef) + ",";

            SqlStr = SqlStr + "FixedUType, ";
            SqlParam = SqlParam + GetString(vDev.FixedUType) + ",";

            SqlStr = SqlStr + "AngleMax, ";
            SqlParam = SqlParam + GetString(vDev.AngleMax) + ",";

            SqlStr = SqlStr + "AngleMin, ";
            SqlParam = SqlParam + GetString(vDev.AngleMin) + ",";

            SqlStr = SqlStr + "TapCtrlType, ";
            SqlParam = SqlParam + GetString(vDev.TapCtrlType) + ",";

            SqlStr = SqlStr + "TapN, ";
            SqlParam = SqlParam + GetString(vDev.TapN) + ",";

            SqlStr = SqlStr + "TapMax, ";
            SqlParam = SqlParam + GetString(vDev.TapMax) + ",";

            SqlStr = SqlStr + "TapMin, ";
            SqlParam = SqlParam + GetString(vDev.TapMin) + ",";

            SqlStr = SqlStr + "TapSetup, ";
            SqlParam = SqlParam + GetString(vDev.TapSetup) + ",";

            SqlStr = SqlStr + "Ukp, ";
            SqlParam = SqlParam + GetString(vDev.Ukp) + ",";

            SqlStr = SqlStr + "Urp, ";
            SqlParam = SqlParam + GetString(vDev.Urp) + ",";

            SqlStr = SqlStr + "TkN, ";
            SqlParam = SqlParam + GetString(vDev.TkN) + ",";

            SqlStr = SqlStr + "UacN, ";
            SqlParam = SqlParam + GetString(vDev.UacN) + ",";

            SqlStr = SqlStr + "UvN, ";
            SqlParam = SqlParam + GetString(vDev.UvN) + ",";

            SqlStr = SqlStr + "UvMax ";
            SqlParam = SqlParam + GetString(vDev.UvMax);

        }

    }//end CmcRwXf2

}//end namespace mc