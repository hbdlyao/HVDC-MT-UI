using cn.csg.dpcp.common;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace cn.csg.dpcp.dal
{
    public class CBasicDAL
    {
        protected const string connstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";

        public virtual void initDBConn() { }

        protected OleDbConnection CreateConnection()
        {
            string vStr;

            vStr = connstr + DBConfig.get(Constants.AccessDBPath);

            OleDbConnection conn = new OleDbConnection(vStr);
            conn.Open();
            return conn;
        }
    }
}
