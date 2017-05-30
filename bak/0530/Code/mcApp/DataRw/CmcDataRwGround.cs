///////////////////////////////////////////////////////////
//  CmcRwGround.cs
//  Implementation of the class CmcRwGround
//  Generated by Enterprise Architect
//  Created on:      09-5��-2017 8:08:05
//  Original author: open2
///////////////////////////////////////////////////////////


using Hvdc.MT.mc.dataRw;
using Hvdc.MT.mc.Device;
using Yao.BaseFrame.Device;
using Yao.BaseFrame.Func;

namespace Hvdc.MT.mc.Rw
{
    public class CmcDataRwGround : CmcDataRwOne
    {
        protected override void doLoad(CDevBase vDevice)
        {
            CmcDevGround vDev;
            vDev = (CmcDevGround)vDevice;

            base.doLoad(vDevice);

            vDev.Zr = RwAdo.ReadDouble("Zr") ;            

        }

        /// 
        /// <param name="vDevice"></param>
        protected override void doSave(CDevBase vDevice)
        {
            CmcDevGround vDev;
            vDev = (CmcDevGround)vDevice;

            base.doSave(vDevice);

            RwAdo.SaveField("Zr", vDev.Zr);

        }

    }//end CmcRwGround
}//end namespace mc