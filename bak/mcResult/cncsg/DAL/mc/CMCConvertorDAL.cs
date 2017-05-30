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
    public class CMCConvertorDAL : BaseDAL<CMCConvertorVo>
    {
        protected override CMCConvertorVo FillVo4Batch(OleDbDataReader reader)
        {
            CMCConvertorVo vo = new CMCConvertorVo();
            Fill(vo, reader);
            return vo;
        }

        protected override void Fill(CMCConvertorVo vo, OleDbDataReader reader)
        {
            vo.ID = (int)reader["ID"];
            vo.DeviceID = reader["DeviceID"].ToString();
            vo.DeviceName = reader["DeviceName"].ToString();
            vo.DeviceType = (int)reader["DeviceType"];
            //vo.Ahlpa_gama = (double)reader["Alhpa_gama"];
            vo.Alpha_gamaN = (double)reader["Alpha_gamaN"];
            //vo.AngleMax = (double)reader["AngleMax"];
            vo.AngleMin = (double)reader["AngleMin"];
            vo.StationCtrlType = (int)reader["StationCtrlType"];
            vo.StationType = (int)reader["StationType"];
            //vo.CtrlType = (int)reader["CtrlType"];
            //vo.drN = (double)reader["drN"];
            //vo.dxN = (double)reader["dxN"];
            //vo.LengthToSide = (double)reader["LengthToSide"];
            //vo.Pd = (double)reader["Pd"];
            vo.PdN = (double)reader["PdN"];
            //vo.Ud = (double)reader["Ud"];
            vo.UdN = (double)reader["UdN"];
            vo.UT = (double)reader["UT"];
            vo.Valvor12Count = (int)reader["Valvor12Count"];

            //Yao:2017-5-9
            //vo.Qmin = (double)reader["Qmin"];
            //vo.Angle_DeltaType = (double)reader["Angle_DeltaType"];
            //vo.AngleDeltaPMax = (double)reader["AngleDeltaPMax"];
            //vo.AngleDeltaVect = (double)reader["AngleDeltaVect"];
            //vo.DcId = (double)reader["DcId"];

            vo.IsGround = (int)reader["IsGround"];

            vo.DcIdN = (double)reader["DcIdN"];
            //vo.DotCount = (int)reader["dotCount"];
            vo.NodeIDs[0] = (int)reader["NodeID1"];
            vo.NodeNames[0] = reader["NodeName1"].ToString();
            vo.NodeIDs[1] = (int)reader["NodeID2"];
            vo.NodeNames[1] = reader["NodeName2"].ToString();
            vo.StationName = reader["StationName"].ToString();
        }

        protected override int Addnew(CMCConvertorVo vo, string tableName)
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

                //sql.Append(", Alhpa_gama");
                //param.Append(", ").Append(vo.Alhpa_gama);

                sql.Append(", Alpha_gamaN");
                param.Append(", ").Append(vo.Alpha_gamaN);

                //sql.Append(", AngleMax");
                //param.Append(", ").Append(vo.AngleMax);

                sql.Append(", AngleMin");
                param.Append(", ").Append(vo.AngleMin);

                sql.Append(", StationCtrlType");
                param.Append(", ").Append(vo.StationCtrlType);

                sql.Append(", StationType");
                param.Append(", ").Append(vo.StationType);

                //sql.Append(", drN");
                //param.Append(", ").Append(vo.drN);

                //sql.Append(", dxN");
                //param.Append(", ").Append(vo.dxN);

                //sql.Append(", LengthToSide");
                //param.Append(", ").Append(vo.LengthToSide);

                //sql.Append(", Pd");
                //param.Append(", ").Append(vo.Pd);

                sql.Append(", PdN");
                param.Append(", ").Append(vo.PdN);

                sql.Append(", UdN");
                param.Append(", ").Append(vo.UdN);

                //sql.Append(", Ud");
                //param.Append(", ").Append(vo.Ud);

                sql.Append(", UT");
                param.Append(", ").Append(vo.UT);

                sql.Append(", Valvor12Count");
                param.Append(", ").Append(vo.Valvor12Count);

                sql.Append(", Qmin");
                param.Append(", ").Append(vo.Qmin);

                sql.Append(", Angle_DeltaType");
                param.Append(", ").Append(vo.Angle_DeltaType);

                sql.Append(", AngleDeltaPMax");
                param.Append(", ").Append(vo.AngleDeltaPMax);

                sql.Append(", AngleDeltaVect");
                param.Append(", ").Append(vo.AngleDeltaVect);

                sql.Append(", IsGround");
                param.Append(", ").Append(vo.IsGround);

                sql.Append(", DcIdN");
                param.Append(", ").Append(vo.DcIdN);

                sql.Append(", DcId");
                param.Append(", ").Append(vo.DcId);

                sql.Append(", dotCount");
                param.Append(", ").Append(vo.DotCount);

                sql.Append(", NodeID1");
                param.Append(", ").Append(vo.NodeIDs[0]);

                sql.Append(",NodeName1");
                param.Append(", '").Append(vo.NodeNames[0]).Append("'");

                sql.Append(", NodeID2");
                param.Append(", ").Append(vo.NodeIDs[1]);

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

        protected override int Update(CMCConvertorVo vo, string tableName)
        {
            //CMCAcSystemVo vo = baseVo as CMCAcSystemVo;
            StringBuilder sql = new StringBuilder();//当时在这里定义，是为了在出现异常的时候看看我的SQL语句是否正确

            using (OleDbConnection conn = CreateConnection())
            {
                sql.Append("UPDATE ").Append(tableName);
                sql.Append(" SET DeviceName='").Append(vo.DeviceName).Append("'");
                sql.Append(", DeviceType=").Append(vo.DeviceType);
                //sql.Append(", Alhpa_gama=").Append(vo.Alhpa_gama);
                sql.Append(", Alpha_gamaN=").Append(vo.Alpha_gamaN);
                //sql.Append(", AngleMax=").Append(vo.AngleMax);
                sql.Append(", AngleMin=").Append(vo.AngleMin);
                sql.Append(", StationCtrlType=").Append(vo.StationCtrlType);
                sql.Append(", StationType=").Append(vo.StationType);
                //sql.Append(", drN=").Append(vo.drN);
                //sql.Append(", dxN=").Append(vo.dxN);
                //sql.Append(", LengthToSide=").Append(vo.LengthToSide);
                //sql.Append(", Pd=").Append(vo.Pd);
                sql.Append(", PdN=").Append(vo.PdN);
                //sql.Append(", Ud=").Append(vo.Ud);
                sql.Append(", UdN=").Append(vo.UdN);
                sql.Append(", UT=").Append(vo.UT);
                sql.Append(", Valvor12Count=").Append(vo.Valvor12Count);
                sql.Append(", Qmin=").Append(vo.Qmin);
                sql.Append(", Angle_DeltaType=").Append(vo.Angle_DeltaType);
                sql.Append(", AngleDeltaPMax=").Append(vo.AngleDeltaPMax);
                sql.Append(", AngleDeltaVect=").Append(vo.AngleDeltaVect);
                sql.Append(", IsGround=").Append(vo.IsGround);
                sql.Append(", DcId=").Append(vo.DcId);
                sql.Append(", DcIdN=").Append(vo.DcIdN);
                sql.Append(", dotCount=").Append(vo.DotCount);
                sql.Append(", NodeID1=").Append(vo.NodeIDs[0]);
                sql.Append(" NodeName1='").Append(vo.NodeNames[0]).Append("'");
                sql.Append(", NodeID2=").Append(vo.NodeIDs[1]);
                sql.Append(" NodeName2='").Append(vo.NodeNames[1]).Append("'");
                sql.Append(", StationName='").Append(vo.StationName).Append("'");
                sql.Append(" WHERE ID = ").Append(vo.ID);
                //定义command对象，并执行相应的SQL语句
                OleDbCommand myCommand = new OleDbCommand(sql.ToString(), conn);
                return vo.ID;
            }
        }
    }
}
