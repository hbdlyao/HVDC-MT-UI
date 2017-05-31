///////////////////////////////////////////////////////////
//  CmcDevTBL.cs
//  Implementation of the Class CmcDevTBL
//  Generated by Enterprise Architect
//  Created on:      09-5月-2017 17:08:08
//  Original author: open2
///////////////////////////////////////////////////////////

using Yao.BaseFrame.Device;
using Yao.BaseFrame.DevTBL;

using Hvdc.MT.mc.Def;
using Hvdc.MT.mc.Device;
using Hvdc.MT.mc.Func;

namespace Hvdc.MT.mc.DevTBL
{
    /// <summary>
    /// 主回路直流设备表
    /// </summary>
    public class CmcDevTBL : CDevTBL
    {
        /// 
        /// <param name="vDevType"></param>
        protected override CDevBase doNewDevice(int vDevType)
        {
            return mcNewDevice(vDevType);
        }

        /// 
        /// <param name="vDevType"></param>
        public override string TypeToName(int vDevType)
        {

            return CmcFunc.mcTypeToName(vDevType);
        }

        /// 
        /// <param name="vDevType"></param>
        public static CDevBase mcNewDevice(int vDevType)
        {

            CDevBase vDev;

            switch (vDevType)
            {
                case CmcDef.mc_AcSys:
                    //交流系统  
                    vDev = new CmcDevAcSys();
                    break;

                case CmcDef.mc_AcF:
                    //交流滤波器
                    vDev = new CmcDevAcFilter();
                    break;

                case CmcDef.mc_Xf2:
                    //双绕组变压器  
                    vDev = new CmcDevXf2();
                    break;


                case CmcDef.mc_Convertor:
                    //换流器  
                    vDev = new CmcDevConvertor();
                    break;

                case CmcDef.mc_DcLine:
                    //直流极线  
                    vDev = new CmcDevDcLine();
                    break;


                case CmcDef.mc_GroundLine:
                    //接地极线  
                    vDev = new CmcDevGroundLine();
                    break;

                case CmcDef.mc_MetalLine:
                    //金属回线  
                    vDev = new CmcDevMetalLine();
                    break;

                case CmcDef.mc_Ground:
                    //接地极  
                    vDev = new CmcDevGround();
                    break;

                default:
                    vDev = new CmcDevBase();
                    break;

            }//switch

            vDev.Init();
            vDev.DeviceType = vDevType;

            return vDev;
        }

    }//end CmcDevTBL

}//end namespace DevTBL