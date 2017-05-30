using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cn.csg.dpcp.model;
using System.Data.OleDb;
using cn.csg.dpcp.common;
using cn.csg.dpcp.model.vo;
using cn.csg.dpcp.model.table;

using Yao.BaseFrame.Device;

namespace cn.csg.dpcp.dal
{
    public class BaseDAL<T> : CBasicDAL where T : CBasicVo
    {

        // update2017031
        #region

        protected bool queryExists(T t, string tableName)
        {
            using (OleDbConnection conn = CreateConnection())
            {
                bool isExists = false;
                string sql = "Select * from " + tableName + " where ID = " + t.ID;
                OleDbCommand myCommand = new OleDbCommand(sql, conn);
                OleDbDataReader reader = myCommand.ExecuteReader(); //执行command并得到相应的DataReader
                isExists = reader.Read();
                return isExists;
            }
        }

        public bool Query(T t, string tableName) { return Load(t, tableName); }

        public bool QueryList(string tableName, IList<T> list)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from ").Append(tableName);
            using (OleDbConnection conn = CreateConnection())
            {
                OleDbCommand myCommand = new OleDbCommand(sql.ToString(), conn);
                OleDbDataReader reader = myCommand.ExecuteReader(); //执行command并得到相应的DataReader
                while (reader.Read())
                {
                    T t = FillVo4Batch(reader);
                    list.Add(t);
                }
            }
                return true;
        }

        protected virtual T FillVo4Batch(OleDbDataReader reader) { return null; }

        public virtual int Save(T t, string tableName)
        {
            if (!queryExists(t, tableName))
            {
                return Addnew(t, tableName);
            }
            else
            {
                return Update(t, tableName);
            }
        }

        protected virtual int Addnew(T t, string tableName) { return -1; }

        protected virtual int Update(T t, string tableName) { return -1; }

        public virtual bool SaveList(CBaseTable<T> baseTable)
        {
            if (baseTable.VoList == null || baseTable.VoList.Count == 0)
            {
                return false;
            }
            foreach (T t in baseTable.VoList)
            {
                Save(t, baseTable.tableName);
            }
            return true;
        }

        protected bool Load(T t, string tableName)
        {
            if (t == null)
            {
                return false;
            }
            using (OleDbConnection conn = CreateConnection())
            {
                    string sql = "Select * from " + tableName + "where ID = " + t.ID;
                    OleDbCommand myCommand = new OleDbCommand(sql, conn);
                    OleDbDataReader reader = myCommand.ExecuteReader(); //执行command并得到相应的DataReader
                    if (reader.Read())
                    {
                        Fill(t, reader);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }
        }

        protected virtual void Fill(T t, OleDbDataReader reader) { }

        public virtual bool Remove(T t, string tableName)
        {
            if (t == null)
            {
                return false;
            }
            string sql = "delete from " + tableName + " where ID = '" + t.ID + "'";
            using(OleDbConnection conn = CreateConnection())
            {
                OleDbCommand myCommand = new OleDbCommand(sql, conn);
                int result = myCommand.ExecuteNonQuery();
                return result > 0;
            }
        }

        #endregion
    }
}
