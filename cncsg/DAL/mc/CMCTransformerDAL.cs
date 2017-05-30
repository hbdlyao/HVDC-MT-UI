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
    public class CMCTransformerDAL : BaseDAL<CMCTransformerVo>
    {
        protected override CMCTransformerVo FillVo4Batch(OleDbDataReader reader)
        {
            CMCTransformerVo vo = new CMCTransformerVo();
            Fill(vo, reader);
            return vo;
        }

        protected override void Fill(CMCTransformerVo vo, OleDbDataReader reader)
        {
            vo.ID = (int)reader["ID"];
            vo.DeviceID = reader["DeviceID"].ToString();
            vo.DeviceName = reader["DeviceName"].ToString();
            vo.DeviceType = (int)reader["DeviceType"];
            vo.AngleMax = (double)reader["AngleMax"];
            vo.AngleMin = (double)reader["AngleMin"];
            vo.TapCtrlType = (int)reader["TapCtrlType"];
            vo.FixedURef = (double)reader["FixedURef"];
            
            //Yao:2017-5-9
            //vo.SN = (double)reader["SN"];

            vo.TapMax = (int)reader["TapMax"];
            vo.TapMin = (int)reader["TapMin"];
            vo.TapN = (int)reader["TapN"];
            vo.TapSetup = (double)reader["TapSetup"];

            vo.UacN = (double)reader["UacN"];
            vo.UvMax = (double)reader["UvMax"];
            vo.Ukp = (double)reader["Ukp"];
            vo.Urp = (double)reader["Urp"];

            //vo.DotCount = (int)reader["DotCount"];
            vo.NodeIDs[0] = (int)reader["NodeID1"];
            vo.NodeIDs[1] = (int)reader["NodeID2"];
            vo.NodeNames[0] = reader["NodeName1"].ToString();
            vo.NodeNames[1] = reader["NodeName2"].ToString();
            vo.StationName = reader["StationName"].ToString();
        }

        protected override int Addnew(CMCTransformerVo vo, string tableName)
        {
            int id = -1;
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

                sql.Append(", AngleMax");
                param.Append(", ").Append(vo.AngleMax);

                sql.Append(", AngleMin");
                param.Append(", ").Append(vo.AngleMin);

                sql.Append(", TapCtrlType");
                param.Append(", ").Append(vo.TapCtrlType);

                sql.Append(", FixedURef");
                param.Append(", ").Append(vo.FixedURef);

                sql.Append(", SN");
                param.Append(", ").Append(vo.SN);

                sql.Append(", TapMax");
                param.Append(", ").Append(vo.TapMax);

                sql.Append(", TapMin");
                param.Append(", ").Append(vo.TapMin);

                sql.Append(", TapN");
                param.Append(", ").Append(vo.TapN);

                sql.Append(", UacN");
                param.Append(", ").Append(vo.UacN);

                sql.Append(", UvMax");
                param.Append(", ").Append(vo.UvMax);

                sql.Append(", Ukp");
                param.Append(", ").Append(vo.Ukp);

                sql.Append(", Urp");
                param.Append(", ").Append(vo.Urp);

                sql.Append(", TapSetup");
                param.Append(", ").Append(vo.TapSetup);

                //sql.Append(", DotCount");
                //param.Append(", ").Append(vo.DotCount);

                sql.Append(", NodeID1");
                param.Append(", ").Append(vo.NodeIDs[0]);

                sql.Append(", NodeID2");
                param.Append(", ").Append(vo.NodeIDs[1]);

                sql.Append(", NodeName1");
                param.Append(", '").Append(vo.NodeNames[0]).Append("'");

                sql.Append(", NodeName2");
                param.Append(", '").Append(vo.NodeNames[1]).Append("'");

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

        protected override int Update(CMCTransformerVo vo, string tableName)
        {
            //CMCAcSystemVo vo = baseVo as CMCAcSystemVo;
            StringBuilder sql = new StringBuilder();//当时在这里定义，是为了在出现异常的时候看看我的SQL语句是否正确
            using (OleDbConnection conn = CreateConnection())
            {
                sql.Append("UPDATE ").Append(tableName);
                sql.Append(" SET DeviceName='").Append(vo.DeviceName).Append("'");
                sql.Append(", DeviceType=").Append(vo.DeviceType);
                sql.Append(", AngleMax=").Append(vo.AngleMax);
                sql.Append(", AngleMin=").Append(vo.AngleMin);
                sql.Append(", TapCtrlType=").Append(vo.TapCtrlType);
                sql.Append(", FixedURef=").Append(vo.FixedURef);
                sql.Append(", SN=").Append(vo.SN);
                sql.Append(", TapMax=").Append(vo.TapMax);
                sql.Append(", TapMin=").Append(vo.TapMin);
                sql.Append(", TapN=").Append(vo.TapN);
                sql.Append(", UacN=").Append(vo.UacN);
                sql.Append(", UvMax=").Append(vo.UvMax);
                sql.Append(", Ukp=").Append(vo.Ukp);
                sql.Append(", Urp=").Append(vo.Urp);
                sql.Append(", TapSetup=").Append(vo.TapSetup);
                //sql.Append(", DotCount=").Append(vo.DotCount);
                sql.Append(", NodeID1=").Append(vo.NodeIDs[0]);
                sql.Append(", NodeID2=").Append(vo.NodeIDs[1]);
                sql.Append(", NodeName1='").Append(vo.NodeNames[0]).Append("'");
                sql.Append(", NodeName2='").Append(vo.NodeNames[1]).Append("'");
                sql.Append(", StationName='").Append(vo.StationName).Append("'");
                sql.Append(" WHERE ID = ").Append(vo.ID);
                //定义command对象，并执行相应的SQL语句
                OleDbCommand myCommand = new OleDbCommand(sql.ToString(), conn);
                return vo.ID;
            }
        }
    }
}
