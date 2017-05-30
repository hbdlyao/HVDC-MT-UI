using cn.csg.dpcp.model;
using cn.csg.dpcp.model.vo;
using cn.csg.dpcp.model.vo.mc;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace cn.csg.dpcp.dal.mc
{
    public class MCCAcSystemDAL : BaseDAL<CMCAcSystemVo>
    {
        protected override CMCAcSystemVo FillVo4Batch(OleDbDataReader reader)
        {
            CMCAcSystemVo vo = new CMCAcSystemVo();
            Fill(vo, reader);
            return vo;
        }

        protected override void Fill(CMCAcSystemVo vo, OleDbDataReader reader)
        {
            vo.ID = (int)reader["ID"];
            vo.DeviceID = reader["DeviceID"].ToString();
            vo.DeviceName = reader["DeviceName"].ToString();
            vo.DeviceType = (int)reader["DeviceType"];
            
            //vo.PacN = (double)reader["PacN"];
           //Yao: 2017-5-9
            // vo.QacN = (double)reader["QacN"];
            //vo.Uac = (double)reader["Uac"];
            vo.UacN = (double)reader["UacN"];
            vo.UacMax = (double)reader["UacMax"];
            vo.UacMin = (double)reader["UacMin"];
            vo.UacExMin = (double)reader["UacExMin"];

            vo.QinMax = (double)reader["QinMax"];
            vo.QoutMax = (double)reader["QoutMax"];

            vo.StationName = reader["StationName"].ToString();
        }

        protected override int Addnew(CMCAcSystemVo vo, string tableName)
        {
            int id = -1;
            //CMCAcSystemVo vo = baseVo as CMCAcSystemVo;
            using (OleDbConnection conn = CreateConnection())
            {
                //设置SQL语句
                StringBuilder sql = new StringBuilder();
                StringBuilder param = new StringBuilder();

                sql.Append("INSERT INTO ").Append(tableName).Append(" (");
                param.Append(" VALUES (");

                sql.Append(" DeviceID");
                param.Append(" '").Append(vo.DeviceID).Append("' ");

                sql.Append(", DeviceName");
                param.Append(", '").Append(vo.DeviceName).Append("'");

                sql.Append(", DeviceType");
                param.Append(", ").Append(vo.DeviceType);

                //sql.Append(", PacN");
                //param.Append(", ").Append(vo.PacN);

                sql.Append(", QacN");
                param.Append(", ").Append(vo.QacN);

                sql.Append(", Uac");
                param.Append(", ").Append(vo.Uac);

                sql.Append(", UacN");
                param.Append(", ").Append(vo.UacN);

                sql.Append(", QinMax");
                param.Append(", ").Append(vo.QinMax);

                sql.Append(", QoutMax");
                param.Append(", ").Append(vo.QoutMax);

                sql.Append(", UacExMin");
                param.Append(", ").Append(vo.UacExMin);

                sql.Append(", UacMax");
                param.Append(", ").Append(vo.UacMax);

                //sql.Append(", UacLevel");
                //param.Append(", ").Append(vo.UacMin);

                sql.Append(", UacMin");
                param.Append(", ").Append(vo.UacMin);

                sql.Append(", StationName");
                param.Append(", '").Append(vo.StationName).Append("'");

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

        protected override int Update(CMCAcSystemVo vo, string tableName)
        {
            //CMCAcSystemVo vo = baseVo as CMCAcSystemVo;
            StringBuilder sql = new StringBuilder();//当时在这里定义，是为了在出现异常的时候看看我的SQL语句是否正确
            using (OleDbConnection conn = CreateConnection())
            {
                sql.Append("UPDATE ").Append(tableName);
                sql.Append(" SET DeviceName='").Append(vo.DeviceName).Append("'");
                sql.Append(", DeviceType=").Append(vo.DeviceType);
                //sql.Append(", PacN=").Append(vo.PacN);
                sql.Append(", QacN=").Append(vo.QacN);
                sql.Append(", Uac=").Append(vo.Uac);
                sql.Append(", UacN=").Append(vo.UacN);
                sql.Append(", QinMax=").Append(vo.QinMax);
                sql.Append(", QoutMax=").Append(vo.QoutMax);
                sql.Append(", UacExMin=").Append(vo.UacExMin);
                sql.Append(", UacMax=").Append(vo.UacMax);
                sql.Append(", UacMin=").Append(vo.UacMin);
                sql.Append(", StationName='").Append(vo.StationName).Append("'");
                sql.Append(" WHERE ID = ").Append(vo.ID);
                //定义command对象，并执行相应的SQL语句
                OleDbCommand myCommand = new OleDbCommand(sql.ToString(), conn);
                return vo.ID;
            }
        }
    }
}
