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
    public class CMCAcFilterDAL : BaseDAL<CMCAcFilterVo>
    {
        protected override CMCAcFilterVo FillVo4Batch(OleDbDataReader reader)
        {
            CMCAcFilterVo vo = new CMCAcFilterVo();
            Fill(vo, reader);
            return vo;
        }

        protected override void Fill(CMCAcFilterVo vo, OleDbDataReader reader)
        {
            vo.ID = (int)reader["ID"];
            vo.DeviceID = reader["DeviceID"].ToString();
            vo.DeviceName = reader["DeviceName"].ToString();
            vo.DeviceType = (int)reader["DeviceType"];
            //vo.AcfType = (int)reader["AcfType"];
            vo.Qacf = (double)reader["Qacf"];
            vo.QacfN = (double)reader["QacfN"];
            //vo.Zc = (double)reader["Zc"];
            //vo.Zr = (double)reader["Zr"];
            //vo.Zx = (double)reader["Zx"];
            vo.Uac = (double)reader["Uac"];
            vo.UacN = (double)reader["UacN"];

            //vo.DotCount = (int)reader["dotCount"];
            vo.StationName = (string) reader["StationName"].ToString();
            vo.NodeIDs[0] = (int)reader["NodeID"];
            vo.NodeNames[0] = (string) reader["NodeName"].ToString();
        }

        protected override int Addnew(CMCAcFilterVo vo, string tableName)
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

                //sql.Append(", AcfType");
                //param.Append(", ").Append(vo.AcfType);

                sql.Append(", Qacf");
                param.Append(", ").Append(vo.Qacf);

                sql.Append(", QacfN");
                param.Append(", ").Append(vo.QacfN);

                //sql.Append(", Zc");
                //param.Append(", ").Append(vo.Zc);

                //sql.Append(", Zr");
                //param.Append(", ").Append(vo.Zr);

                //sql.Append(", Zx");
                //param.Append(", ").Append(vo.Zx);

                sql.Append(", Uac");
                param.Append(", ").Append(vo.Uac);

                sql.Append(", UacN");
                param.Append(", ").Append(vo.UacN);




                //sql.Append(", dotCount");
                //param.Append(", ").Append(vo.DotCount);

                sql.Append(", StationName");
                param.Append(", '").Append(vo.StationName).Append("'");

                sql.Append(", NodeID");
                param.Append(", '").Append(vo.NodeIDs[0]).Append("'");

                sql.Append(", NodeName");
                param.Append(", '").Append(vo.NodeNames[0]).Append("'");

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

        protected override int Update(CMCAcFilterVo vo, string tableName)
        {
            //CMCAcSystemVo vo = baseVo as CMCAcSystemVo;
            StringBuilder sql = new StringBuilder();//当时在这里定义，是为了在出现异常的时候看看我的SQL语句是否正确
            using (OleDbConnection conn = CreateConnection())
            {
                sql.Append("UPDATE ").Append(tableName);
                sql.Append(" SET DeviceName='").Append(vo.DeviceName).Append("'");
                sql.Append(", DeviceType=").Append(vo.DeviceType);
                //sql.Append(", AcfType=").Append(vo.AcfType);
                sql.Append(", Qacf=").Append(vo.Qacf);
                sql.Append(", QacfN=").Append(vo.QacfN);
                //sql.Append(", Zc=").Append(vo.Zc);
                //sql.Append(", Zr=").Append(vo.Zr);
                //sql.Append(", Zx=").Append(vo.Zx);
                sql.Append(", Uac=").Append(vo.Uac);
                sql.Append(", UacN=").Append(vo.UacN);

                //sql.Append(", dotCount=").Append(vo.DotCount);
                sql.Append(" NodeIDs='").Append(vo.NodeIDs[0]).Append("'");
                sql.Append(" StationName='").Append(vo.StationName).Append("'");
                sql.Append(" NodeNames='").Append(vo.NodeNames[0]).Append("'");

                sql.Append(" WHERE ID = ").Append(vo.ID);

                //定义command对象，并执行相应的SQL语句
                OleDbCommand myCommand = new OleDbCommand(sql.ToString(), conn);
                return vo.ID;
            }
        }
    }
}
