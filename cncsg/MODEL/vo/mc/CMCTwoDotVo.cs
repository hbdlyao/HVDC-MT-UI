using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cn.csg.dpcp.model.vo.mc
{
    public class CMCTwoDotVo : CMCDeviceVo
    {
        public CMCTwoDotVo()
        {
            DotCount = 2;
            NodeIDs = new int[2];
            NodeNames = new string[2];
            NodeIDs[0] = -2;
            NodeIDs[1] = -2;
            NodeNames[0] = "none0";
            NodeNames[1] = "none1";
        }
    }
}
