using cn.csg.dpcp.model.vo;
using cn.csg.dpcp.model.vo.mc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cn.csg.dpcp.model.table.mc
{
    public class CMCDeviceTable<T> : CBaseTable<CMCDeviceVo>
    {
        public CMCDeviceTable()
        {
            VoList = new List<CMCDeviceVo>();
        }
        public CMCDeviceVo FindByDeviceID(string deviceID)
        {
            if (VoList != null)
            {
                foreach(CMCDeviceVo vo in VoList)
                {
                    if (deviceID.Equals(deviceID))
                    {
                        return vo;
                    }
                }
            }
            return null;
        }

        public bool IsContainsByDeviceID(string voDeviceID)
        {
            return FindByDeviceID(voDeviceID) != null;
        }

        public bool IsContainsByDeviceID(CMCDeviceVo vo)
        {
            if (vo != null)
            {
                return IsContainsByDeviceID(vo.DeviceID);
            }
            return false;
        }

    }
}
