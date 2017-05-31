using Hvdc.MT.HvdcCommon;
using Hvdc.MT.mc.Def;
using Hvdc.MT.mc.Solve;
using System.Collections.Generic;
using System.Data.OleDb;
using Yao.BaseFrame.Rw;

namespace Hvdc.MT.mc.RwMvc
{
    public class CmcRwResultMvc : CRwMvcAccess
    {
        protected CmcResult pResult;

        public void InitResult(CmcResult vResult)
        {
            pResult = vResult;
        }


        public void OnLoadTable(string vCalName)
        {
            try
            {
                using (RwAdo.OpenDBF())
                {
                    doLoadTable(vCalName);

                    //
                    RwAdo.CloseDBF();

                }//

            }
            catch (OleDbException)
            {
                throw;
            }


        }

        /// <summary>
        /// void
        /// </summary>
        protected void doLoadTable(string vCalName)
        {
            string vSQL;
            string tblName = "mcResult";

            vSQL = "select * from " + tblName;
            vSQL = vSQL + " where CalName = ";
            vSQL = vSQL + " '";
            vSQL = vSQL + pResult.CalName;
            vSQL = vSQL + "' ";
            vSQL = vSQL + "order by CalName,CaseID,StationName, PdPercent";

            RwAdo.OpenSQL(vSQL);
       
            RecResultData vData = new RecResultData();

            IList<string> vStr = new List<string>();
            CmcCase vCase;

            int vN = 0;
            while (RwAdo.Record_Read())
            {
                vStr.Clear();
                vStr.Add(RwAdo.ReadString("CalName"));
                vStr.Add(RwAdo.ReadString("CaseID"));
                vStr.Add(RwAdo.ReadString("StationName"));
                //vStr.Add(RwAdo.ReadDouble("PdPercent").ToString());

                vCase = pResult.NewCase(vStr);

                doLoad(ref vData);

                vCase.AddRecord(vData);

                //
                pResult.DataList.Add(vData);

                vN = vN + 1;

            }//for

            RwAdo.CloseTBL();

        }

        protected void doLoad(ref RecResultData vData)
        {
            vData.CalName = RwAdo.ReadString("CalName");
            vData.CaseID = RwAdo.ReadString("CaseID");
            vData.StationName = RwAdo.ReadString("StationName");
            vData.PdPer = RwAdo.ReadDouble("PdPercent");

            vData.Uac = RwAdo.ReadDouble("Uac");
            vData.Uv = RwAdo.ReadDouble("Uv");
            vData.Udio = RwAdo.ReadDouble("Udio");
            vData.Ud = RwAdo.ReadDouble("Ud");
            vData.UdL = RwAdo.ReadDouble("UdL");
            vData.Id = RwAdo.ReadDouble("DcId");
            vData.Pd = RwAdo.ReadDouble("Pd");
            vData.Pconv = RwAdo.ReadDouble("Pconv");
            vData.Qconv = RwAdo.ReadDouble("Qconv");

            vData.TC = RwAdo.ReadInt32("TC");
            vData.alphaOrgamma = RwAdo.ReadDouble("alphaOrgamma");
            vData.miu = RwAdo.ReadDouble("miu");
            vData.Qf_max = RwAdo.ReadDouble("Qf_max");
            vData.Qf_min = RwAdo.ReadDouble("Qf_min");

            vData.Udio_N = RwAdo.ReadDouble("Udio_N");
            vData.Uv_N = RwAdo.ReadDouble("Uv_N");

            vData.Tk_N = RwAdo.ReadDouble("Tk_N");
            vData.Tk = RwAdo.ReadDouble("Tk");

            vData.Ud6Valve = RwAdo.ReadDouble("Ud6Valve");
            vData.Pd6Valve = RwAdo.ReadDouble("Pd6Valve");

            vData.Pac6Valve = RwAdo.ReadDouble("Pac6Valve");
            vData.Qac6Valve = RwAdo.ReadDouble("Qac6Valve");

        }


        public void OnSaveTable(string vCalName)
        {
            try
            {
                using (RwAdo.OpenDBF())
                {
                    doSaveTable(vCalName);

                    //
                    RwAdo.CloseDBF();

                }//

            }
            catch (OleDbException)
            {
                throw;
            }


        }


        protected void doSaveTable(string vCalName)
        {
            int vN;
            string vSQL;

            vSQL = "delete * from mcResult ";
            vSQL = vSQL + " where CalName = ";
            vSQL = vSQL + " '";
            vSQL = vSQL + pResult.CalName;
            vSQL = vSQL + "' ";

            RwAdo.ExecSQL(vSQL);


            vN = pResult.datDim;

            for (int i = 0; i < vN; i++)
            {
                //
                SqlStr = "Insert into mcResult" ;
                SqlParam = "";
                //
                SqlStr = SqlStr + " (";
                SqlParam = SqlParam + " Values ( ";

                //
                doSave(pResult.DataList[i]);

                //
                SqlStr = SqlStr + " ) ";
                SqlParam = SqlParam + " ) ";
                //
                SqlStr = SqlStr + SqlParam;

                //
                RwAdo.ExecSQL(SqlStr);

                //cout << "   --" << vDev->ShowName() << endl;


            }//for


            RwAdo.CloseTBL();

        }

        protected void doSave(RecResultData vResult)
        {
            SqlStr = SqlStr + "CalName, ";
            SqlParam = SqlParam + GetString(vResult.CalName) + ",";

            SqlStr = SqlStr + "CaseID, ";
            SqlParam = SqlParam + GetString(vResult.CaseID) + ",";

            SqlStr = SqlStr + "StationName, ";
            SqlParam = SqlParam + GetString(vResult.StationName) + ",";

            SqlStr = SqlStr + "PdPercent, ";
            SqlParam = SqlParam + GetString(vResult.PdPer) + ",";

            SqlStr = SqlStr + "Uac, ";
            SqlParam = SqlParam + GetString(vResult.Uac) + ",";
            SqlStr = SqlStr + "Uv, ";
            SqlParam = SqlParam + GetString(vResult.Uv) + ",";
            SqlStr = SqlStr + "Udio, ";
            SqlParam = SqlParam + GetString(vResult.Udio) + ",";
            SqlStr = SqlStr + "Ud, ";
            SqlParam = SqlParam + GetString(vResult.Ud) + ",";
            SqlStr = SqlStr + "UdL, ";
            SqlParam = SqlParam + GetString(vResult.UdL) + ",";
            SqlStr = SqlStr + "DcId, ";
            SqlParam = SqlParam + GetString(vResult.Id) + ",";
            SqlStr = SqlStr + "Pd, ";
            SqlParam = SqlParam + GetString(vResult.Pd) + ",";
            SqlStr = SqlStr + "Pconv, ";
            SqlParam = SqlParam + GetString(vResult.Pconv) + ",";
            SqlStr = SqlStr + "Qconv, ";
            SqlParam = SqlParam + GetString(vResult.Qconv) + ",";

            SqlStr = SqlStr + "TC, ";
            SqlParam = SqlParam + GetString(vResult.TC) + ",";
            SqlStr = SqlStr + "alphaOrgamma, ";
            SqlParam = SqlParam + GetString(vResult.alphaOrgamma) + ",";
            SqlStr = SqlStr + "miu, ";
            SqlParam = SqlParam + GetString(vResult.miu) + ",";
            SqlStr = SqlStr + "Qf_max, ";
            SqlParam = SqlParam + GetString(vResult.Qf_max) + ",";
            SqlStr = SqlStr + "Qf_min, ";
            SqlParam = SqlParam + GetString(vResult.Qf_min) + ",";

            SqlStr = SqlStr + "Udio_N, ";
            SqlParam = SqlParam + GetString(vResult.Udio_N) + ",";
            SqlStr = SqlStr + "Uv_N, ";
            SqlParam = SqlParam + GetString(vResult.Uv_N) + ",";

            SqlStr = SqlStr + "Tk_N, ";
            SqlParam = SqlParam + GetString(vResult.Tk_N) + ",";

            SqlStr = SqlStr + "Tk, ";
            SqlParam = SqlParam + GetString(vResult.Tk) + ",";

            SqlStr = SqlStr + "Ud6Valve, ";
            SqlParam = SqlParam + GetString(vResult.Ud6Valve) + ",";
            SqlStr = SqlStr + "Pd6Valve, ";
            SqlParam = SqlParam + GetString(vResult.Pd6Valve) + ",";
            SqlStr = SqlStr + "Pac6Valve, ";
            SqlParam = SqlParam + GetString(vResult.Pac6Valve) + ",";

            SqlStr = SqlStr + "Qac6Valve";
            SqlParam = SqlParam + GetString(vResult.Qac6Valve) + "";


        }
    }
}
