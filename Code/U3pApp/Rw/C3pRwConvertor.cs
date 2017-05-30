///////////////////////////////////////////////////////////
//  C3pRwConvertor.cs
//  Implementation of the class C3pRwConvertor
//  Generated by Enterprise Architect
//  Created on:      09-5��-2017 8:08:04
//  Original author: open2
///////////////////////////////////////////////////////////


using Hvdc.MT.U3p.Device;
using Yao.BaseFrame.Device;
using Yao.BaseFrame.Func;

namespace Hvdc.MT.U3p.Rw
{
    public class C3pRwConvertor : C3pRwTwo
    {
        protected override void doLoad(CDevBase vDevice)
        {
            C3pDevConvertor vDev;
            vDev = (C3pDevConvertor)vDevice;

            base.doLoad(vDevice);

            vDev.StationType = RwAdo.ReadInt32("StationType") ;
            //vDev.Std_Angle  = RwAdo.ReadDouble("Std_Angle");
            //vDev.Dis_dAngle = RwAdo.ReadDouble("Dis_dAngle");

            vDev.dAngle[0] = RwAdo.ReadDouble("deltaAngle1");
            vDev.dAngle[1] = RwAdo.ReadDouble("deltaAngle2");
            vDev.dAngle[2] = RwAdo.ReadDouble("deltaAngle3");
            vDev.dAngle[3] = RwAdo.ReadDouble("deltaAngle4");
            vDev.dAngle[4] = RwAdo.ReadDouble("deltaAngle5");
            vDev.dAngle[5] = RwAdo.ReadDouble("deltaAngle6");

        }

        /// 
        /// <param name="vDevice"></param>
        protected override void doSave(CDevBase vDevice)
        {
            C3pDevConvertor vDev;
            vDev = (C3pDevConvertor)vDevice;

            base.doSave(vDevice);

            SqlStr = SqlStr + ",";
            SqlParam = SqlParam + ",";

            SqlStr = SqlStr + "StationType,";
            SqlParam = SqlParam + GetString(vDev.StationType) + ",";

           // SqlStr = SqlStr + "Std_Angle,";
           // SqlParam = SqlParam + GetString(vDev.Std_Angle) + ",";

            //SqlStr = SqlStr + "Dis_dAngle,";
            //SqlParam = SqlParam + GetString(vDev.Dis_dAngle) + ",";

            SqlStr = SqlStr + "deltaAngle1,";
            SqlParam = SqlParam + GetString(vDev.dAngle[0]) + ",";

            SqlStr = SqlStr + "deltaAngle2,";
            SqlParam = SqlParam + GetString(vDev.dAngle[1]) + ",";

            SqlStr = SqlStr + "deltaAngle3,";
            SqlParam = SqlParam + GetString(vDev.dAngle[2]) + ",";

            SqlStr = SqlStr + "deltaAngle4,";
            SqlParam = SqlParam + GetString(vDev.dAngle[3]) + ",";

            SqlStr = SqlStr + "deltaAngle5,";
            SqlParam = SqlParam + GetString(vDev.dAngle[4]) + ",";

            SqlStr = SqlStr + "deltaAngle6 ";
            SqlParam = SqlParam + GetString(vDev.dAngle[5]); 



        }

    }//end C3pRwConvertor

}//end namespace mc