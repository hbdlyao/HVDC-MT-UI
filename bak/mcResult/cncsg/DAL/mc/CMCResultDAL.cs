using cn.csg.dpcp.common;
using cn.csg.dpcp.model.vo.mc;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Text;

namespace cn.csg.dpcp.dal.mc
{
    public class CMCResultDAL : BaseDAL<CMCResultVo>
    {
        protected override CMCResultVo FillVo4Batch(OleDbDataReader reader)
        {
            CMCResultVo vo = new CMCResultVo();
            Fill(vo, reader);
            return vo;
        }

        protected override void Fill(CMCResultVo vo, OleDbDataReader reader)
        {
            vo.ID = (int)reader["ID"];
            vo.StationName = reader["StationName"].ToString();
            vo.CaseID = reader["CaseID"].ToString();
            vo.alphaOrgamma = (int)reader["alphaOrgamma"];
            vo.PdPer = (double)reader["PdPercent"];
            vo.DcId = (double)reader["DcId"];
            vo.miu = (double)reader["Miu"];
            vo.Pconv = (double)reader["Pconv"];
            vo.Pd = (double)reader["Pd"];
            vo.Qconv = (double)reader["Qconv"];
            vo.Qf_max = (double)reader["Qf_max"];
            vo.Qf_min = (double)reader["Qf_min"];
            vo.TC = (int)reader["TC"];
            vo.Ud = (double)reader["Ud"];
            vo.Udio = (double)reader["Udio"];
            vo.Udio_N = (double)reader["Udio_N"];
            vo.UdL = (double)reader["UdL"];
            vo.Uac = (double)reader["Uac"];
            vo.Uv = (double)reader["Uv"];
            vo.Uv_N = (double)reader["Uv_N"];
        }

        public DataTable QueryResult(string caseId, string stationName)
        {
            //string sql = "select * from mcResult where CaseID = '" + caseId + "' and StationName = '" + stationName + "'";
            StringBuilder sql = new StringBuilder();
            sql.Append(getQueryViewText(caseId, stationName));
            sql.Append(" WHERE CaseID = '").Append(caseId).Append("'");
            sql.Append(" AND StationName = '").Append(stationName).Append("'");
            using (OleDbDataAdapter da = new OleDbDataAdapter(sql.ToString(), CreateConnection()))
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                return dt;
            }
        }

        private string getQueryViewText(string caseId, string stationName)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("CaseId as [功率水平PdPer(%)]");
            sql.Append(", Uac as [网侧电压(kV)]");
            sql.Append(", Udio as [理想空载电压(kV)]");
            sql.Append(", Ud as [直流端口电压(kV)]");
            sql.Append(", UdL as [直流对地电压(kV)]");
            sql.Append(", Udio_N as [额定理想空载电压(kV)]");
            sql.Append(", Uv_N as [额定阀侧电压(kA)]");
            sql.Append(", DcId as [直流电流(kA)]");
            sql.Append(", Pd as [直流功率(kA)]");
            sql.Append(", Pconv as [换流器有功(MW)]");
            sql.Append(", Qconv as [换流器无功]");
            sql.Append(", TC as [变压器抽头档位]");
            sql.Append(", alphaOrgamma as [触发角/关断角(°)]");
            sql.Append(", miu as [换相角(°)]");
            sql.Append(", Qf_max as [滤波器的最大无功(Mvar)]");
            sql.Append(", Qf_min as [滤波器的最小无功(Mvar)]");
            sql.Append(" FROM mcResult ");
            
            return sql.ToString();
        }

        /// <summary>
        /// 查询导出数据
        /// </summary>
        public IList<CMCResultVo> QueryExportList(string caseId, string stationName)
        {
            IList<CMCResultVo> list = new List<CMCResultVo>();
            StringBuilder sql = new StringBuilder();
            sql.Append(getQueryViewText(caseId, stationName));
            sql.Append(" WHERE 1 = 1 ");
            if (null != caseId && !string.Empty.Equals(caseId))
            {
                sql.Append(" and CaseID = '").Append(caseId).Append("'");
            }
            if (null != stationName && !string.Empty.Equals(stationName))
            {
                sql.Append(" and StationName = '").Append(stationName).Append("'");
            }
            using (OleDbConnection conn = CreateConnection())
            {
                OleDbCommand myCommand = new OleDbCommand(sql.ToString(), conn);
                OleDbDataReader reader = myCommand.ExecuteReader(); //执行command并得到相应的DataReader
                while (reader.Read())
                {
                    CMCResultVo t = FillVo4Batch(reader);
                    list.Add(t);
                }
            }
            return list;
        }
    }

}
