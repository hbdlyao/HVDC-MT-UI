///////////////////////////////////////////////////////////
//  CxbDevDcLine_Seg.cs
//  Implementation of the Class CxbDevDcLine_Seg
//  Generated by Enterprise Architect
//  Created on:      09-5月-2017 17:08:09
//  Original author: open2
///////////////////////////////////////////////////////////

namespace Hvdc.MT.xb.Device
{
    /// <summary>
    /// 直流极线
    /// 
    /// 具体计算参数，参见数据表 xbLineModel
    /// </summary>
    public class CxbDevDcLine_Seg : CxbDevGroundLine_Seg
    {
        public CxbDevDcLine_Seg()
        {
            StaCount = 2;
            dotCount = 4;
        }
    }//end CxbDevDcLine_Seg

}//end namespace xbDev