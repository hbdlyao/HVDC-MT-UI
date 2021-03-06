///////////////////////////////////////////////////////////
//  C3pFunc.cs
//  Implementation of the Class C3pFunc
//  Generated by Enterprise Architect
//  Created on:      09-5月-2017 16:15:35
//  Original author: open2
///////////////////////////////////////////////////////////

using Hvdc.MT.U3p.Def;

namespace Hvdc.MT.U3p.Func
{
    public static class C3pFunc
    {
        /// 
        /// <param name="vType"></param>
        public static string TypeToName(int vType)
        {
            string vStr;

            switch (vType)
            {
                case C3pDefs.U3p_AcSys:
                    vStr= "交流系统";
                    break;

                case C3pDefs.U3p_AcF:
                    vStr= "交流滤波器";
                    break;

                case C3pDefs.U3p_Xf2:
                    vStr= "换流变";
                    break;

                case C3pDefs.U3p_Convertor:
                    vStr= "换流器";
                    break;

                case C3pDefs.U3p_DcLine:
                    vStr= "直流极线";
                    break;

                case C3pDefs.U3p_Ground:
                    vStr= "接地极";
                    break;

                case C3pDefs.U3p_GroundLine:
                    vStr= "接地极线";
                    break;

                case C3pDefs.U3p_MetalLine:
                    vStr= "金属回线";
                    break;

                default:
                    vStr= "HvdcDevice";
                    break;

            }//switch

            return vStr;

        }//mcType

    }//end C3pFunc

}//end namespace mc