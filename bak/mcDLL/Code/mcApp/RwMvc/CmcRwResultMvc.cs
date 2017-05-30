using Hvdc.MT.HvdcCommon;
using Hvdc.MT.mc.Def;
using Hvdc.MT.mc.Solve;
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

        protected override void doSave()
        {
            int vN;
            string vSQL;

            vSQL = "delete * from mcResult ";
            vSQL = vSQL + " where ResultName = ";
            vSQL = vSQL + " '";
            vSQL = vSQL + pResult.CalName;
            vSQL = vSQL + "' ";

            RwAdo.ExecSQL(vSQL);


            string tblName = "mcResult";

            //cout << "Save---" << tblName << "---" << endl;

            vN = pResult.datDim;

            for (int i = 0; i < vN; i++)
            {
                //
                SqlStr = "Insert into " + tblName;
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
            SqlStr = SqlStr + "ResultName, ";
            SqlParam = SqlParam + GetString(vResult.CalName) + ",";

            SqlStr = SqlStr + "CaseID, ";
            SqlParam = SqlParam + GetString(vResult.CaseID) + ",";

            SqlStr = SqlStr + "StationName, ";
            SqlParam = SqlParam + GetString(vResult.StationName) + ",";

            SqlStr = SqlStr + "PdPer, ";
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
