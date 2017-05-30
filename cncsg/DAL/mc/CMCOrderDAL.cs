using cn.csg.dpcp.model.vo.mc;
using System;
using System.Data.OleDb;
using System.Text;

namespace cn.csg.dpcp.dal.mc
{
    public class CMCOrderDAL : BaseDAL<CMCOrderVo>
    {
        protected override CMCOrderVo FillVo4Batch(OleDbDataReader reader)
        {
            CMCOrderVo vo = new CMCOrderVo();
            Fill(vo, reader);
            return vo;
        }

        protected override void Fill(CMCOrderVo vo, OleDbDataReader reader)
        {
            vo.ID = (int)reader["ID"];
            //vo.DeviceID = reader["DeviceID"].ToString();
            //vo.DeviceName = reader["DeviceName"].ToString();
            //vo.DeviceType = (int)reader["DeviceType"];
            vo.S12Count = (int)(reader["S12Count"]);
            vo.DRun = (int)reader["DRun"];
            vo.SGround = (int)reader["SGround"];
            vo.SMetal = (int)reader["SMetal"];
            vo.DcUdAll = (int)reader["DcUdAll"];
            vo.DcUd80 = (int)reader["DcUd80"];
            vo.DcUd70 = (int)reader["DcUd70"];
            vo.DcHZr = (int)reader["DcHZr"];
            vo.DcLZr = (int)reader["DcLZr"];
            vo.RAcUdMax = (int)reader["RAcUdMax"];
            vo.RAcUdN = (int)reader["RAcUdN"];
            vo.RAcUdLow = (int)reader["RAcUdLow"];
            vo.RAcUdLowest = (int)reader["RAcUdLowest"];
            vo.BAcUdC = (int)reader["BAcUdC"];
            vo.BAcUdNE = (int)reader["BAcUdNE"];
            vo.GroundLineAc = (int)reader["GroundLineAc"];
            vo.Ud = (double)reader["Ud"];
            vo.Pd = (double)reader["Pd"];
            vo.DcId = (double)reader["DcId"];
            vo.BdStart = (double)reader["BdStart"];
            vo.BdIncre = (double)reader["BdIncre"];
            vo.BdSize = (double)reader["BdSize"];
            vo.IsBdSingle = (int)reader["IsBdSingle"];
        }

        protected override int Addnew(CMCOrderVo vo, string tableName)
        {
            using (OleDbConnection conn = CreateConnection())
            {
                OleDbCommand cmd = new OleDbCommand("delete from " + tableName, conn);
                try {
                    // 只存在一行数据，新增之前先删除
                    cmd.Transaction = conn.BeginTransaction();
                    //cmd.Transaction.Begin(); // 开事务
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = buildInsertSql(vo, tableName);
                    cmd.ExecuteNonQuery();
                    cmd.Transaction.Commit();
                    return 10000;
                }
                catch (Exception e)
                {
                    e.GetType();
                    cmd.Transaction.Rollback(); // 事务回滚确保两次操作一致性
                    return -1;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private string buildInsertSql(CMCOrderVo vo, string tableName)
        {
            StringBuilder sql = new StringBuilder();
            StringBuilder param = new StringBuilder();
            sql.Append("INSERT INTO ").Append(tableName).Append(" (");
            param.Append(" VALUES (");

            sql.Append(" S12Count");
            param.Append(" ").Append(vo.S12Count);

            sql.Append(", DRun");
            param.Append(", ").Append(vo.DRun);

            sql.Append(", SGround");
            param.Append(", ").Append(vo.SGround);

            sql.Append(", SMetal");
            param.Append(", ").Append(vo.SMetal);

            sql.Append(", DcUdAll");
            param.Append(", ").Append(vo.DcUdAll);

            sql.Append(", DcUd80");
            param.Append(", ").Append(vo.DcUd80);

            sql.Append(", DcUd70");
            param.Append(", ").Append(vo.DcUd70);

            sql.Append(", DcHZr");
            param.Append(", ").Append(vo.DcHZr);

            sql.Append(", DcLZr");
            param.Append(", ").Append(vo.DcLZr);

            sql.Append(", RAcUdMax");
            param.Append(", ").Append(vo.RAcUdMax);

            sql.Append(", RAcUdN");
            param.Append(", ").Append(vo.RAcUdN);

            sql.Append(", RAcUdLow");
            param.Append(", ").Append(vo.RAcUdLow);

            sql.Append(", RAcUdLowest");
            param.Append(", ").Append(vo.RAcUdLowest);

            sql.Append(", BAcUdC");
            param.Append(", ").Append(vo.BAcUdC);

            sql.Append(", BAcUdNE");
            param.Append(", ").Append(vo.BAcUdNE);

            sql.Append(", GroundLineAc");
            param.Append(", ").Append(vo.GroundLineAc);

            sql.Append(", Ud");
            param.Append(", ").Append(vo.Ud);

            sql.Append(", Pd");
            param.Append(", ").Append(vo.Pd);

            sql.Append(", DcId");
            param.Append(", ").Append(vo.DcId);

            sql.Append(", BdStart");
            param.Append(", ").Append(vo.BdStart);

            sql.Append(", BdIncre");
            param.Append(", ").Append(vo.BdIncre);

            sql.Append(", BdSize");
            param.Append(", ").Append(vo.BdSize);

            sql.Append(", IsBdSingle");
            param.Append(", ").Append(vo.IsBdSingle);

            sql.Append(")");
            param.Append(");");
            sql.Append(param);
            return sql.ToString();
        }

        protected override int Update(CMCOrderVo vo, string tableName)
        {
            StringBuilder sql = new StringBuilder();//当时在这里定义，是为了在出现异常的时候看看我的SQL语句是否正确
            using (OleDbConnection conn = CreateConnection())
            {
                sql.Append("UPDATE ").Append(tableName).Append(" SET ");
                sql.Append(" S12Count=").Append(vo.S12Count);
                sql.Append(", DRun=").Append(vo.DRun);
                sql.Append(", SGround=").Append(vo.SGround);
                sql.Append(", SMetal=").Append(vo.SMetal);
                sql.Append(", DcUdAll=").Append(vo.DcUdAll);
                sql.Append(", DcUd80=").Append(vo.DcUd80);
                sql.Append(", DcUd70=").Append(vo.DcUd70);
                sql.Append(", DcHZr=").Append(vo.DcHZr);
                sql.Append(", DcLZr=").Append(vo.DcLZr);
                sql.Append(", RAcUdMax=").Append(vo.RAcUdMax);
                sql.Append(", RAcUdN=").Append(vo.RAcUdN);
                sql.Append(", RAcUdLow=").Append(vo.RAcUdLow);
                sql.Append(", RAcUdLowest=").Append(vo.RAcUdLowest);
                sql.Append(", BAcUdC=").Append(vo.BAcUdC);
                sql.Append(", BAcUdNE=").Append(vo.BAcUdNE);
                sql.Append(", Ud=").Append(vo.Ud);
                sql.Append(", Pd=").Append(vo.Pd);
                sql.Append(", DcId=").Append(vo.DcId);
                sql.Append(", Start=").Append(vo.BdStart);
                sql.Append(", Incre=").Append(vo.BdIncre);
                sql.Append(", Size=").Append(vo.BdSize);
                sql.Append(", IsSingle=").Append(vo.IsBdSingle);
                sql.Append(" WHERE ID = ").Append(vo.ID);
                //定义command对象，并执行相应的SQL语句
                OleDbCommand myCommand = new OleDbCommand(sql.ToString(), conn);
                return vo.ID;
            }
        }

        /// <summary>
        /// 只有一行记录
        /// </summary>
        /// <param name="vo"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public override bool Remove(CMCOrderVo vo, string tableName)
        {
            string sql = "delete from " + tableName;
            using (OleDbConnection conn = CreateConnection())
            {
                OleDbCommand myCommand = new OleDbCommand(sql, conn);
                int result = myCommand.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}
