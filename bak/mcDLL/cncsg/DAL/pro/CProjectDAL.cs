using cn.csg.dpcp.model.vo;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace cn.csg.dpcp.dal.pro
{
    public class CProjectDAL : CBasicDAL
    {
        public bool IsProjectExist(CNewProjectVo vo)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select ID from Project Where ProjectName='").Append(vo.ProjectName).Append("'");
            using (OleDbConnection conn = CreateConnection())
            {
                OleDbCommand myCommand = new OleDbCommand(sql.ToString(), conn);
                OleDbDataReader reader = myCommand.ExecuteReader();
                bool isExists = reader.Read();
                return isExists;
            }
        }

        public int SaveProject(CNewProjectVo vo)
        {
            int id = -1;
            StringBuilder sql = new StringBuilder();
            StringBuilder param = new StringBuilder();
            using(OleDbConnection conn = CreateConnection())
            {
                sql.Append("INSERT INTO ").Append("Project").Append(" (");
                param.Append(" VALUES (");

                sql.Append(" Projectname ");
                param.Append(" '").Append(vo.ProjectName).Append("'");

                sql.Append(", StationCount ");
                param.Append(", ").Append(vo.StationCount);

                sql.Append(")");
                param.Append(");");
                sql.Append(param);

                OleDbCommand cmd = new OleDbCommand(sql.ToString(), conn);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand("select @@identity as id", conn);
                id = Convert.ToInt32(cmd.ExecuteScalar());
                return id;
            }
        }
    }
}
