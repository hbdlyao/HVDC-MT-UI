using cn.csg.dpcp.model.vo.mc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cn.csg.dpcp.model.table.mc
{
    public class CMCResultTable : CBaseTable<CMCResultVo>
    {
        public CMCResultTable()
        {
            SetTableName("MCResult");
        }

        /// <summary>
        /// 根据工况和站名查数据
        /// </summary>
        /// <param name="order"></param>
        /// <param name="station"></param>
        /// <returns>CMCResultVo</returns>
        public CMCResultVo Find(string caseId, string station)
        {
            if (VoList == null || VoList.Count == 0)
            {
                return null;
            }

            foreach (CMCResultVo vo in VoList)
            {
                if (vo.CaseID.Equals(caseId) && station.Equals(vo.StationName))
                {
                    return vo;
                }
            }
            return null;
        }

    }
}
