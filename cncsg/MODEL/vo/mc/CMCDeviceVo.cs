using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Yao.BaseFrame.Device;

namespace cn.csg.dpcp.model.vo.mc
{
    public class CMCDeviceVo : CBasicVo
    {
        public string DeviceID { set; get; }
        public string DeviceName { set; get;}
        public int DeviceType { set; get; }
        public string StationName { set; get; }
        public int DotCount { set; get; }
        public int[] NodeIDs { set; get; }
        public string[] NodeNames { set; get; }
    }
}
