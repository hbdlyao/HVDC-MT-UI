using cn.csg.dpcp.model.vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Yao.BaseFrame.Device;

namespace cn.csg.dpcp.model.table
{
    public class CBaseTable<T> where T : CBasicVo
    {
        public IList<T> VoList { set; get; }
        public string tableName;

        public CBaseTable()
        {
            VoList = new List<T>();
        }
        
        protected void SetTableName(string table)
        {
            tableName = table;
        }

        public string GetTableName()
        {
            return tableName;
        }
        
        public T Find(int voID)
        {
            if (VoList != null)
            {
                foreach (T vo in VoList)
                { 
                    if (voID == vo.ID)
                    {
                        return vo;
                    }
                }
            }
            return null;
        }

        public bool IsContains(T vo)
        {
            if (vo != null)
            {
                return Find(vo.ID) != null;
            }
            return false;
        }

        public bool IsContains(int voID)
        {
            return Find(voID) != null;
        }
    }
}
