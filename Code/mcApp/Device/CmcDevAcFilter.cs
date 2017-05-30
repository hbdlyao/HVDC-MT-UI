///////////////////////////////////////////////////////////
//  CmcDevAcFilter.cs
//  Implementation of the Class CmcDevAcFilter
//  Generated by Enterprise Architect
//  Created on:      09-5月-2017 17:08:07
//  Original author: open2
///////////////////////////////////////////////////////////


namespace Hvdc.MT.mc.Device
{
    /// <summary>
    /// 主回路 交流滤波器
    /// </summary>
    public class CmcDevAcFilter : CmcDevShunt
    {
        /// <summary>
        /// 滤波器额定无功
        /// </summary>
        private double f_QacfN;
        /// <summary>
        /// 交流电网额定无功
        /// </summary>
        private double f_QacN;

        /// <summary>
        /// 网侧额定交流电压
        /// </summary>
        private double f_UacN;

        public double QacfN
        {
            get
            {
                return f_QacfN;
            }

            set
            {
                f_QacfN = value;
            }
        }

        public double QacN
        {
            get
            {
                return f_QacN;
            }

            set
            {
                f_QacN = value;
            }
        }

        public double UacN
        {
            get
            {
                return f_UacN;
            }

            set
            {
                f_UacN = value;
            }
        }
    }//end CmcDevAcFilter

}//end namespace mcDev