using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cn.csg.dpcp.model.vo.mc
{
    public class CXBDcFilterVo : CMCOneDotVo
    {
        /// <summary>
        /// 直流滤波器（单调谐/双调谐）
        /// </summary>
        public int DcfType { set; get; }
        /// <summary>
        /// 电容
        /// </summary>
        public double Zc { set; get; }
        /// <summary>
        /// 电阻
        /// </summary>
        public double Zr { set; get; }
        /// <summary>
        /// 电抗
        /// </summary>
        public double Zx { set; get; }
    }
}
