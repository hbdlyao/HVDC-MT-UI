///////////////////////////////////////////////////////////
//  CRwDbf.cs
//  Implementation of the Class CRwDbf
//  Generated by Enterprise Architect
//  Created on:      10-5��-2017 9:23:45
//  Original author: open2
///////////////////////////////////////////////////////////
using Yao.BaseFrame.Func;

namespace Yao.BaseFrame.Rw
{
    public class CRwDbf
    {

        protected CRwAdo RwAdo;

        protected string tblName;

        protected int tblType;
        protected int devType;

        protected string SqlStr="";
        protected string SqlParam = "";

        public void InitType(int vtblType, int vDevType)
        {
            tblType = vtblType;
            devType = vDevType;
        }

        public void InitTable(string vtblName)
        {
            tblName = vtblName;
        }

        public void InitAdo(CRwAdo vAdo)
        {
            RwAdo = vAdo;
        }



 public string GetString(string vStr)
{
	return CMyFunc.GetString(vStr);
}

 public string GetString(double vX)
{
	return CMyFunc.GetString(vX);

}
 public string GetString(int vX)
{
	return CMyFunc.GetString(vX);
}

        public virtual void OnLoad()
        {
            string vSQL;

            vSQL = "select * from " + tblName;
            OnLoad(tblName, vSQL);

        }

        public virtual void OnSave()
        {
            string vSQL;

            vSQL = "delete * from " + tblName;
            RwAdo.ExecSQL(vSQL);

            //
            OnSave(tblName);

        }
        protected virtual void OnLoad(string vtblName, string vSQL_Load)
        {
        }

        protected virtual void OnSave(string vtblName, string vSQL_Save="")
        {
        }

    }//end CRwDbf

}//end namespace RwBase