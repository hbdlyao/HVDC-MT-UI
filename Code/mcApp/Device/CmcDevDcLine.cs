///////////////////////////////////////////////////////////
//  CmcDevDcLine.cs
//  Implementation of the Class CmcDevDcLine
//  Generated by Enterprise Architect
//  Created on:      09-5月-2017 17:08:08
//  Original author: open2
///////////////////////////////////////////////////////////




namespace Hvdc.MT.mc.Device
{
    /// <summary>
    /// 主回路 直流极线
    /// </summary>
    public class CmcDevDcLine : CmcDevBranch
    {
        public CmcDevDcLine()
        {
            StaCount = 2;
            dotCount = 2;
        }
        /// <summary>
        /// 电阻最大值
        /// </summary>
        protected double f_ZrMax;
        /// <summary>
        /// 电阻最小值
        /// </summary>
        protected double f_ZrMin;

        /// <summary>
        /// 电阻最大值
        /// </summary>
        public double ZrN
        {
            get
            {
                return f_Zr;
            }
            set
            {
                f_Zr = value;
            }
        }

        /// <summary>
        /// 电阻最大值
        /// </summary>
        public double ZrMax
        {
            get
            {
                return f_ZrMax;
            }
            set
            {
                f_ZrMax = value;
            }
        }

        /// <summary>
        /// 接地类型（单级大地/金属回线/双极）
        /// </summary>
        public double ZrMin
        {
            get
            {
                return f_ZrMin;
            }
            set
            {
                f_ZrMin = value;
            }
        }

    }//end CmcDevDcLine

}//end namespace mcDev