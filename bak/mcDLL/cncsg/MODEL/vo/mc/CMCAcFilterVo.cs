using cn.csg.dpcp.model.vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace cn.csg.dpcp.model.vo.mc
{
    /// <summary>
    /// 主回路 交流滤波器 
    /// </summary>
    public class CMCAcFilterVo : CMCOneDotVo
    {
        public CMCAcFilterVo()
        {
            DeviceType = cn.csg.dpcp.common.DeviceType.MCAcFilter;
        }
        /// <summary>
        /// 交流滤波器类型（单调谐/双调谐）
        /// </summary>
        public int AcfType { set; get; }
        /// <summary>
        /// 滤波器无功
        /// </summary>
        public double Qacf { set; get; }
        /// <summary>
        /// 滤波器额定无功
        /// </summary>
        public double QacfN { set; get; }
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
        /// <summary>
        /// 交流电压
        /// </summary>
        public double Uac { set; get; }
        /// <summary>
        /// 额定交流电压
        /// </summary>
        public double UacN { set; get; }
    }
}
