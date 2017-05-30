using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cn.csg.dpcp.model.vo.mc
{
    public class CXBpbDkqVo : CMCDeviceVo
    {
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
