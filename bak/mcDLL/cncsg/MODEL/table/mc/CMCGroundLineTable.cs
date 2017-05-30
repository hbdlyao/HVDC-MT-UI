﻿using cn.csg.dpcp.model.vo;
using cn.csg.dpcp.model.vo.mc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cn.csg.dpcp.model.table.mc
{
    public class CMCGroundLineTable : CBaseTable<CMCGroundLineVo>
    {
        public CMCGroundLineTable()
        {
            SetTableName("mcGroundLine");
        }
    }
}