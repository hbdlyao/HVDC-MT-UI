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
    public class CMCGroundLineDAL : BaseDAL<CMCGroundLineVo>
    {
        protected override CMCGroundLineVo FillVo4Batch(OleDbDataReader reader)
        {
            CMCGroundLineVo vo = new CMCGroundLineVo();
            Fill(vo, reader);
            return vo;
        }

        protected override void Fill(CMCGroundLineVo vo, OleDbDataReader reader)
        {
            vo.ID = (int)reader["ID"];
            vo.DeviceID = reader["DeviceID"].ToString();
            vo.DeviceName = reader["DeviceName"].ToString();
            vo.DeviceType = (int)reader["DeviceType"];
            //vo.Zr = (double)reader["Zr"];

            //Yao:2017-5-8
            //vo.ZrMax = (double)reader["ZrMax"];
            //vo.ZrMin = (double)reader["ZrMin"];

            //vo.ZrType = (double)reader["ZrType"];
            //vo.DotCount = (int)reader["DotCount"];

            //Yao:2017-5-9
            //GoundLine在主回路中是单端设备
            vo.NodeIDs[0] = (int)reader["NodeID"];           
            vo.NodeNames[0] = reader["NodeName"].ToString();

            //vo.Z_L = (double)reader["Z_L"];
            //vo.Z_C = (double)reader["Z_C"];
            //vo.Zx_L = (double)reader["Zx_L"];
            //vo.Zx_C = (double)reader["Zx_C"];
            vo.StationName = (string)reader["StationName"];
        }

        protected override int Addnew(CMCGroundLineVo vo, string tableName)
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

                //sql.Append(", Zr");
                //param.Append(", ").Append(vo.Zr);

                sql.Append(", ZrMax");
                param.Append(", ").Append(vo.ZrMax);

                sql.Append(", ZrMin");
                param.Append(", ").Append(vo.ZrMin);

                //sql.Append(", ZrType");
                //param.Append(", ").Append(vo.ZrType);

                //sql.Append(", DotCount");
                //param.Append(", ").Append(vo.DotCount);

                sql.Append(", NodeID1");
                param.Append(", ").Append(vo.NodeIDs[0]);

                sql.Append(", NodeID2");
                param.Append(", ").Append(vo.NodeIDs[1]);

                sql.Append(", NodeName2");
                param.Append(", '").Append(vo.NodeNames[1]).Append("'");

                //sql.Append(", Z_L");
                //param.Append(", ").Append(vo.Z_L);

                //sql.Append(", Z_C");
                //param.Append(", ").Append(vo.Z_C);

                //sql.Append(", Zx_C");
                //param.Append(", ").Append(vo.Zx_C);

                //sql.Append(", Zx_L");
                //param.Append(", ").Append(vo.Zx_L);

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

        protected override int Update(CMCGroundLineVo vo, string tableName)
        {
            //CMCAcSystemVo vo = baseVo as CMCAcSystemVo;
            StringBuilder sql = new StringBuilder();//当时在这里定义，是为了在出现异常的时候看看我的SQL语句是否正确
            using (OleDbConnection conn = CreateConnection())
            {
                sql.Append("UPDATE ").Append(tableName);
                sql.Append(" SET DeviceName='").Append(vo.DeviceName).Append("'");
                sql.Append(", DeviceType=").Append(vo.DeviceType);
                //sql.Append(", Zr=").Append(vo.Zr);
                sql.Append(", ZrMax=").Append(vo.ZrMax);
                sql.Append(", ZrMin=").Append(vo.ZrMin);
                //sql.Append(", ZrType=").Append(vo.ZrType);
                //sql.Append(", DotCount=").Append(vo.DotCount);
                sql.Append(", NodeID1=").Append(vo.NodeIDs[0]);
                sql.Append(", NodeID2=").Append(vo.NodeIDs[1]);
                sql.Append(" NodeName1='").Append(vo.NodeNames[0]).Append("'");
                sql.Append(" NodeName2='").Append(vo.NodeNames[1]).Append("'");
                //sql.Append(", Z_L=").Append(vo.Z_L);
                //sql.Append(", Z_C=").Append(vo.Z_C);
                //sql.Append(", Zx_L=").Append(vo.Zx_L);
                //sql.Append(", Zx_C=").Append(vo.Zx_C);
                sql.Append(", StationName='").Append(vo.StationName).Append("'");
                sql.Append(" WHERE ID = ").Append(vo.ID);
                //定义command对象，并执行相应的SQL语句
                OleDbCommand myCommand = new OleDbCommand(sql.ToString(), conn);
                return vo.ID;
            }
        }
    }
}
