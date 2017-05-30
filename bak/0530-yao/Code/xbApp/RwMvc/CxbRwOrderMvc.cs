using Hvdc.MT.xb.Solve;
using System.Data;
using Yao.BaseFrame.Rw;

namespace Hvdc.MT.xb.RwMvc
{
    class CxbRwOrderMvc : CRwMvcAccess
    {
        protected CxbOrder pOrder;
        public void InitOrder(CxbOrder vOrder)
        {
            pOrder = vOrder;
        }

        protected override void doLoad()
        {
            string vSQL;
            //
            vSQL = "select * from mcOrder_yao ";
            RwAdo.OpenSQL(vSQL);

            //cout << "Load---mcOrder_yao---" << endl;
            while (RwAdo.Record_Read())
            {
                pOrder.Flag_Ground = RwAdo.ReadString("Flag_Ground");
                pOrder.Flag_Ground = RwAdo.ReadString("Flag_Ud");
                pOrder.Flag_Ground = RwAdo.ReadString("Flag_Rd");
                pOrder.Flag_Ground = RwAdo.ReadString("Flag_Uac");

                pOrder.nValNum = RwAdo.ReadInt32("nValvor");
                pOrder.IsUdCustom = RwAdo.ReadInt32("IsUdCustom");
                pOrder.IsUacSwap = RwAdo.ReadInt32("IsUacSwap");
                pOrder.IsUdToGround = RwAdo.ReadInt32("IsUdToGround");
                //pOrder.Is6Pulse = RwAdo.ReadInt32("Is6Pulse");

                pOrder.PdStartPer = RwAdo.ReadDouble("PdStartPercent");
                pOrder.PdIncrePer = RwAdo.ReadDouble("PdIncrePer");
                pOrder.PdSize = RwAdo.ReadInt32("PdSize");


            }//while

            RwAdo.CloseTBL();
        }

        protected override void doSave()
        {
            string vSQL;
            string SqlStr, SqlParam;

            //
            vSQL = "delete from mcOrder_yao ";
            RwAdo.ExecSQL(vSQL);

            //
            //cout << "Save---" << tblName << "---" << endl;

            //
            SqlStr = "Insert into mcOrder_yao ";
            SqlParam = "Values ";
            //
            SqlStr = SqlStr + " ( ";
            SqlParam = SqlParam + " ( ";

            SqlStr = SqlStr + "Flag_Ground, ";
            SqlParam = SqlParam + GetString(pOrder.Flag_Ground) + ",";

            SqlStr = SqlStr + "Flag_Ud, ";
            SqlParam = SqlParam + GetString(pOrder.Flag_Ud) + ",";

            SqlStr = SqlStr + "Flag_Rd, ";
            SqlParam = SqlParam + GetString(pOrder.Flag_Rd) + ",";

            SqlStr = SqlStr + "Flag_Uac, ";
            SqlParam = SqlParam + GetString(pOrder.Flag_Uac) + ",";

            SqlStr = SqlStr + "IsUdCustom, ";
            SqlParam = SqlParam + GetString(pOrder.IsUdCustom) + ",";

            SqlStr = SqlStr + "IsUacSwap, ";
            SqlParam = SqlParam + GetString(pOrder.IsUacSwap) + ",";

            SqlStr = SqlStr + "IsUdToGround, ";
            SqlParam = SqlParam + GetString(pOrder.IsUdToGround) + ",";

            SqlStr = SqlStr + "nValvor, ";
            SqlParam = SqlParam + GetString(pOrder.nValNum) + ",";

            SqlStr = SqlStr + "PdStartPercent, ";
            SqlParam = SqlParam + GetString(pOrder.PdStartPer) + ",";

            SqlStr = SqlStr + "PdIncrePer, ";
            SqlParam = SqlParam + GetString(pOrder.PdIncrePer) + ",";

            SqlStr = SqlStr + "PdSize ";
            SqlParam = SqlParam + GetString(pOrder.PdSize);

            //SqlStr = SqlStr + "Is6Pulse ";
            //SqlParam = SqlParam + GetString(pOrder.Is6Pulse) + "";

            //
            SqlStr = SqlStr + " ) ";
            SqlParam = SqlParam + " ) ";
            //
            SqlStr = SqlStr + SqlParam;

            //
            RwAdo.ExecSQL(SqlStr);

            RwAdo.CloseTBL();

            //cout << " Finished mc_Order " << endl;
        }
        
    }
}
