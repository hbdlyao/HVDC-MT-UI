using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cn.csg.dpcp.model.vo.mc
{
    public class CMCGroundLineVo : CMCTwoDotVo
    {
        public CMCGroundLineVo()
        {
            DeviceType = cn.csg.dpcp.common.DeviceType.MCGroundLine;

        }
        /// <summary>
        /// 送端换流站名称
        /// </summary>
        public string StationName1 { set; get; }
        /// <summary>
        /// 受端换流站名称
        /// </summary>
        public string StationName2 { set; get; }
        /// <summary>
        /// 电阻最大值
        /// </summary>
        public double ZrMax { set; get; }
        /// <summary>
        /// 电阻最小值
        /// </summary>
        public double ZrMin { set; get; }
        /// <summary>
        /// 电感
        /// </summary>
        public double Z_L { set; get; }
        /// <summary>
        /// 电容
        /// </summary>
        public double Z_C { set; get; }
        /// <summary>
        /// 感抗
        /// </summary>
        public double Zx_L { set; get; }
        /// <summary>
        /// 容抗
        /// </summary>
        public double Zx_C { set; get; }
    }
}
