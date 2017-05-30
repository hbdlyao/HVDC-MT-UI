using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cn.csg.dpcp.model.vo.mc
{
    public class CMCGroundVo : CMCOneDotVo
    {
        public CMCGroundVo()
        {
            DeviceType = cn.csg.dpcp.common.DeviceType.MCGround;

        }

        /// <summary>
        /// 电阻
        /// </summary>
        public double Zr { set; get; }
        /// <summary>
        /// 电感
        /// </summary>
        public double Z_L { set; get; }
        /// <summary>
        /// 电电容
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
