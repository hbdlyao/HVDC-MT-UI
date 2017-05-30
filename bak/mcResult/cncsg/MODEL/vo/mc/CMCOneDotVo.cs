using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cn.csg.dpcp.model.vo.mc
{
    public class CMCOneDotVo : CMCDeviceVo
    {
        public CMCOneDotVo()
        {
            DotCount = 1;
            NodeIDs = new int[1];
            NodeIDs[0] = -2;
            NodeNames = new string[1];
            NodeNames[0] = "none";
        }
    }
}
