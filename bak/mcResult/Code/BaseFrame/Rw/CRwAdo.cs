///////////////////////////////////////////////////////////
//  CDataRw.cs
//  Implementation of the Class CDataRw
//  Generated by Enterprise Architect
//  Created on:      10-5月-2017 9:23:22
//  Original author: open2
///////////////////////////////////////////////////////////


using System.Data;
using System.Data.OleDb;

namespace Yao.BaseFrame.Rw
{
    /// <summary>
    /// Ado数据库
    /// </summary>
    public class CRwAdo
    {      
        public OleDbConnection  pConnection;
        public OleDbCommand     pCommand;
        public OleDbDataReader  pRecordset;
        //      
        //
        protected string strConnect = "strConnect";

        protected string dbfName = "";

        protected string UserID = "";
        protected string Password = "";

        public OleDbDataReader Reader
        {
            get
            {
                return pRecordset;
            }

            set
            {
                pRecordset = value;
            }
        }

        /// <summary>
        /// StrTable dbfTable;
        /// </summary>
        /// <param name="vDbf"></param>
        /// <param name="vUserID"></param>
        /// <param name="vPassword"></param>
        /// <param name="vSecurity"></param>
        public virtual void InitDbf(string vDbf, string vUserID, string vPassword, string vSecurity)
        {
            //
        }

        public bool IsEOF()
        {

            return false;

        }

        public bool IsOpen()
        {

            bool vOk;

            vOk = (pConnection.State == ConnectionState.Open);

            return vOk;

        }

        public OleDbConnection OpenDBF()
        {
            pConnection = new OleDbConnection(strConnect);

            pConnection.Open();

            return pConnection;            

        }


        public void CloseDBF()
        {
            pConnection.Close();
        }

        /// 
        /// <param name="vSQL"></param>
        public void OpenSQL(string vSQL)
        {
           pCommand = new OleDbCommand(vSQL, pConnection);
           pRecordset = pCommand.ExecuteReader(); //执行command并得到相应的DataReader                
        }

        /// 
        /// <param name="vSQL"></param>
        public void ExecSQL(string vSQL)
        {
             pCommand = new OleDbCommand(vSQL, pConnection);
             pCommand.ExecuteNonQuery();            
        }

        public void CloseTBL()
        {
            if (pRecordset!=null)
                pRecordset.Close();

        }

        public bool Record_Read()
        {
            return pRecordset.Read();
            
        }

        public void Record_MoveNext()
        {

            // pRecordset.MoveNext();
        }

        public void Record_Update()
        {

            // pRecordset.Update();
        }

        public void Record_AddNew()
        {

            //pRecordset.AddNew();
        }

        public void BeginTrans()
        {

            // pConnection.BeginTrans();
        }

        public void CommitTrans()
        {

            //pConnection.CommitTrans();
        }

        public void RollbackTrans()
        {

            //pConnection.RollbackTrans();
        }

        ///////////////////////////////
        public int ReadInt16(string vField)
        {
            int vIndex;

            vIndex = pRecordset.GetOrdinal(vField);

            if (!pRecordset.IsDBNull(vIndex))
                return pRecordset.GetInt16(vIndex);
            else
                return -10000;

        }
        public int ReadInt32(string vField)
        {
            int vIndex;

            vIndex = pRecordset.GetOrdinal(vField);

            if (!pRecordset.IsDBNull(vIndex))
                return pRecordset.GetInt32(vIndex);
            else
                return -10000;
           

        }

        public double ReadDouble(string vField)
        {
            int vIndex;

            vIndex = pRecordset.GetOrdinal(vField);

            if (!pRecordset.IsDBNull(vIndex))
                return pRecordset.GetDouble(vIndex);
            else
                return -10000; ;

        }

        public bool ReadBool(string vField)
        {
            int vIndex;

            vIndex = pRecordset.GetOrdinal(vField);

            if (!pRecordset.IsDBNull(vIndex))
                return pRecordset.GetBoolean(vIndex);
            else
                return false; ;
        }

        public string ReadString(string vField)
        {
            int vIndex;

            vIndex = pRecordset.GetOrdinal(vField);

            if (!pRecordset.IsDBNull(vIndex))
                return pRecordset.GetString(vIndex);
            else
                return "IsDBNull"; ;
        }

    }//end CDataRw

}//end namespace RwBase